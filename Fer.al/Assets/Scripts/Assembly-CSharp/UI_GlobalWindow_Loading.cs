using UnityEngine;
using UnityEngine.UI;

public class UI_GlobalWindow_Loading : UI_GlobalWindow<UI_GlobalWindow_Loading>
{
	public GameObject panelProgressBar;

	public Image imageProgressBar;

	public Text labelProgressBarPercentage;

	private float _desiredProgress;

	private float _currentProgress;

	private float MaxDelta
	{
		get
		{
			return default(float);
		}
	}

	public override void MAwake()
	{
	}

	public void SetProgress(float inProgress)
	{
	}

	public override void MUpdate()
	{
	}

	protected override void OnCloseComplete()
	{
	}
}
