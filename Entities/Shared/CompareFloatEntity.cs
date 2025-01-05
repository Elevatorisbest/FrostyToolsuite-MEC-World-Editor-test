using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CompareFloatEntityData))]
	public class CompareFloatEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CompareFloatEntityData>
	{
		public new FrostySdk.Ebx.CompareFloatEntityData Data => data as FrostySdk.Ebx.CompareFloatEntityData;
		public override string DisplayName => "CompareFloat";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CompareFloatEntity(FrostySdk.Ebx.CompareFloatEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

