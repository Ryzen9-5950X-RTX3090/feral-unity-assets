using System;

namespace ThirdParty.iOS4Unity
{
	[Serializable]
	public struct CGPoint
	{
		public static readonly CGPoint Empty;

		public float X;

		public float Y;

		public bool IsEmpty
		{
			get
			{
				return default(bool);
			}
		}

		public CGPoint(float x, float y)
		{
		}

		public static CGPoint Add(CGPoint pt, CGSize sz)
		{
			return default(CGPoint);
		}

		public static CGPoint Subtract(CGPoint pt, CGSize sz)
		{
			return default(CGPoint);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}

		public static CGPoint operator +(CGPoint pt, CGSize sz)
		{
			return default(CGPoint);
		}

		public static bool operator ==(CGPoint left, CGPoint right)
		{
			return default(bool);
		}

		public static bool operator !=(CGPoint left, CGPoint right)
		{
			return default(bool);
		}

		public static CGPoint operator -(CGPoint pt, CGSize sz)
		{
			return default(CGPoint);
		}
	}
}
