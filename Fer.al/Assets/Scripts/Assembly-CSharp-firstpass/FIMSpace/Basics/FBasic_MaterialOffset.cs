using UnityEngine;

namespace FIMSpace.Basics
{
	public class FBasic_MaterialOffset : FBasic_MaterialScriptBase
	{
		[Tooltip("Texture identificator in shader")]
		public string TextureProperty;

		[Tooltip("Offset speed for property texture, moving with deltaTime")]
		public Vector2 OffsetSpeed;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
