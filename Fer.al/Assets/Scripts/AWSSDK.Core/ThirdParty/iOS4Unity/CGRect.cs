using System;

namespace ThirdParty.iOS4Unity
{
	[Serializable]
	public struct CGRect
	{
		public static readonly CGRect Empty;

		public float X;

		public float Height;

		public float Width;

		public float Y;

		public float Bottom
		{
			get
			{
				return default(float);
			}
		}

		public bool IsEmpty
		{
			get
			{
				return default(bool);
			}
		}

		public CGPoint Location
		{
			get
			{
				return default(CGPoint);
			}
			set
			{
			}
		}

		public float Right
		{
			get
			{
				return default(float);
			}
		}

		public CGSize Size
		{
			get
			{
				return default(CGSize);
			}
			set
			{
			}
		}

		public CGRect(CGPoint location, CGSize size)
		{
		}

		public CGRect(float x, float y, float width, float height)
		{
		}

		public static CGRect FromLTRB(float left, float top, float right, float bottom)
		{
			return default(CGRect);
		}

		public static CGRect Inflate(CGRect rect, float x, float y)
		{
			return default(CGRect);
		}

		public static CGRect Intersect(CGRect a, CGRect b)
		{
			return default(CGRect);
		}

		public static CGRect Union(CGRect a, CGRect b)
		{
			return default(CGRect);
		}

		public bool Contains(float x, float y)
		{
			return default(bool);
		}

		public bool Contains(CGRect rect)
		{
			return default(bool);
		}

		public bool Contains(CGPoint pt)
		{
			return default(bool);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public void Inflate(CGSize size)
		{
		}

		public void Inflate(float x, float y)
		{
		}

		public void Intersect(CGRect rect)
		{
		}

		public bool IntersectsWith(CGRect rect)
		{
			return default(bool);
		}

		private bool IntersectsWithInclusive(CGRect r)
		{
			return default(bool);
		}

		public void Offset(float x, float y)
		{
		}

		public void Offset(CGPoint pos)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static bool operator ==(CGRect left, CGRect right)
		{
			return default(bool);
		}

		public static bool operator !=(CGRect left, CGRect right)
		{
			return default(bool);
		}
	}
}
