using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CompareBoolEntityData))]
	public class CompareBoolEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CompareBoolEntityData>
	{
		public new FrostySdk.Ebx.CompareBoolEntityData Data => data as FrostySdk.Ebx.CompareBoolEntityData;
		public override string DisplayName => "CompareBool";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CompareBoolEntity(FrostySdk.Ebx.CompareBoolEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

