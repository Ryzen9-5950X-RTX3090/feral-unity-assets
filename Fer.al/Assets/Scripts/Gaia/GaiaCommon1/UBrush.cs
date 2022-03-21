using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GaiaCommon1
{
	[Serializable]
	public class UBrush
	{
		private float[] m_Strength;

		private Texture2D m_Brush;

		private const int MIN_BRUSH_SIZE = 3;

		public int Size
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool Load(Texture2D brushTex, int size)
		{
			return default(bool);
		}

		public float GetStrengthAtCoords(int ix, int iy)
		{
			return default(float);
		}
	}
}
