using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_SpriteFillFX : MonoBehaviour
{
	[SerializeField]
	private int _frameOverlap;

	[SerializeField]
	private int _framesToClip;

	[SerializeField]
	private List<WWImage> _images;

	[SerializeField]
	private Sprite[] _frames;

	[SerializeField]
	[Range(0f, 1f)]
	private float _testValue;

	public void OnProgressUpdated(float inNormalizedValue)
	{
	}

	private void OnValidate()
	{
	}
}
