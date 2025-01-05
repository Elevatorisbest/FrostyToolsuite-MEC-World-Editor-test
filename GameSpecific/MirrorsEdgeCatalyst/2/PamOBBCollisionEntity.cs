using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamOBBCollisionEntityData))]
	public class PamOBBCollisionEntity : OBBCollisionEntity, IEntityData<FrostySdk.Ebx.PamOBBCollisionEntityData>
	{
		public new FrostySdk.Ebx.PamOBBCollisionEntityData Data => data as FrostySdk.Ebx.PamOBBCollisionEntityData;

		public PamOBBCollisionEntity(FrostySdk.Ebx.PamOBBCollisionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

