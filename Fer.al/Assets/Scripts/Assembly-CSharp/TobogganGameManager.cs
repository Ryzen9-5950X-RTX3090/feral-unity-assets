using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async;
using UnityEngine;

public class TobogganGameManager : CasualGame<TobogganGameManager>
{
	[Serializable]
	public class TobogganTrack
	{
		public GameObject track;

		public TobogganController toboggan;

		public GameObject[] snowboldGroups;

		public Transform resetLocators;
	}

	public enum GameState
	{
		AwaitingSetup,
		Starting,
		Running,
		Finished,
		Reseting
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Setup>d__18 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public TobogganGameManager <>4__this;

		public Action<bool> inGameOverAction;

		private UniTask.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <OnFinishZoneEntered>d__21 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public TobogganGameManager <>4__this;

		private UniTask.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Header("UserVars")]
	public CachedUserVar tutorialSeenUserVar;

	public bool forceTutorial;

	[Header("UI")]
	public TobogganUI_HUD hud;

	public ToboggonUI_GameOver gameover;

	public TobogganUI_Countdown countdown;

	public TobogganUI_Tutorial tutorial;

	public GameState gameState;

	private bool _victory;

	public int requiredKobolds;

	internal int koboldsDestroyed;

	public FeralAudioInfo snowboldHit;

	public FeralAudioInfo snowboldHitSpecial;

	public TobogganTrack[] tobogganTracks;

	public Action<bool> GameOverAction;

	internal TobogganTrack tobogganTrack;

	private void Start()
	{
	}

	[AsyncStateMachine(typeof(<Setup>d__18))]
	public void Setup(Action<bool> inGameOverAction)
	{
	}

	protected override void OnDestroy()
	{
	}

	public void OnKoboldDestroyed()
	{
	}

	[AsyncStateMachine(typeof(<OnFinishZoneEntered>d__21))]
	public void OnFinishZoneEntered()
	{
	}
}
