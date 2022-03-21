using UnityEngine;

namespace FIMSpace.Basics
{
	public class FBasic_MaterialTiler : FBasic_MaterialScriptBase
	{
		[Space]
		[Header("When you scale object change")]
		[Header("something in script to apply")]
		[Space(10f)]
		[Tooltip("Texture identificator in shader")]
		public string TextureProperty;

		[Tooltip("How much tiles should be multiplied according to gameObject's scale")]
		public Vector2 ScaleValues;

		[Tooltip("When scale on Y should be same as X")]
		public bool EqualDimensions;

		private void OnValidate()
		{
		}

		private void TileMaterialToScale()
		{
		}
	}
}
