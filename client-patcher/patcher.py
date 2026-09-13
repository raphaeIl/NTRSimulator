"""Opt-in, reversible client table patches for NTRSimulator. Python 3.11+, stdlib only."""
from __future__ import annotations

import argparse
import contextlib
import csv
import hashlib
import io
import json
import os
from pathlib import Path
import subprocess
import sys
import tempfile
import time
import urllib.request
import zipfile

from table_codec import fields, rows, language_rows, patch_language_table, patch_table, validate_language_table, validate_table
from catalog_validation import compatible

PACKAGE = Path(__file__).resolve().parent
MAIN = "LangPackageTableCnData.bytes"
BUILTIN = "LangPackageTableCnBuiltinData.bytes"
GACHA = "GachaData.bytes"
LANGUAGE_FILES = (MAIN, BUILTIN)
ALLOWED_FILES = (*LANGUAGE_FILES, GACHA)
CLIENT = "4.0.5136"
STC = "1152911"
SOURCE_URL = "https://gf2-us-cdn.sunborngame.com/prod/data/1151583/bk_stc_pb.zip"
SOURCE_SHA256 = "62f327e14caef69358836f15f823a71fb41abcf4c571dd80142c2e0352f97815"
SOURCE_BYTES = 183858679


def digest(data):
    return hashlib.sha256(data).hexdigest()


def read_json(path):
    return json.loads(path.read_text(encoding="utf-8-sig"))


def atomic_write(path, data):
    path.parent.mkdir(parents=True, exist_ok=True)
    fd, temporary = tempfile.mkstemp(prefix=path.name + ".", suffix=".tmp", dir=path.parent)
    try:
        with os.fdopen(fd, "wb") as handle:
            handle.write(data)
            handle.flush()
            os.fsync(handle.fileno())
        os.replace(temporary, path)
    finally:
        if os.path.exists(temporary):
            os.unlink(temporary)


def write_json(path, data):
    atomic_write(path, (json.dumps(data, ensure_ascii=False, indent=2) + "\n").encode("utf-8"))


def require_closed():
    if os.name != "nt":
        raise ValueError("Apply/restore is supported on Windows only.")
    result = subprocess.run([str(Path(os.environ["SystemRoot"]) / "System32/tasklist.exe"),
                             "/FI", "IMAGENAME eq GF2_Exilium.exe", "/FO", "CSV", "/NH"],
                            capture_output=True, text=True, check=True,
                            creationflags=subprocess.CREATE_NO_WINDOW)
    if any(row and row[0].casefold() == "gf2_exilium.exe" for row in csv.reader(io.StringIO(result.stdout))):
        raise ValueError("Close Girls' Frontline 2 before applying or restoring a patch.")


