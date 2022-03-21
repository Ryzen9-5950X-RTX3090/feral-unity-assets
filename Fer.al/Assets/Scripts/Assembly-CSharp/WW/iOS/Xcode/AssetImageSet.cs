using System.Collections.Generic;

namespace WW.iOS.Xcode
{
	internal class AssetImageSet : AssetCatalogItemWithVariants
	{
		private class ImageSetVariant : VariantData
		{
			public ImageAlignment alignment;

			public ImageResizing resizing;

			public ImageSetVariant(DeviceRequirement requirement, string path)
			{
			}
		}

		internal AssetImageSet(string assetCatalogPath, string name, string authorId)
		{
		}

		public void AddVariant(DeviceRequirement requirement, string path)
		{
		}

		public void AddVariant(DeviceRequirement requirement, string path, ImageAlignment alignment, ImageResizing resizing)
		{
		}

		private void WriteAlignmentToJson(JsonElementDict item, ImageAlignment alignment)
		{
		}

		private static string GetSlicingMode(ImageResizing.SlicingType mode)
		{
			return null;
		}

		private static string GetCenterResizeMode(ImageResizing.ResizeMode mode)
		{
			return null;
		}

		private void WriteResizingToJson(JsonElementDict item, ImageResizing resizing)
		{
		}

		public override void Write(List<string> warnings)
		{
		}
	}
}
