using UnityEngine;

[ExecuteInEditMode]
[ImageEffectAllowedInSceneView]
public class UnderwaterEffect : MonoBehaviour
{
	[SerializeField]
	private Material _mat;

	[SerializeField]
	[Range(0.001f, 0.1f)]
	private float _pixelOffset;

	[SerializeField]
	[Range(0.1f, 20f)]
	private float _noiseScale;

	[SerializeField]
	[Range(0.1f, 20f)]
	private float _noiseFrequency;

	[SerializeField]
	[Range(0.1f, 30f)]
	private float _noiseSpeed;

	[SerializeField]
	private float _depthStart;

	[SerializeField]
	private float _depthDistance;

	private void Update()
	{
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
