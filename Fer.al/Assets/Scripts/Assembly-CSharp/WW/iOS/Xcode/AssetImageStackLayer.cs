using System.Collections.Generic;

namespace WW.iOS.Xcode
{
	internal class AssetImageStackLayer : AssetCatalogItem
	{
		private AssetImageSet m_Imageset;

		private string m_ReferencedName;

		internal AssetImageStackLayer(string assetCatalogPath, string name, string authorId)
		{
		}

		public void SetReference(string name)
		{
		}

		public string ReferencedName()
		{
			return null;
		}

		public AssetImageSet GetImageSet()
		{
			return null;
		}

		public override void Write(List<string> warnings)
		{
		}
	}
}
