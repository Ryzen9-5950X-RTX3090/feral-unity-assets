using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_Shop_SanctuaryExpansions : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <DoDelayedOpenAnimation>d__14 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_Shop_SanctuaryExpansions <>4__this;

		private UniTask.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private UI_SanctuaryExpansionRoomControlPanel _controlPanel;

	[SerializeField]
	private UI_TabGroup _floorTabGroup;

	[SerializeField]
	private WWTextMeshProUGUI _headerText;

	[SerializeField]
	private FeralButton _applyBtn;

	public List<GameObject> floorContainers;

	private UI_Stage_SanctuaryExpansionShopStage _stage;

	private int _currentRoomIndex;

	private int _currentFloorIndex;

	private List<UI_SanctuaryExpansionRoomButton> _activeRoomButtons;

	public static void OpenWindow()
	{
	}

	public static void QueueWindow()
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup()
	{
	}

	protected override void OnOpen()
	{
	}

	[AsyncStateMachine(typeof(<DoDelayedOpenAnimation>d__14))]
	protected override void DoDelayedOpenAnimation()
	{
	}

	private void OnStageLoaded(UISanctuaryExpansionsShopLoadedStage inMessage)
	{
	}

	private void OnStateChanged(SanctuaryBuildStateChangedMessage inMessage)
	{
	}

	private void Refresh()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public override void MOnDestroy()
	{
	}

	public void SetRoomSelection(int inRoomIndex)
	{
	}

	public void ShowFloor(int inFloorIndex)
	{
	}

	public void SetButtonActive(UI_SanctuaryExpansionRoomButton inButton, bool inActive)
	{
	}

	public void BtnClicked_Close()
	{
	}

	public void BtnClicked_Apply()
	{
	}
}
