using UnityEngine;

public class UVLerp : MonoBehaviour
{
	public int materialIndex;

	public Vector2 uvAnimationRateMin;

	public Vector2 uvAnimationRateMax;

	public string textureName;

	private Vector2 uvOffset;

	private float _timer;

	public float time;

	private Material[] _materials;

	private bool _lerpOut;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
