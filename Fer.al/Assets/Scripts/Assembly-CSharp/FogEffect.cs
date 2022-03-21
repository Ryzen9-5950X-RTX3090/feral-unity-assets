using UnityEngine;

[ExecuteInEditMode]
public class FogEffect : MonoBehaviour
{
	[SerializeField]
	private Material _mat;

	[SerializeField]
	private Color _fogColor;

	[SerializeField]
	private float _depthStart;

	[SerializeField]
	private float _depthDistance;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
