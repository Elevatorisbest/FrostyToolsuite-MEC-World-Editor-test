using Frosty.Core;
using FrostySdk;
using FrostySdk.Ebx;
using FrostySdk.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;

namespace LevelEditorPlugin.Assets
{
    [AssetBinding(DataType = typeof(FrostySdk.Ebx.UITextureMappingAsset))]
    public class UITextureMappingAsset : Asset, IAssetData<FrostySdk.Ebx.UITextureMappingAsset>
    {
        public FrostySdk.Ebx.UITextureMappingAsset Data => data as FrostySdk.Ebx.UITextureMappingAsset;

        protected Dictionary<PointerRef, BitmapImage> textureAssets = new Dictionary<PointerRef, BitmapImage>();
        protected Dictionary<CString, PointerRef> textureIds = new Dictionary<CString, PointerRef>();

        public UITextureMappingAsset(Guid fileGuid, FrostySdk.Ebx.UITextureMappingAsset inData)
            : base(fileGuid, inData)
        {
            //foreach (var output in Data.Output)
            //{
            //    if (!textureAssets.ContainsKey(output.Texture))
            //    {
            //        var texture = App.AssetManager.GetResAs<Texture>(output.Texture.External.FileGuid());
            //        var bitmap = TextureCreator.CreatePNG(texture);

            //        textureAssets.Add(output.Texture, bitmap);
            //    }
            //    textureIds.Add(output.Id, output.Texture);
            //}
        }

        //public BitmapImage GetTexture(CString id)
        //{
        //    if (!textureIds.ContainsKey(id))
        //        return null;

        //    return textureAssets[textureIds[id]];
        //}

        //public Point4D GetUVRect(CString id)
        //{
        //    var result = Data.Output.FirstOrDefault(t => t.Id == id);
        //    return new Point4D(result.Min.x, result.Min.y, result.Max.x, result.Max.y);
        //}
    }
}
