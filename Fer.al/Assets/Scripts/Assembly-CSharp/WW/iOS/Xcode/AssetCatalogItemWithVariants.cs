using System.Collections.Generic;

namespace WW.iOS.Xcode
{
	internal abstract class AssetCatalogItemWithVariants : AssetCatalogItem
	{
		protected class VariantData
		{
			public DeviceRequirement requirement;

			public string path;

			public VariantData(DeviceRequirement requirement, string path)
			{
			}
		}

		protected List<VariantData> m_Variants;

		protected List<string> m_ODRTags;

		protected AssetCatalogItemWithVariants(string name, string authorId)
		{
		}

		public bool HasVariant(DeviceRequirement requirement)
		{
			return default(bool);
		}

		public void AddOnDemandResourceTag(string tag)
		{
		}

		protected void AddVariant(VariantData newItem)
		{
		}

		protected void WriteODRTagsToJson(JsonElementDict info)
		{
		}

		protected void WriteRequirementsToJson(JsonElementDict item, DeviceRequirement req)
		{
		}
	}
}
