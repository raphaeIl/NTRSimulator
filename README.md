# NTRSimulator

## Server Emulator for a certain NTR game

![fox](docs/fox.png)

## Requirements
- .NET 8 SDK
- PostgreSQL
- mitmproxy
- CN Game Client is REQUIRED

## Installation Tutorial
1. Clone the repo.
2. Set `ConnectionStrings:Postgres` in `NTRSimulator/appsettings.json` (skip this step if your postgres password is "password")
3. Copy client table `*.bytes` files `C:\GF2Exilium\GF2 Game\GF2_Exilium_Data\LocalCache\Data\Table` into `NTRSimulator/bin/Debug/net8.0/Resources/Tables/`.
4. `build`

## Running

1. Start the Server
2. run `proxy.bat`
3. Start the Client

## Common Issues

- If you see nothing in the mitm console, this is a cert issue, please follow official mitm instructions for installing them.
- If you are unable to compile and getting a lot errors, this is most likely an outdated/broken proto version - right click on solution in vs -> clean solution -> build again
- **中国用户看这里**: 如果无法编译，并且报错提示 NuGet 包不存在，请使用梯子/VPN。本项目使用了自定义 NuGet 包源。


## Features
- [X] Gacha
- [X] All Characters, Weapons, Weapon Mods, Items
- [X] All Character Skins, Weapon Skins, Weapon Mod Skins
- [X] Command System 
    - `/inventory addall`
    - `/help`
- [X] Regular Dorm
- [X] Skin Gacha
- [X] Partial 3D Dorm Support

## TODO
- [ ] Full 3D Dorm Support
- [ ] Dorm Affinity System 
- [ ] Story
- [ ] Built-in GM

## Support & Discuss
[Discord Server](https://discord.gg/ZCWrqH9f9H)

## Special Thanks
- [rafi1212122](https://github.com/rafi1212122) - Inspired by rfi's previous ps, and also helping me with core logic
- [wazuin](https://github.com/wazuin) - Sponsor
