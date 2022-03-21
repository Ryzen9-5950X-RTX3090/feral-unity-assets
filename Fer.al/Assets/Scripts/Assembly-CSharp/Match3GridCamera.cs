using UnityEngine;

[RequireComponent(typeof(Camera))]
public class Match3GridCamera : MonoBehaviour
{
	public float minPadding;

	public float horizontalPadding;

	public Vector3 cameraOffset;

	private Camera _camera;

	private Match3Grid _grid;

	public Camera Camera
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void SetTargetGrid(Match3Grid inGrid)
	{
	}
}
