using System.Collections.Generic;
using UnityEngine;

public class UI_Window_SanctuaryGreenhouse : UI_Window
{
	[SerializeField]
	private UI_SanctuaryGreenhousePlot _plotUIPrefab;

	[SerializeField]
	private Transform _plotUIParent;

	[SerializeField]
	private RectTransform _body;

	[SerializeField]
	private CanvasGroup _seedSelectionGroup;

	[SerializeField]
	private RectTransform _seedListRect;

	[SerializeField]
	private UI_LazyItemList_SeedSelection _seedItemList;

	private List<SanctuaryGreenHousePlot> _plots;

	private UI_SanctuaryGreenhousePlot _selectedPlot;

	private List<string> _pendingPlantedSeeds;

	public UI_SanctuaryGreenhousePlot SelectedPlot
	{
		get
		{
			return null;
		}
	}

	public static void OpenWindow(List<SanctuaryGreenHousePlot> inPlots)
	{
	}

	public static void QueueWindow(List<SanctuaryGreenHousePlot> inPlots)
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup(List<SanctuaryGreenHousePlot> inPlots)
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public override void MOnDestroy()
	{
	}

	public void BtnClicked_DeselectPlot()
	{
	}

	public void TogglePlotSelection(UI_SanctuaryGreenhousePlot inPlotToSelect)
	{
	}

	private void ShowSeedList(bool inInstant)
	{
	}

	private void HideSeedList(bool inInstant)
	{
	}

	private void OnPlant(SanctuaryGreenhouseTempServer_Plant inMessage)
	{
	}
}
