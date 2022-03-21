using System;

namespace Rewired.Utils.Classes.Data
{
	[Serializable]
	public class IntRect
	{
		public int x;

		public int y;

		public int width;

		public int height;

		public int yMin
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int yMax
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int xMin
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int xMax
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int top
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int bottom
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int left
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int right
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public IntRect()
		{
		}

		public IntRect(int inX, int inY, int inWidth, int inHeight)
		{
		}

		public IntRect Clone()
		{
			return null;
		}

		public static IntRect Clone(IntRect intRect)
		{
			return null;
		}
	}
}
