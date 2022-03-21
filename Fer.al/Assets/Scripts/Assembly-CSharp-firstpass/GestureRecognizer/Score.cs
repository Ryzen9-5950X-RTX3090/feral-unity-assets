namespace GestureRecognizer
{
	public struct Score
	{
		public float positionDistance;

		public float curvatureDistance;

		public float angleDistance;

		public float score
		{
			get
			{
				return default(float);
			}
		}

		public static Score MaxDistance
		{
			get
			{
				return default(Score);
			}
		}

		public void InitMax()
		{
		}

		public static bool operator >(Score s1, Score s2)
		{
			return default(bool);
		}

		public static bool operator <(Score s1, Score s2)
		{
			return default(bool);
		}

		public static bool operator >=(Score s1, Score s2)
		{
			return default(bool);
		}

		public static bool operator <=(Score s1, Score s2)
		{
			return default(bool);
		}
	}
}
