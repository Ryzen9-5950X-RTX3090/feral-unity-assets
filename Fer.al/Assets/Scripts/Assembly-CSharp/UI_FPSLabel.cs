using TMPro;
using UnityEngine;

public class UI_FPSLabel : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI _fpsText;

	private float _fpsUpdateInterval;

	private float _fps;

	private float _lastFPS;

	private float _fpsAccumulator;

	private int _fpsFrames;

	private float _fpsTimeleft;

	private float _fpsMin;

	private float _fpsMax;

	private void Update()
	{
	}

	private void UpdateFPS()
	{
	}
}