class Installation:
    def __init__(self, game_dir, state_dir=None, package=PACKAGE):
        self.game = Path(game_dir).resolve(strict=True)
        if self.game.is_file() and self.game.name.lower() == "gf2_exilium.exe":
            self.game = self.game.parent
        if not (self.game / "GF2_Exilium.exe").is_file():
            raise ValueError("Choose the folder containing GF2_Exilium.exe.")
        # The table folder may intentionally be a junction to a separate data disk.
        self.table = (self.game / "GF2_Exilium_Data/LocalCache/Data/Table").resolve(strict=True)
        self.state_dir = Path(state_dir).resolve() if state_dir else self.game / ".ntr-client-patches"
        if self.state_dir == self.table or self.state_dir.is_relative_to(self.table):
            raise ValueError("Backups must be outside the game table directory.")
        self.package = Path(package)
        self.state_path = self.state_dir / "state.json"
        self.backups = self.state_dir / "originals"

    def check_version(self):
        cfg = dict(line.split(":", 1) for line in
                   (self.table.parent / "GameConfig.cfg").read_text(encoding="utf-8-sig").splitlines() if ":" in line)
        if cfg.get("ClientVersion") != CLIENT or cfg.get("StcTableVersion") != STC:
            raise ValueError(f"Supported version: CN {CLIENT}, tables {STC}. This client needs a different patch recipe.")

    @contextlib.contextmanager
    def lock(self):
        self.state_dir.mkdir(parents=True, exist_ok=True)
        path = self.state_dir / "patch.lock"
        # A held OS file lock is released even if the process crashes.
        import msvcrt
        with path.open("a+b") as handle:
            if handle.tell() == 0:
                handle.write(b"0")
                handle.flush()
            handle.seek(0)
            try:
                msvcrt.locking(handle.fileno(), msvcrt.LK_NBLCK, 1)
            except OSError as error:
                raise ValueError("Another patcher is working on this installation.") from error
            try:
                yield
            finally:
                handle.seek(0)
                msvcrt.locking(handle.fileno(), msvcrt.LK_UNLCK, 1)

    def state(self):
        state = read_json(self.state_path) if self.state_path.exists() else {"schema": 1, "files": {}}
        if state.get("schema") != 1 or not set(state.get("files", ())).issubset(ALLOWED_FILES):
            raise ValueError("Invalid backup state.")
        if state.get("table_path", str(self.table)) != str(self.table):
            raise ValueError("This backup belongs to a different game folder.")
        return state

    def original(self, name, expected, state):
        current = (self.table / name).read_bytes()
        spec = state["files"].get(name)
        if spec and spec["original_sha256"] != expected:
            raise ValueError("The backup and patch recipe are for different versions.")
        allowed = {expected}
        if spec:
            allowed.add(spec["current_sha256"])
            allowed.update(spec.get("pending_sha256", []))
        if digest(current) not in allowed:
            raise ValueError(f"{name} was changed by an update or another mod. Refusing to overwrite it.")
        backup = self.backups / name
        original = backup.read_bytes() if backup.exists() else current
        if digest(original) != expected:
            raise ValueError(f"The original Chinese backup is missing or damaged: {name}")
        return current, original

    def commit(self, desired, originals, state):
        # Validate every file before creating backups or changing any live table.
        if not set(desired).issubset(ALLOWED_FILES) or set(desired) != set(originals):
            raise ValueError("Unexpected patch target.")
        before = {}
        for name in desired:
            before[name], original = self.original(name, digest(originals[name]), state)
            if original != originals[name]:
                raise ValueError("Backup changed during preparation.")
        self.backups.mkdir(parents=True, exist_ok=True)
        for name, original in originals.items():
            path = self.backups / name
            if not path.exists():
                # Atomic promotion is protected by the installation lock; never overwrite a backup.
                atomic_write(path, original)
        previous = json.loads(json.dumps(state))
        pending = json.loads(json.dumps(state))
        pending["table_path"] = str(self.table)
        for name in desired:
            pending["files"][name] = {"original_sha256": digest(originals[name]),
                                      "current_sha256": digest(before[name]),
                                      "pending_sha256": [digest(desired[name])]}
        # Journal accepted before/after hashes so restore also works after abrupt termination.
        write_json(self.state_path, pending)
        changed = []
        try:
            for name, payload in desired.items():
                if payload != before[name]:
                    atomic_write(self.table / name, payload)
                    changed.append(name)
            for name, payload in desired.items():
                pending["files"][name] = {"original_sha256": digest(originals[name]), "current_sha256": digest(payload)}
            write_json(self.state_path, pending)
        except Exception:
            for name in reversed(changed):
                atomic_write(self.table / name, before[name])
            write_json(self.state_path, previous)
            raise

    def english(self, source_zip=None, download=False):
        require_closed()
        self.check_version()
        with self.lock():
            manifest = read_json(self.package / "recipes/manifest.json")
            state = self.state()
            originals = {name: self.original(name, manifest["originals"][name], state)[1] for name in LANGUAGE_FILES}
            reference = reference_text(self.state_dir, source_zip, download)
            custom = read_json(self.package / "recipes/custom-en.json")
            replacements = {int(key): value for key, value in custom.items()}
            for line in (self.package / "recipes/official-index.tsv").read_text(encoding="utf-8").splitlines():
                if not line or line.startswith("#"):
                    continue
                cn_id, en_id = map(int, line.split("\t"))
                if cn_id in replacements:
                    raise ValueError("Duplicate translation ID in recipe.")
                replacements[cn_id] = reference[en_id]
            builtin = {int(key): value for key, value in read_json(self.package / "recipes/builtin-en.json").items()}
            if len(replacements) != manifest["translated_ui_entries"]:
                raise ValueError("Translation recipe is incomplete.")
            desired = {}
            for name, translations in zip(LANGUAGE_FILES, [replacements, builtin], strict=True):
                source = language_rows(originals[name])
                if not set(translations).issubset(source):
                    raise ValueError("Translation IDs do not match this client.")
                for key, english in translations.items():
                    ok, why = compatible(source[key], english)
                    if not ok:
                        raise ValueError(f"Invalid translation {key}: {why}")
                desired[name] = patch_language_table(originals[name], translations)
                verify_language(originals[name], desired[name], translations)
            require_closed()  # The game may have been opened during preparation/download.
            self.commit(desired, originals, state)
            return f"English UI enabled: {len(replacements):,} main UI entries. Restart the game."

    def restore(self, names):
        require_closed()
        # Restoration needs only local backups, even if the recipe or source cache is gone.
        with self.lock():
            state = self.state()
            originals = {name: self.original(name, state["files"][name]["original_sha256"], state)[1]
                         for name in names if name in state["files"]}
            self.commit(originals, originals, state)
            return "Original Chinese UI restored." if tuple(names) == LANGUAGE_FILES else "Original banner schedule restored."

    def archive(self, now=None):
        require_closed()
        self.check_version()
        with self.lock():
            state = self.state()
            expected = read_json(self.package / "recipes/manifest.json")["originals"][GACHA]
            _, original = self.original(GACHA, expected, state)
            now = int(time.time()) if now is None else now
            changes = {}
            for row in rows(original):
                value = {f.number: f.value for f in fields(row.value)}
                if value.get(4, 0) in (3, 4, 6, 7) and value.get(7, 0) <= now:
                    # Only dates of released doll/weapon banners change; rewards and assets remain intact.
                    changes[value[1]] = {8: 2147483647}
            patched = patch_table(original, changes)
            if validate_table(patched) != validate_table(original):
                raise ValueError("Banner row count changed.")
            require_closed()
            self.commit({GACHA: patched}, {GACHA: original}, state)
            return f"Archive enabled for {len(changes)} released doll/weapon banners. Also enable Recruitment:IncludePastBanners on the server."

    def status(self):
        state = self.state()
        report = {}
        for name, spec in state["files"].items():
            current = digest((self.table / name).read_bytes())
            self.original(name, spec["original_sha256"], state)
            report[name] = "original" if current == spec["original_sha256"] else "patched"
        return report or {"language": "Chinese", "banners": "original schedule"}


