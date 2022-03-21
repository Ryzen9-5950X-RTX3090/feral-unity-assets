namespace TMPro
{
	public static class TMP_Compatibility
	{
		public enum AnchorPositions
		{
			TopLeft,
			Top,
			TopRight,
			Left,
			Center,
			Right,
			BottomLeft,
			Bottom,
			BottomRight,
			BaseLine,
			None
		}

		public static TextAlignmentOptions ConvertTextAlignmentEnumValues(TextAlignmentOptions oldValue)
		{
			return default(TextAlignmentOptions);
		}
	}
}
