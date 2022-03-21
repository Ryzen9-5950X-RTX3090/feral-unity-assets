using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnboardingHighlightTarget : MonoBehaviour
{
	public static Dictionary<OnboardingHighlightTargetId, OnboardingHighlightTarget> HighlightTargetLookup;

	[SerializeField]
	private OnboardingHighlightTargetId _targetId;

	[SerializeField]
	private GameObject _highlightGroup;

	[SerializeField]
	private WWImage _highlightImage;

	[SerializeField]
	[RootSelector("Highlight Image Def", "ImageChartData", false, false)]
	private string _highlightImageDefId;

	private bool _isCaptured;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void OnCaptured()
	{
	}

	public void OnReleased()
	{
	}

	private void UnloadBundledImage()
	{
	}
}