def reference_text(state_dir, source_zip=None, download=False):
    path = Path(source_zip) if source_zip else Path(state_dir) / "cache/global-tables-1151583.zip"
    if not path.exists():
        if not download or source_zip:
            raise ValueError("English reference is not cached. Use --download-source once or supply --source-zip.")
        path.parent.mkdir(parents=True, exist_ok=True)
        fd, temporary = tempfile.mkstemp(prefix="reference-", suffix=".zip", dir=path.parent)
        try:
            with os.fdopen(fd, "wb") as output, urllib.request.urlopen(SOURCE_URL, timeout=60) as response:
                if not response.url.startswith("https://gf2-us-cdn.sunborngame.com/"):
                    raise ValueError("Unexpected publisher download redirect.")
                total = 0
                while chunk := response.read(1024 * 1024):
                    total += len(chunk)
                    if total > SOURCE_BYTES:
                        raise ValueError("Publisher archive is larger than expected.")
                    output.write(chunk)
            data = Path(temporary).read_bytes()
            if len(data) != SOURCE_BYTES or digest(data) != SOURCE_SHA256:
                raise ValueError("Publisher reference checksum mismatch.")
            os.replace(temporary, path)
        finally:
            if os.path.exists(temporary):
                os.unlink(temporary)
    data = path.read_bytes()
    if len(data) != SOURCE_BYTES or digest(data) != SOURCE_SHA256:
        raise ValueError("English reference is damaged or is a different version.")
    # Read one named member only: no executable is run and no archive paths are extracted.
    with zipfile.ZipFile(io.BytesIO(data)) as archive:
        return language_rows(archive.read("LangPackageTableEnusData.bytes"))


def verify_language(original, patched, replacements):
    if validate_language_table(original) != validate_language_table(patched):
        raise ValueError("Language row count changed.")
    for before, after in zip(rows(original), rows(patched), strict=True):
        bv = {f.number: f.value for f in fields(before.value)}
        av = {f.number: f.value for f in fields(after.value)}
        key = bv.get(1, 0)
        if key not in replacements and before.raw != after.raw:
            raise ValueError("An unselected row changed.")
        if key in replacements and av.get(2, b"").decode("utf-8") != replacements[key]:
            raise ValueError("Translated text was not preserved.")
        if [f.raw for f in fields(before.value) if f.number != 2] != [f.raw for f in fields(after.value) if f.number != 2]:
            raise ValueError("Non-text row data changed.")


def main():
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("command", choices=["english", "chinese", "archive", "schedule", "status"])
    parser.add_argument("--game-dir", required=True, type=Path)
    parser.add_argument("--state-dir", type=Path, help="Optional backup/cache folder outside the table directory")
    parser.add_argument("--source-zip", type=Path)
    parser.add_argument("--download-source", action="store_true", help="Download the 184 MB pinned publisher reference once")
    args = parser.parse_args()
    install = Installation(args.game_dir, args.state_dir)
    if args.command == "english":
        result = install.english(args.source_zip, args.download_source)
    elif args.command == "chinese":
        result = install.restore(LANGUAGE_FILES)
    elif args.command == "archive":
        result = install.archive()
    elif args.command == "schedule":
        result = install.restore((GACHA,))
    else:
        result = install.status()
    print(json.dumps(result, ensure_ascii=False, indent=2) if isinstance(result, dict) else result)


if __name__ == "__main__":
    try:
        main()
    except Exception as error:
        print(f"Client patcher: {error}", file=sys.stderr)
        sys.exit(1)
