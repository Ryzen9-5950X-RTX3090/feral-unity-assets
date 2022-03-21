using System;

namespace ThirdParty.iOS4Unity
{
	[Serializable]
	public struct CGSize
	{
		public static readonly CGSize Empty;

		public float Width;

		public float Height;

		public bool IsEmpty
		{
			get
			{
				return default(bool);
			}
		}

		public CGSize(CGPoint pt)
		{
		}

		public CGSize(CGSize size)
		{
		}

		public CGSize(float width, float height)
		{
		}

		public static CGSize Add(CGSize sz1, CGSize sz2)
		{
			return default(CGSize);
		}

		public static CGSize Subtract(CGSize sz1, CGSize sz2)
		{
			return default(CGSize);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public CGPoint ToCGPoint()
		{
			return default(CGPoint);
		}

		public override string ToString()
		{
			return null;
		}

		public static CGSize operator +(CGSize sz1, CGSize sz2)
		{
			return default(CGSize);
		}

		public static bool operator ==(CGSize sz1, CGSize sz2)
		{
			return default(bool);
		}

		public static explicit operator CGPoint(CGSize size)
		{
			return default(CGPoint);
		}

		public static bool operator !=(CGSize sz1, CGSize sz2)
		{
			return default(bool);
		}

		public static CGSize operator -(CGSize sz1, CGSize sz2)
		{
			return default(CGSize);
		}
	}
}
