using UnityEngine;

namespace StrayTech
{
	[ExecuteInEditMode]
	public class Grayscale : MonoBehaviour
	{
		[SerializeField]
		private Shader _shader;

		private Material _material;

		private void Start()
		{
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		private void OnDisable()
		{
		}
	}
}
