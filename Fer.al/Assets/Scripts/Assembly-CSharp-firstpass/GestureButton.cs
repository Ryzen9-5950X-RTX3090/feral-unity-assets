using System.Collections.Generic;
using GestureRecognizer;
using UnityEngine;

public class GestureButton : MonoBehaviour
{
	public GestureSelector gestureSelector;

	public DrawDetector drawDetector;

	public List<GesturePattern> gesturePatterns;

	private RectTransform rectTransfrom;

	private void Start()
	{
	}

	public void OnGestureSelected()
	{
	}
}
