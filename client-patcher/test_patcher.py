import contextlib
import json
import struct
import tempfile
import unittest
from pathlib import Path
from unittest.mock import patch

import patcher
from table_codec import encode_field as f, patch_language_table, patch_table, validate_table, validate_language_table, language_rows, varint, fields


def table(messages):
    payload = b"".join(f(1, message) for message in messages)
    header = f(1, len(messages)) + f(3, f(2, f(2, len(payload))))
    return struct.pack("<I", len(header)) + header + payload


class TableTests(unittest.TestCase):
    def setUp(self):
        self.data = table([f(1, 11) + f(2, "确认".encode()) + f(8, b"unknown"), f(1, 12) + f(2, "故事".encode())])

    def test_noop_is_identical(self):
        self.assertEqual(patch_language_table(self.data, {}), self.data)

    def test_growth_rebuilds_index_and_preserves_story(self):
        changed = patch_language_table(self.data, {11: "Confirm this selection" * 50})
        patcher.verify_language(self.data, changed, {11: "Confirm this selection" * 50})
        self.assertEqual(validate_language_table(changed), 2)
        self.assertEqual(language_rows(changed)[12], "故事")

    def test_unknown_id_rejected(self):
        with self.assertRaises(ValueError):
            patch_language_table(self.data, {999: "No"})

    def test_truncated_and_overflow_input_rejected(self):
        for data in (b"\x80", b"\xff" * 9 + b"\x02", b"\x80" * 11):
            with self.assertRaises(ValueError):
                varint(data)
        for data in (b"", self.data[:3], self.data[:-1]):
            with self.assertRaises(ValueError):
                validate_table(data)

    def test_bad_field_number_rejected(self):
        with self.assertRaises(ValueError):
            list(fields(f(1 << 29, 1)))

    def test_banner_patch_preserves_rewards(self):
        data = table([f(1, 1001) + f(4, 3) + f(7, 10) + f(8, 20) + f(27, b"5:1082")])
        changed = patch_table(data, {1001: {8: 2147483647}})
        self.assertEqual(validate_table(changed), 1)
        vals = {x.number: x.value for x in fields(next(patcher.rows(changed)).value)}
        self.assertEqual(vals[27], b"5:1082")
        self.assertEqual(vals[7], 10)
        self.assertEqual(vals[8], 2147483647)

    def test_translation_validation(self):
        good = patcher.compatible
        self.assertTrue(good("造成<color=red>{0}</color>伤害", "Deals {0} damage")[0])
        self.assertFalse(good("造成{0}伤害", "Deals damage")[0])
        self.assertFalse(good("<sprite=7>确定", "Confirm")[0])
        self.assertFalse(good("价格30元", "Price: 20 yuan")[0])
        self.assertFalse(good("<color=red>确定</color>", "<color=red>Confirm")[0])


class TransactionTests(unittest.TestCase):
    def setUp(self):
        self.tmp = tempfile.TemporaryDirectory()
        root = Path(self.tmp.name)
        (root / "GF2_Exilium.exe").write_bytes(b"fixture, not an executable")
        directory = root / "GF2_Exilium_Data/LocalCache/Data/Table"
        directory.mkdir(parents=True)
        self.install = patcher.Installation(root)
        self.original = {name: table([f(1, 1) + f(2, "确认".encode())]) for name in patcher.LANGUAGE_FILES}
        self.desired = {name: patch_language_table(data, {1: "Confirm"}) for name, data in self.original.items()}
        for name, data in self.original.items():
            (directory / name).write_bytes(data)

    def tearDown(self):
        self.tmp.cleanup()

    def test_apply_restore_does_not_need_recipe_or_network(self):
        self.install.commit(self.desired, self.original, self.install.state())
        with patch.object(patcher, "require_closed"), patch.object(self.install, "lock", contextlib.nullcontext):
            self.install.restore(patcher.LANGUAGE_FILES)
        for name, data in self.original.items():
            self.assertEqual((self.install.table / name).read_bytes(), data)
            self.assertEqual((self.install.backups / name).read_bytes(), data)

    def test_external_edit_rejected_before_any_write(self):
        (self.install.table / patcher.BUILTIN).write_bytes(b"another mod")
        with self.assertRaises(ValueError):
            self.install.commit(self.desired, self.original, self.install.state())
        self.assertEqual((self.install.table / patcher.MAIN).read_bytes(), self.original[patcher.MAIN])
        self.assertFalse(self.install.backups.exists())

    def test_corrupt_backup_rejected(self):
        self.install.commit(self.desired, self.original, self.install.state())
        (self.install.backups / patcher.MAIN).write_bytes(b"damaged")
        with self.assertRaises(ValueError):
            self.install.commit(self.original, self.original, self.install.state())

    def test_second_write_failure_rolls_back_first(self):
        real = patcher.atomic_write
        failed = False
        def write(path, data):
            nonlocal failed
            if path == self.install.table / patcher.BUILTIN and not failed:
                failed = True
                raise OSError("simulated disk error")
            real(path, data)
        with patch.object(patcher, "atomic_write", write), self.assertRaises(OSError):
            self.install.commit(self.desired, self.original, self.install.state())
        for name, data in self.original.items():
            self.assertEqual((self.install.table / name).read_bytes(), data)

    def test_interrupted_commit_can_restore_mixed_state(self):
        self.install.commit(self.desired, self.original, self.install.state())
        state = self.install.state()
        for name in patcher.LANGUAGE_FILES:
            state["files"][name]["pending_sha256"] = [patcher.digest(self.original[name])]
        patcher.write_json(self.install.state_path, state)
        (self.install.table / patcher.MAIN).write_bytes(self.original[patcher.MAIN])
        with patch.object(patcher, "require_closed"), patch.object(self.install, "lock", contextlib.nullcontext):
            self.install.restore(patcher.LANGUAGE_FILES)
        for name, data in self.original.items():
            self.assertEqual((self.install.table / name).read_bytes(), data)

    def test_archive_excludes_future_and_preserves_other_tables(self):
        data = table([f(1, 10) + f(4, 3) + f(7, 10) + f(8, 20),
                      f(1, 20) + f(4, 4) + f(7, 30) + f(8, 50),
                      f(1, 30) + f(4, 9) + f(7, 10) + f(8, 20)])
        (self.install.table / patcher.GACHA).write_bytes(data)
        self.install.package = Path(self.tmp.name) / "package"
        patcher.write_json(self.install.package / "recipes/manifest.json",
                           {"originals": {patcher.GACHA: patcher.digest(data)}})
        with patch.object(patcher, "require_closed"), patch.object(self.install, "check_version"), \
                patch.object(self.install, "lock", contextlib.nullcontext):
            self.install.archive(now=25)
            after = list(patcher.rows((self.install.table / patcher.GACHA).read_bytes()))
            before = list(patcher.rows(data))
            self.assertNotEqual(after[0].raw, before[0].raw)
            self.assertEqual([x.raw for x in after[1:]], [x.raw for x in before[1:]])
            for name, original in self.original.items():
                self.assertEqual((self.install.table / name).read_bytes(), original)
            self.install.restore((patcher.GACHA,))
            self.assertEqual((self.install.table / patcher.GACHA).read_bytes(), data)

    def test_damaged_reference_rejected_without_extraction(self):
        bad = Path(self.tmp.name) / "reference.zip"
        bad.write_bytes(b"not the pinned publisher reference")
        with self.assertRaisesRegex(ValueError, "damaged"):
            patcher.reference_text(self.install.state_dir, bad)


if __name__ == "__main__":
    unittest.main()
