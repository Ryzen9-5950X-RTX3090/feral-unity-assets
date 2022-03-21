using System.Collections.Generic;

namespace WW.iOS.Xcode
{
	internal class AssetCatalog
	{
		private AssetFolder m_Root;

		public string path
		{
			get
			{
				return null;
			}
		}

		public AssetFolder root
		{
			get
			{
				return null;
			}
		}

		public AssetCatalog(string path, string authorId)
		{
		}

		private AssetFolder OpenFolderForResource(string relativePath)
		{
			return null;
		}

		public AssetDataSet OpenDataSet(string relativePath)
		{
			return null;
		}

		public AssetImageSet OpenImageSet(string relativePath)
		{
			return null;
		}

		public AssetImageStack OpenImageStack(string relativePath)
		{
			return null;
		}

		public AssetBrandAssetGroup OpenBrandAssetGroup(string relativePath)
		{
			return null;
		}

		public AssetFolder OpenFolder(string relativePath)
		{
			return null;
		}

		public AssetFolder OpenNamespacedFolder(string relativeBasePath, string namespacePath)
		{
			return null;
		}

		public void Write()
		{
		}

		public void Write(List<string> warnings)
		{
		}
	}
}
