using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;
using WW.Debug;

public class UI_Window_Inspirations : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <BtnClicked_Combine>d__21 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_Inspirations <>4__this;

		private bool <success>5__2;

		private UniTask<InspirationCombineResponse>.Awaiter <>u__1;

		private TaskAwaiter <>u__2;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private UI_InspirationThoughtBubble _thoughtBubble;

	[SerializeField]
	private FeralButton _combineButton;

	[SerializeField]
	private FeralAudioInfo _successAudioInfo;

	[SerializeField]
	private FeralAudioInfo _failureAudioInfo;

	[SerializeField]
	private FeralAudioInfo[] _addInspirationSounds;

	[SerializeField]
	private FeralAudioInfo _removeInspirationSound;

	public Action<InspirationItemComponent> OnInspirationAdded;

	public Action<InspirationItemComponent> OnInspirationRemoved;

	private List<InspirationItemComponent> _inspirations;

	private List<EnigmaDefComponent> _enigmasInInventory;

	private EnigmaDefComponent _currentEnigmaResult;

	[DebugButton("Open", "UI/Windows/Inspirations", true, false)]
	public static void OpenWindow()
	{
	}

	public static void QueueWindow()
	{
	}

	[DebugButton("Close", "UI/Windows/Inspirations", false, false)]
	public static void CloseWindow()
	{
	}

	private void Setup()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	private void OnBack()
	{
	}

	public override void MOnDestroy()
	{
	}

	public bool InspirationIsAdded(InspirationItemComponent inInspiration)
	{
		return default(bool);
	}

	public void AddInspiration(InspirationItemComponent inInspiration)
	{
	}

	[AsyncStateMachine(typeof(<BtnClicked_Combine>d__21))]
	public void BtnClicked_Combine()
	{
	}

	public void RemoveInspiration(InspirationItemComponent inInspiration, bool inPlaySound)
	{
	}

	private void SetupEnigmaList()
	{
	}

	private EnigmaDefComponent GetCombinationResultFromInventory()
	{
		return null;
	}

	private void RefreshCombinationResult()
	{
	}
}
