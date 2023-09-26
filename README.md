# SandstoneLauncher
✨ Project for my own Minecraft Launcher I made in 2019r. ✨
<br>
Actually it only works using CLI

See [Compose Application Repository](https://www.github.com/kacperfaber/SandstoneLauncher-App)

## Usage

Documentation from `Cli/Docs/cli.txt`

```txt
﻿1. This file presents how to use SandstoneLauncher.Minecraft.Cli.exe

2. Definitions:
-) SandstoneLauncher.Minecraft.Cli.exe [CLI] - Command Line Interface Program runs on .NET5 platform.

3. Commands

[SandstoneLauncher.Minecraft.Cli.Commands.LauncherProfilesCommands]
3.1 launcher_profiles create -int:width -int:height -str:name -str:gameDir -str:javaDir -str:javaArgs -str:lastVersionId
3.2 launcher_profiles update -int:width -int:height -str:name -str:gameDir -str:javaDir -str:javaArgs -str:lastVersionId
3.3 launcher_profiles delete -str:name

ADDITIONALLY:

3.1.1 launcher_profiles list

[SandstoneLauncher.Minecraft.Cli.Commands.PlayCommands]
3.4 play launch -str:v [version] -str:username -int:width -int:height -int:xms -int:xmx

ADDITIONALLY:
3.4.1 play launch -str:v [version] -str:username -int:width -int:height -int:xms -int:xmx -str?:gameDir -str?:javaDir -str?:javaArgs -str:launcherBrand

[SandstoneLauncher.Minecraft.Cli.Commands.VersionCommands]
3.5 version list-dir
3.6 version list
3.7 version delete <version_name>

[SandstoneLauncher.Minecraft.Cli.Commands.DownloadCommands]
3.8 download assets -str:v [version]
3.9 download game -str:v [version] -OS:os [WINDOWS/LINUX]

4. How to download game files?

Use command 3.9. 
You need to specify operating system [WINDOWS/LINUX], and game version.

When cli responds $.data is true, game files are successfully downloaded.

5. How to launch game?

Use command 3.4.
You need to specify parameters:
- v: Game Version, must be downloaded.
- username: Player name
- width: Resolution Width
- height: Resolution Height
- xms: Minimum Memory
- xmx: Maximum Memory

When $.data is true, then java process is launched. - We don't know it wouldn't crash

And actually there's no way to read output.

6. How to create launcher profile?

Use command 3.1
You need to specify parameters:
width -int:height -str:name -str:gameDir -str:javaDir -str:javaArgs
- lastVersionId: Last used Game Version ID
- width: Resolution Width
- height: Resolution Height
- gameDir: Should be %appdata%/.minecraft
- javaDir: Directory where java is installed.
- javaArgs: Java Arguments, For example: -Xmx1G -XX:+UseConcMarkSweepGC -XX:+CMSIncrementalMode -XX:-UseAdaptiveSizePolicy -Xmn128M

7. How to get all known launcher profiles?

Use command 3.1.1
]
Command will return response, where $.data is list of profiles [see models [8.1]]

8. Models

1. LauncherProfile
+ gameDir: string
+ javaDir: string
+ javaArgs: string
+ name: string
+ resolution: { width: int, height: int }
+ lastVersionId: string
```

# Author
Kacper Faber
