using UnityEngine;

namespace StrayTech
{
	[RequireComponent(typeof(Camera))]
	public class CrossfadePostProcess : MonoBehaviour
	{
		private Material _material;

		private void Start()
		{
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
