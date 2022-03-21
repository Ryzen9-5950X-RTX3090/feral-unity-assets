using System.Runtime.InteropServices;
using UnityEngine;

public class FakeSanctuaryLights : MonoBehaviour
{
	private static FakeSanctuaryLights _instance;

	private Color? _initialColor;

	private Color _currentcolor;

	private bool? _isInterior;

	public static FakeSanctuaryLights instance
	{
		get
		{
			return null;
		}
	}

	public void Initialize()
	{
	}

	private void Update()
	{
	}

	public void ChangeLightsInRoom([Optional] Color? inColor)
	{
	}

	private void OnDestroy()
	{
	}

	private void SetInitialColor()
	{
	}

	private void ResetVars()
	{
	}
}
