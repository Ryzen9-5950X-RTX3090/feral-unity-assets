using System.Collections.Generic;

namespace WW.iOS.Xcode
{
	internal class AssetBrandAssetGroup : AssetCatalogItem
	{
		private class AssetBrandAssetItem
		{
			internal string idiom;

			internal string role;

			internal int width;

			internal int height;

			internal AssetCatalogItem item;
		}

		private List<AssetBrandAssetItem> m_Items;

		internal AssetBrandAssetGroup(string assetCatalogPath, string name, string authorId)
		{
		}

		private void AddItem(AssetCatalogItem item, string idiom, string role, int width, int height)
		{
		}

		public AssetImageSet OpenImageSet(string name, string idiom, string role, int width, int height)
		{
			return null;
		}

		public AssetImageStack OpenImageStack(string name, string idiom, string role, int width, int height)
		{
			return null;
		}

		public override void Write(List<string> warnings)
		{
		}
	}
}
