using UnityEngine;

namespace FIMSpace.Basics
{
	public class FBasic_MaterialFloatAnimate : FBasic_MaterialScriptBase
	{
		[Tooltip("Texture identificator in shader")]
		public string TextureProperty;

		public float PropertyInitValue;

		public float RangeValue;

		public float AnimateSpeed;

		private float time;

		private float randomValue;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
