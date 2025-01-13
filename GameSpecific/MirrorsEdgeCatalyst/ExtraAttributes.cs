using LevelEditorPlugin.Definitions;
using LevelEditorPlugin.Extensions;
using Frosty.Core.Attributes;
using FrostySdk;

// Extra attributes are placed here that are specific to this game

[assembly: PluginValidForProfile((int)ProfileVersion.MirrorsEdgeCatalyst)]

// logic blueprints

// object blueprints
[assembly: RegisterAssetDefinition("UIWidgetBlueprint", typeof(UIWidgetBlueprintAssetDefinition))]
[assembly: RegisterAssetDefinition("PamCharacterBlueprint", typeof(PamCharacterBlueprintAssetDefinition))]
[assembly: RegisterAssetDefinition("AppearanceEntityBlueprint", typeof(AppearanceEntityBlueprintAssetDefinition))]
[assembly: RegisterAssetDefinition("GameObjectBlueprint", typeof(GameObjectBlueprintAssetDefinition))]
[assembly: RegisterAssetDefinition("CharacterBlueprint", typeof(CharacterBlueprintAssetDefinition))]
[assembly: RegisterAssetDefinition("EffectBlueprint", typeof(EffectBlueprintAssetDefinition))]
[assembly: RegisterAssetDefinition("VehicleBlueprint", typeof(VehicleBlueprintAssetDefinition))]
[assembly: RegisterAssetDefinition("VisualEnvironmentBlueprint", typeof(VisualEnvironmentBlueprintAssetDefinition))]

// other
//[assembly: RegisterAssetDefinition("SubWorldData", typeof(SubWorldDataAssetDefinition))]