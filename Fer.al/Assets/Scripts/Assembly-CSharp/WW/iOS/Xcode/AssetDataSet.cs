using System.Collections.Generic;

namespace WW.iOS.Xcode
{
	internal class AssetDataSet : AssetCatalogItemWithVariants
	{
		private class DataSetVariant : VariantData
		{
			public string id;

			public DataSetVariant(DeviceRequirement requirement, string path, string id)
			{
			}
		}

		internal AssetDataSet(string parentPath, string name, string authorId)
		{
		}

		public void AddVariant(DeviceRequirement requirement, string path, string typeIdentifier)
		{
		}

		public override void Write(List<string> warnings)
		{
		}
	}
}
