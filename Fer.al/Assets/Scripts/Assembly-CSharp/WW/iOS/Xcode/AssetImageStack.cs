using System.Collections.Generic;

namespace WW.iOS.Xcode
{
	internal class AssetImageStack : AssetCatalogItem
	{
		private List<AssetImageStackLayer> m_Layers;

		internal AssetImageStack(string assetCatalogPath, string name, string authorId)
		{
		}

		public AssetImageStackLayer AddLayer(string name)
		{
			return null;
		}

		public override void Write(List<string> warnings)
		{
		}
	}
}
