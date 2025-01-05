using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.BoolHubEntityData))]
	public class BoolHubEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BoolHubEntityData>
	{
		public new FrostySdk.Ebx.BoolHubEntityData Data => data as FrostySdk.Ebx.BoolHubEntityData;
		public override string DisplayName => "BoolHub";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public BoolHubEntity(FrostySdk.Ebx.BoolHubEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

