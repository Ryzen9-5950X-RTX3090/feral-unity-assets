using System.Collections.Generic;
using GestureRecognizer;
using UnityEngine;

public class GestureSelector : MonoBehaviour
{
	public Recognizer recognizer;

	public RectTransform selectedHighlight;

	public void OnGestureSelected(List<GesturePattern> inGestures, RectTransform inButton)
	{
	}
}
