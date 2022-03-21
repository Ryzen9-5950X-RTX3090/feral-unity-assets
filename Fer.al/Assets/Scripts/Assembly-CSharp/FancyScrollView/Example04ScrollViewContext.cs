using System;

namespace FancyScrollView
{
	public class Example04ScrollViewContext
	{
		private int selectedIndex;

		public Action<Example04ScrollViewCell> OnPressedCell;

		public Action<int> OnSelectedIndexChanged;

		public int SelectedIndex
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
	}
}
