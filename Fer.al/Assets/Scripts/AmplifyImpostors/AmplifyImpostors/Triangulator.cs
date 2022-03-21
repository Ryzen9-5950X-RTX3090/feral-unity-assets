using System.Collections.Generic;
using UnityEngine;

namespace AmplifyImpostors
{
	public class Triangulator
	{
		private List<Vector2> m_points;

		public List<Vector2> Points
		{
			get
			{
				return null;
			}
		}

		public Triangulator(Vector2[] points)
		{
		}

		public Triangulator(Vector2[] points, bool invertY = true)
		{
		}

		public int[] Triangulate()
		{
			return null;
		}

		private float Area()
		{
			return default(float);
		}

		private bool Snip(int u, int v, int w, int n, int[] V)
		{
			return default(bool);
		}

		private bool InsideTriangle(Vector2 pt, Vector2 v1, Vector2 v2, Vector2 v3)
		{
			return default(bool);
		}
	}
}
