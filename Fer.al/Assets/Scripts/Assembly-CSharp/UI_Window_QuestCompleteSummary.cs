using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_QuestCompleteSummary : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <SetupRewardState>d__20 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public string inRewardDefId;

		public UI_Window_QuestCompleteSummary <>4__this;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private WWImage _questIconImage;

	[SerializeField]
	private WWTextMeshProUGUI _questTitleText;

	[SerializeField]
	private WWTextMeshProUGUI _questLocationText;

	[SerializeField]
	private UI_QuestSummary _questSummary;

	[SerializeField]
	private List<FeralButton> _buttons;

	[SerializeField]
	private GameObject _chestClosedDisabledGroup;

	[SerializeField]
	private WWImage _chestClosedImage;

	[SerializeField]
	private GameObject _chestOpenGroup;

	[SerializeField]
	private GameObject _chestClosedActiveGroup;

	private Action<bool> _resultCallback;

	private Quest _quest;

	public static void OpenWindow([Optional] Action<bool> inResultCallback)
	{
	}

	public static void QueueWindow([Optional] Action<bool> inResultCallback)
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup([Optional] Action<bool> inResultCallback)
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

	public void BtnClicked_Leave()
	{
	}

	public void BtnClicked_Cancel()
	{
	}

	[AsyncStateMachine(typeof(<SetupRewardState>d__20))]
	private void SetupRewardState(bool inFullCompletion, string inRewardDefId)
	{
	}
}
