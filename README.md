# FrostyToolSuite - Level Editor for Mirror's Edge Catalyst
The most advanced modding platform for games running on DICE's Frostbite game engine.

## Changes

- Added a Mirror's Edge Catalyst profile to the solution
- Fixed GameShared Entity definitions incompatible with MEC SDK
- Fixed crash on drag and drop of prefabs into the schematic editor*
- Updated Entity Definitions in MEC Entity Boilerplates
- Fixed a random crash when opening the viewport
- Updated StaticInstanceMember definitions to not allow editing due to Havoc assets not being present
- Added WidgetEditor view for Catalyst version of the Level Editor, (TODO) however UI textures are not displayed there yet
- Fixed SpatialPrefabReference and ObjectReference assets to be saved when drag-and-dropped in Schematic View
- Removed AdditionalDefinitions used by Widget Editor to fix the ACTUAL LEVEL EDITOR not working and NOONE TOLD ME
- Removed desktop.ini files that somehow appeared in CatalystGameSpecific folder lol


## Guide

1. Download the [Frosty Editor 1.0.7 Backported](https://github.com/HarGabt/FrostyToolsuite/releases/tag/v1.0.7_24.11.30), a fork by HerGabt
2. Add the Level Editor plugin to the Plugins folder of the Editor
3. Put [strings.txt](https://drive.google.com/file/d/1jMtY9P0GvUghGK1Y3vwg1RL91s6vwk7x/view) by [zhpete](https://github.com/zhpete) in the main Editor folder
4. Refer to [this guide](https://docs.google.com/document/d/1fVFt37MRPsl22kQrO5cX-N59mt-FcVoFCfNp0FcSLmE) for a slight introduction

5. When you want to publish your mod, it needs to be ported to 1.0.6.3 Frosty Mod Manager (for compatibility with other mods... *and avoiding an "it crashes" comment section*)
<br>   4.1 This has to be done by hand by exporting all modified assets, bundles and chunks in .BIN format, and importing them into 1.0.6.3 Frosty Editor
<br>   4.2 If you have edited any bundles, you can run a [Bundle Manager Plugin](https://drive.google.com/file/d/1LR_TmKJXiIksQWwmtN4eydUB5Gs_Z1qC) I have ported to MEC
<br>       (To install the plugin, copy the content of the .zip file into Plugins directory of **Frosty Editor 1.0.6.3**)

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


## Setup

1. Download the repository whichever way you want
2. Create following folder structure in the Level Editor folder ``[level_editor_location]\FrostyEditor\bin\Developer``
3. Download a release of [HerGabt's 1.0.7 backport project](https://github.com/HarGabt/FrostyToolsuite/tree/1.0.7_test_locale_from_wavebend), rename the Frosty Editor folder to ``Debug``
4. Copy ``Debug`` into ``[level_editor_location]\FrostyEditor\bin\Developer``
5. Open the solution (.sln) with Visual Studio 2022, and make sure the project is set to ``MEC - Debug   x64``


## License
The Content, Name, Code, and all assets are licensed under a Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International License.
