using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using TMPro;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

public class UI_GainXPFX : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <PlayXPEffects>d__23 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_GainXPFX <>4__this;

		public XPUpdateMessage inMessage;

		private UniTask.Awaiter <>u__1;

		private TaskAwaiter <>u__2;

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
	private struct <SpawnEffectsFromAvatar>d__24 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public UI_GainXPFX <>4__this;

		public int inXPGained;

		private int <effectCount>5__2;

		private int <i>5__3;

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
	private struct <PlayIndicatorFX>d__26 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public List<XPUpdateServerMessage.CompletedLevel> inCompletedLevels;

		public IPlayerLevel inCurLevel;

		public UI_GainXPFX <>4__this;

		public IPlayerLevel inPrevLevel;

		private <>c__DisplayClass26_0 <>8__1;

		private UniTask.Awaiter <>u__1;

		private float <duration>5__2;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	[Header("From Avatar FX")]
	private RectTransform _parent;

	[SerializeField]
	private UI_Window _window;

	[SerializeField]
	private RectTransform _fxTarget;

	[SerializeField]
	private RectTransform _fxPrefab;

	[SerializeField]
	private int _maxEffectCount;

	[SerializeField]
	private int _maxExpectedXP;

	[SerializeField]
	private AnimationCurve _effectCountCurve;

	[SerializeField]
	private RectTransform _shakeTarget;

	[SerializeField]
	[Header("XP Indicator FX")]
	private WWTextMeshProUGUI _levelText;

	[SerializeField]
	private WWImage _levelProgressBar;

	[SerializeField]
	private ParticleSystem _xpIndicatorFX;

	[SerializeField]
	private Transform _xpIndicatorRotateTarget;

	[SerializeField]
	[Header("XP Text")]
	private UI_XPGainLabel _xpGainLabel;

	[SerializeField]
	[Header("XP Audio")]
	private FeralAudioInfo _diamondLaunchAudioInfo;

	[SerializeField]
	private FeralAudioInfo _diamondArriveAudioInfo;

	[SerializeField]
	private FeralAudioInfo _xpProgressAudioInfo;

	[SerializeField]
	private FeralAudioInfo _levelUpAudio;

	private Queue<XPUpdateMessage> _xpMessageQueue;

	private bool _xpSequencePlaying;

	private bool _addedXPUpdateMessageMessage;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnXPGained(XPUpdateMessage inMessage)
	{
	}

	[AsyncStateMachine(typeof(<PlayXPEffects>d__23))]
	private void PlayXPEffects(XPUpdateMessage inMessage)
	{
	}

	[AsyncStateMachine(typeof(<SpawnEffectsFromAvatar>d__24))]
	private Task SpawnEffectsFromAvatar(int inXPGained)
	{
		return null;
	}

	private void SpawnEffectFromAvatar()
	{
	}

	[AsyncStateMachine(typeof(<PlayIndicatorFX>d__26))]
	private Task PlayIndicatorFX(IPlayerLevel inPrevLevel, IPlayerLevel inCurLevel, List<XPUpdateServerMessage.CompletedLevel> inCompletedLevels)
	{
		return null;
	}

	private void ShowRewards(List<XPUpdateServerMessage.CompletedLevel> inCompletedLevels)
	{
	}

	private Vector2 GetOriginPosition()
	{
		return default(Vector2);
	}
}
