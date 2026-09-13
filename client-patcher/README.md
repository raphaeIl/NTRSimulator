# Optional English UI and recruitment archive

Chinese remains the default. Nothing runs automatically when the server starts.
The patcher offers independent language and banner switches, with restoration of
the original files. It requires Windows and Python 3.11+ with Tkinter (the normal
python.org installer includes it). No Python packages are required.

目前默认保留中文。英文界面和历史招募是两个独立的可选补丁，可随时恢复原文件。
关闭游戏后运行仓库根目录的 `Client Patcher.cmd`，选择包含 `GF2_Exilium.exe`
的目录。`Enable English UI` 启用英文界面，`Restore Chinese UI` 恢复中文。
剧情对话不翻译。历史招募还需要在服务器配置中开启 `Recruitment:IncludePastBanners`。

## Supported client

CN **4.0.5136**, static tables **1152911**. Exact original table hashes are pinned
in [recipes/manifest.json](recipes/manifest.json). This is a client table patch,
used alongside the existing emulator launcher; it does not install the game or
replace the connection patcher.

1. Close the game.
2. Run **Client Patcher.cmd** from the repository root.
3. Choose the folder containing **GF2_Exilium.exe**.
4. Select **Enable English UI** or **Restore Chinese UI**.
5. Start the game with the emulator's usual launcher.

The first English application downloads a **184 MB** reference archive directly
from the [publisher CDN](https://gf2-us-cdn.sunborngame.com/prod/data/1151583/bk_stc_pb.zip).
It is pinned by size and SHA-256, read as data, and never executed. Later switches
work offline using that cache. Restoring Chinese needs only the original backups.
This says nothing about the game's other network requirements.

## Translation coverage and provenance

The recipe translates **61,150 main UI entries** and **68 builtin entries** (the
other three builtin entries already contain English). It covers menus, settings,
buttons, names, equipment labels, recruitment, objectives, tutorials, combat
effects, skill mechanics, and help. **381,078 story entries are excluded**,
including dialogue and personal-letter bodies. Character names shared by UI
labels may be translated while the dialogue itself remains Chinese.

There are **57,717 publisher-reference entries** and **3,433 custom entries**.
CN and Global IDs differ: the recipe uses reviewed CN-to-Global ID mappings based
on matching table context or identical Chinese source wording, not positional
replacement. New CN text uses community translations and conservative templates.
Proper names and terminology for content absent from Global may need review.
Some community translations omit color/size emphasis while preserving functional
arguments. No story text is needed to construct the patch.

- [official-index.tsv](recipes/official-index.tsv) contains IDs only. The official
  English language table is **not redistributed** in this repository.
- [custom-en.json](recipes/custom-en.json) contains editable community translations.
- [provenance.tsv](recipes/provenance.tsv) records each selected ID's source and
  table context for review.
- `export_recipe.py` validates and exports a reviewed catalog against original CN
  tables and an explicit list of protected story IDs. It rejects incomplete,
  duplicated, mismatched, or protected entries.

Text baked into images, hardcoded client labels, SDK login screens, and web
announcements can still be Chinese. This is **not a translation of every pixel**
in the client, and it does not replace voices or artwork.

## Past banners

The server fixes a time-unit mismatch: login and periodic `SC_Sync` packets now
both use current Unix **seconds**. Previously login used a fixed date in seconds,
then periodic sync sent milliseconds, making limited banners appear expired.
`timewarp` also takes seconds and rejects millisecond-sized values.

For an archive, both sides must opt in:

1. Set the following in the **running server's** `appsettings.json`, then restart
   the server:

   ```json
   "Recruitment": {
     "IncludePastBanners": true
   }
   ```

2. With the game closed, select **Enable past banners** in the client patcher.
3. Restart the client. Use the recruitment sidebar to scroll through banners.

The client patch extends the end dates of released doll/weapon banners to January
2038. It preserves start dates, reward pools, IDs, artwork references, and all
other fields. The supported table contains **268** such banners, including reruns.
Future banners remain excluded; this cannot add dolls or artwork absent from the
installed client. Outfit procurement retains its existing separate handler.

Server draws are **free test acquisitions**, not a simulation of official odds,
currency costs, pity, or duplicate conversion. One- and ten-draw requests return
featured Elite dolls/weapons from the selected banner (or the Elite pool for a
permanent banner). Selectable banners honor the chosen reward for the session.
New dolls are added at level 60 with their default weapon; already-owned dolls
retain their progression. Duplicate results reuse existing inventory entities.
Every response echoes the requested banner ID.

To disable the archive, choose **Restore banner schedule**, set
`IncludePastBanners` to `false`, and restart the server/client. This does not change
the selected UI language. The archive is disabled in the distributed configuration.

## Backups, updates, and command line

Backups, the reference cache, and a transaction journal live in
`<game>/.ntr-client-patches/`. Keep this folder. Original backups are never
overwritten. File changes use an exclusive installation lock, temporary files,
atomic replacement, and rollback. A journal permits restoration after interrupted
writes. The patcher refuses unknown client versions, altered tables, damaged
backups, or a running game; it does not request administrator rights or modify
executables, security settings, certificates, or the server database.

**Restore both patches before updating the client.** If an update or another mod
has already changed a patched table, the patcher stops instead of overwriting it.
Do not bypass the hash checks or copy backups from a different client version.

```text
python client-patcher/patcher.py english --game-dir "D:/GF2/Game" --download-source
python client-patcher/patcher.py chinese --game-dir "D:/GF2/Game"
python client-patcher/patcher.py archive --game-dir "D:/GF2/Game"
python client-patcher/patcher.py schedule --game-dir "D:/GF2/Game"
python client-patcher/patcher.py status --game-dir "D:/GF2/Game"
```

An existing publisher archive can be supplied with `--source-zip <path>`.
`--state-dir <path>` stores backups/cache outside the game folder; use the same
state directory for all future switches and restores.

## Validation

```text
python -m unittest discover -s client-patcher -p test_patcher.py -v
dotnet run --project NTRSimulator.RecruitmentTests
dotnet run --project NTRSimulator.RecruitmentTests -- /path/to/server/Resources
```

The 14 Python tests cover index rebuilding, non-text preservation, malformed input,
translation arguments, archive date filtering, damaged references/backups,
conflicting edits, rollback, and interrupted-write recovery. Recruitment tests
send and decode real loopback protocol frames for clocks, current/past draws,
selection, invalid requests, and inventory preservation. With the supported CN
resources, **293 checks** pass, including reward references for all 273 doll/weapon
banner records among the table's 277 records.

An additional full-data round trip verified all 381,078 protected story entries
unchanged, exactly 61,150 changed main-language rows, valid rebuilt indexes, and
byte-identical restoration of both language files and the recruitment table.
