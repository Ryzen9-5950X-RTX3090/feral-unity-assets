using System;
using UnityEngine;

namespace DG.DemiLib
{
	[Serializable]
	public struct DeSkinColor
	{
		public Color free;

		public Color pro;

		public DeSkinColor(Color free, Color pro)
		{
		}

		public DeSkinColor(float freeGradation, float proGradation)
		{
		}

		public DeSkinColor(Color color)
		{
		}

		public static implicit operator DeSkinColor(Color v)
		{
			return default(DeSkinColor);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
