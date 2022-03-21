using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UI_TarDownloader : MonoBehaviour
{
	private Canvas _canvas;

	public GameObject groupOnOff;

	[Header("Progress Bar")]
	public GameObject groupProgressBar;

	public Slider progressBar;

	public Text labelPercentage;

	public Text labelProgressText;

	public Text labelEstimatedTime;

	public Text labelCurrentTarName;

	private float _progressTime;

	private float _progressTimer;

	public static UI_TarDownloader instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Canvas canvas
	{
		get
		{
			return null;
		}
	}

	private void Start()
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	private void Update()
	{
	}

	public void SetProgressLabel(string inString)
	{
	}

	public void SetProgressSlider(float inValue)
	{
	}

	public void SetEstimatedTimeLabel(string inString)
	{
	}

	public void SetCurrentTarNameLabel(string inString)
	{
	}

	private void OnDestroy()
	{
	}
}
