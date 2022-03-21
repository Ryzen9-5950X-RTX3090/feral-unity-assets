using UnityEngine;

public class NoiseFlowField : MonoBehaviour
{
	private FastNoise _fastNoise;

	[SerializeField]
	private Vector3Int _gridSize;

	[SerializeField]
	private float _increment;

	[SerializeField]
	private Vector3 _offset;

	[SerializeField]
	private Vector3 _offsetSpeed;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
