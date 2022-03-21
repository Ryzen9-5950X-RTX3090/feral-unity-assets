using UnityEngine;

namespace FIMSpace.Basics
{
	public class FBasic_MaterialRandomColor : FBasic_MaterialScriptBase
	{
		[Tooltip("Texture identificator in shader")]
		public string TextureProperty;

		public Vector2 HueRange;

		public Vector2 SaturationRange;

		public Vector2 ValueRange;

		public Vector2 AlphaRange;

		private void Start()
		{
		}
	}
}
