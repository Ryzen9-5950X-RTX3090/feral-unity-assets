using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UI_SanctuaryToolbar : MonoBehaviour
{
	private enum UpgradeState
	{
		None,
		UpgradeAvailable,
		UpgradeInProgress,
		UpgradeInProgressDifferentSanctuary,
		UpgradeFinished,
		UpgradeFinishedDifferentSanctuary
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <PlayUpgradeTimerCompleteSfxAsync>d__15 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder <>t__builder;

		public UI_SanctuaryToolbar <>4__this;

		private UniTask.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public FeralButton decorateButton;

	public FeralButton upgradeButton;

	public FeralButton switchButton;

	public GameObject upgradeTimerContainer;

	public WWTextMeshProUGUI upgradeTimerText;

	public FeralAudioInfo upgradeTimerCompleteSfx;

	private UpgradeState _upgradeState;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void SetUpgradeState(UpgradeState inState)
	{
	}

	private void UpdateUpgradeState()
	{
	}

	private void SetButtonEnabled(FeralButton inButton, bool inEnabled)
	{
	}

	private void SetUpgradeTimerVisible(bool inVisible)
	{
	}

	private void UpdateUpgradeTimer()
	{
	}

	[AsyncStateMachine(typeof(<PlayUpgradeTimerCompleteSfxAsync>d__15))]
	private UniTask PlayUpgradeTimerCompleteSfxAsync()
	{
		return default(UniTask);
	}
}
