# FrostyToolSuite - Level Editor for Mirror's Edge Catalyst
The most advanced modding platform for games running on DICE's Frostbite game engine.

## Changes

- Added a Mirror's Edge Catalyst profile to the solution
- (TODO) Copmiling only the Entity Generator plugin to obtain Entity Boilerplates for MEC (not present in the repo)
- Fixed GameShared Entity definitions incompatible with MEC SDK
- Fixed crash on drag and drop of prefabs into the schematic editor
- Fixed crash on opening SubWorldData assets containing StaticInstances with MeshVariations
- Updated Entity Definitions in MEC Entity Boilerplates


## Guide

1. Download the [Frosty Editor 1.0.7 Backported](https://github.com/HarGabt/FrostyToolsuite/releases/tag/v1.0.7_24.11.30), a fork by HerGabt
2. Add the Level Editor plugin to the Plugins folder of the Editor
3. Put [strings.txt](https://drive.google.com/file/d/1jMtY9P0GvUghGK1Y3vwg1RL91s6vwk7x/view) by [zhpete](https://github.com/zhpete) in the main Editor folder

4. After creating your mod, it needs to be ported to 1.0.6.3 Frosty Mod Manager.
<br>   4.1 This has to be done by hand by exporting all modified assets, bundles and chunks in .BIN format, and importing them into 1.0.6.3 Frosty Editor
<br>   4.2 If an asset has been added to another bundle, it needs to be manually added back in
<br>   4.3 If duplicated or new assets have been created, they need to be added again in prefabs using these assets (because of GUID randomization)

Porting process is tedious, however it needs to be done for compatibility with other mods
<br>  *...and to avoid the "it doesn't work for me/it crashes my game" kind of comment section.*

## Assets and entities in Frostbite games

### Modifying base assets
Mirror's Edge Catalyst does not use many of assets that SWBFII and MEA require. I had to remove those for the compilation to be successful, which makes this fork **incompatible with other Frostbite games**

### Boilerplates
Compilation of the plugin requires a list of entities and their definitions in order to function. A base for this can be exported with an element of the *working* Level Editor plugin...

## Boilerplates in the Level Editor

Boilerplates are files containing definitions of types and entities used in the game. One file for each entity.

Compiling the level editor seems like an impossibility due to The Boilerplate Conundrum(tm).
<br>To amend the impossibility of this, you can make a custom plugin containing *only* the Entity Generator tool. I have not included that in the repository yet. The Resulting boilerplates are devoid of any definitions, however. For most entities it's fine, but some require extensions to function.

It turns out you can cross-reference entities from SWFBII and MEA which *do* contain those definitions. They can be incompatible with MEC, but can be modified to work with it. It is a very tedious process.

But then still, there are conflicts between GameShared assets, and needs to be resolved manually for each error.
<br>Sometimes, the Level Editor itself is fighting against you, as some functions were not written. I added some of those aswell.

Lastly, the Editor itself. 

1.0.7 Frosty Editor lacks some functionalities of 1.0.6.3, which is partially alleviated by using [HerGabt's 1.0.7 backport project](https://github.com/HarGabt/FrostyToolsuite/tree/1.0.7_test_locale_from_wavebend)


> But what about UI and Widgets?

  MEA version of the plugin has a UI editor. It requires all assets with UI elements to be properly defined and assigned in the UI editor implementation.
  - MEC has a custom UI system, PamUI
  - In the current release of this fork, this results in inability to edit UIwidget assets in Schematic View.



## Setup

1. Download Git https://git-scm.com/download/win.
2. Press the green "Code" button in the repository and copy the text under "HTTPS".
3. Create an empty folder, go inside it, right click an empty space and hit "Git Bash Here".
5. Type out ``git clone <HTTPS code>`` in the command prompt and hit enter. This should clone the project files into the folder.
6. Open the solution (.sln) with Visual Studio 2022, and make sure the project is set to ``MEC - Debug   x64``
7. Follow [the Level Editor setup guide](https://docs.google.com/document/d/1fVFt37MRPsl22kQrO5cX-N59mt-FcVoFCfNp0FcSLmE/edit?tab=t.0)

## License
The Content, Name, Code, and all assets are licensed under a Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International License.
