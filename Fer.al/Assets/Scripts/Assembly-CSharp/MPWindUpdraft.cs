using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteAlways]
[RequireComponent(typeof(CountdownTimer))]
public class MPWindUpdraft : WindUpdraft
{
	public enum ENumPlayerRequired
	{
		DEBUG = 1,
		TWO,
		THREE,
		FOUR,
		FIVE
	}

	public MPWindUpdraftAudio mpUpdraftAudio;

	public ENumPlayerRequired numberOfPlayersRequired;

	public DOTweenAnimator highlightPlate;

	public FeralAudioEmitter highlightPlateAudio;

	[Tooltip("The amount of time (in seconds) to delay enabling the updraft and its sounds and effects after the numberOfPlayersRequired requirement has been met.")]
	public float EnableUpdraftDelaySec;

	[Tooltip("The amount of time (in seconds) to wait before highlighting the updraft plate's rune. This delay is here so that we can trigger the crystal/diamond effect followed by this plate's effect followed by actually enabling the glide.")]
	public float EnableHighlightPlateDelaySec;

	[Tooltip("The amount of time (in seconds) to wait before disabling the updraft plate's rune. This delay will happen after the actual updraft is disabled in order to stagger various visual and auditory cues.")]
	public float DisableHighlightPlateDelaySec;

	[Tooltip("How long to fade out the updraft effects in blinking before it turns off")]
	public float updraftBlinkFadeOutTime;

	[Tooltip("How long to fade in the updraft effects in blinking before it turns off")]
	public float updraftBlinkFadeInTime;

	public bool useColorChangesForUpdraftBlinkupdraftBlinkFadeInTime;

	public float updraftBlinkColorFadeTime;

	public Color firstUpdraftBlinkColor;

	public Color secondUpdraftBlinkColor;

	public Color thirdUpdraftBlinkColor;

	private NetworkedObjectInfo _networkedObjectInfo;

	private GameObject _bundleInstance;

	private DOTweenAnimator[] _diamonds;

	private int _numPlayersInUpdraft;

	private int _updraftBlinkNumber;

	private bool _canDisplayIcon;

	private bool _isBlinkingColors;

	private float _iconDisplayDistance;

	private float _originalHighlightPlateDuration;

	private CountdownTimer _endUpdraftCountdownTimer;

	private ParticleSystem[] _updraftBlinkparticleSystems;

	private Color[] _updraftBlinkStartColors;

	private Color[] _updraftBlinkEndColors;

	private bool _isHighlightPlateEnabled;

	internal string imageDefId
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

	internal float distanceToPlayer
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	protected bool isHighlightPlateEnabled
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public override void MStart()
	{
	}

	private void Init()
	{
	}

	public override void MOnDestroy()
	{
	}

	private void OnEnterUpdraftReceived(WorldObjectGlideEnterExitMessage message)
	{
	}

	private void IconUpdate()
	{
	}

	public override void MUpdate()
	{
	}

	protected override void TriggerStay(Collider other)
	{
	}

	protected override void EnterUpdraftRune()
	{
	}

	protected override void ExitUpdraftRune()
	{
	}

	private void DoUpdateNumPlayersInVolume(int inNumPlayersInVolume)
	{
	}

	private Color[] GetUpdraftEndColors(Color inUpdraftBlinkColor)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<ColorChangeUpdraft>d__51))]
	private IEnumerator ColorChangeUpdraft(int inColorChange, bool inImmediate = false)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<BlinkUpdraft>d__52))]
	private IEnumerator BlinkUpdraft()
	{
		return null;
	}

	private void PlayDiamondChangeAudio(int inNewNumPlayersInVolume, int inOldNumPlayersInVolume)
	{
	}

	private void SendGlideEnterExitMessage(bool inIsEntering)
	{
	}

	private void EndUpdraft_CountdownTick()
	{
	}

	private void EndUpdraft_CountdownCompleted()
	{
	}
}
