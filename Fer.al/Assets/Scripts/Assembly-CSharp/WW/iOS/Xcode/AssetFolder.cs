using System.Collections.Generic;

namespace WW.iOS.Xcode
{
	internal class AssetFolder : AssetCatalogItem
	{
		private List<AssetCatalogItem> m_Items;

		private bool m_ProvidesNamespace;

		public bool providesNamespace
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		internal AssetFolder(string parentPath, string name, string authorId)
		{
		}

		public AssetFolder OpenFolder(string name)
		{
			return null;
		}

		private T GetExistingItemWithType<T>(string name) where T : class
		{
			return null;
		}

		public AssetDataSet OpenDataSet(string name)
		{
			return null;
		}

		public AssetImageSet OpenImageSet(string name)
		{
			return null;
		}

		public AssetImageStack OpenImageStack(string name)
		{
			return null;
		}

		public AssetBrandAssetGroup OpenBrandAssetGroup(string name)
		{
			return null;
		}

		public AssetCatalogItem GetChild(string name)
		{
			return null;
		}

		private void WriteJson()
		{
		}

		public override void Write(List<string> warnings)
		{
		}
	}
}
