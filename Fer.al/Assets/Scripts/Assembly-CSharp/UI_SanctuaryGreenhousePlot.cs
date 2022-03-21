using UnityEngine;
using UnityEngine.UI;

public class UI_SanctuaryGreenhousePlot : ManagedBehaviour
{
	[SerializeField]
	private FeralButton _selectBtn;

	[SerializeField]
	private CanvasGroup _selectedGroup;

	[SerializeField]
	private CanvasGroup _emptyGroup;

	private SanctuaryGreenHousePlot _plot;

	private UI_Window_SanctuaryGreenhouse _window;

	private bool _isSelected;

	public SanctuaryGreenHousePlot Plot
	{
		get
		{
			return null;
		}
	}

	private Camera PlotCamera
	{
		get
		{
			return null;
		}
	}

	private Camera UICamera
	{
		get
		{
			return null;
		}
	}

	public void Setup(UI_Window_SanctuaryGreenhouse inWindow, SanctuaryGreenHousePlot inPlot)
	{
	}

	public override void MOnDestroy()
	{
	}

	public override void MUpdate()
	{
	}

	public void BtnClicked_SelectPlot()
	{
	}

	public void SetSelected(bool inIsSelected)
	{
	}

	private void Refresh(bool inFromSetup = false)
	{
	}

	private void OnPlotPlanted()
	{
	}

	private void OnPlotMatured()
	{
	}

	private void OnPlotCleared()
	{
	}

	private void OnPlotHarvested()
	{
	}
}
