using System.Collections.Generic;
using UnityEngine;

public class CodeBreakerTutorialStep : MonoBehaviour
{
	public GameObject dimmer;

	public Vector3 dimmerOffset;

	[Space]
	public bool allowInteraction;

	[Space]
	public List<GameObject> layerHighlightObjects;

	[Space]
	public List<GameObject> toggleObjects;

	[Space]
	public Camera tutorialCamera;

	public List<string> additionalCameraLayers;

	[Header("Dialog")]
	public CodeBreakerDialogPopup tutorialDialog;

	[RootSelectorCompact("Tutorial Dialog Text", "LocalizationChartData", null, false, false)]
	public string tutorialDialogTextId;

	public int dialogEmoteIndex;

	private Vector3 _originalLocalPos;

	private List<int> _originalLayers;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
