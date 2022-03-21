using GestureRecognizer;
using UnityEngine;
using UnityEngine.UI;

public class GestureOptions : MonoBehaviour
{
	public Dropdown dropdownMin;

	public Dropdown dropdownMax;

	public Dropdown dropdownThreads;

	public Dropdown dropdownMode;

	public Text textTime;

	public DrawDetector[] detectors;

	public Recognizer recognizer;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void RecognitionResult(RecognitionResult result)
	{
	}

	public void OnChangeMinMax()
	{
	}

	public void OnChangeMode()
	{
	}

	public void OnChangeThreads()
	{
	}
}
