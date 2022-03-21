namespace WW.iOS.Xcode
{
	internal class ImageResizing
	{
		public enum SlicingType
		{
			Horizontal,
			Vertical,
			HorizontalAndVertical
		}

		public enum ResizeMode
		{
			Stretch,
			Tile
		}

		public SlicingType type;

		public int left;

		public int right;

		public int top;

		public int bottom;

		public ResizeMode centerResizeMode;

		public int centerWidth;

		public int centerHeight;
	}
}
