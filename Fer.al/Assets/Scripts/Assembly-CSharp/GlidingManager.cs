using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class GlidingManager : SingletonManagerBase<GlidingManager>
{
	[Tooltip("Distance from player to startdisplaying the MP Updraft icon.")]
	public float iconDisplayDistance;

	[Tooltip("Y Offset from the glide object for the icon.")]
	public float iconOffset;

	[SerializeField]
	[Tooltip("True to allow gliding, false to prevent it.")]
	private bool _isGlidingAllowed;

	[SerializeField]
	[Tooltip("Determines whether or not gliding requires an updraft.")]
	private bool _isGlidingOutsideOfUpdraftAllowed;

	[SerializeField]
	[Tooltip("Determines how the player can glide. Tap to Toggle means there is a dedicated button to toggle gliding. Hold to Glide means that the user has to hold jump to glide. Double Tap Jump means that the user can tap jump while in the air to glide.")]
	private GlidingControlsType _glidingControlsType;

	[SerializeField]
	[Tooltip("The key on desktop to toggle gliding. Only applies when using Tap to Toggle controls.")]
	private KeyCode _glidingControlKey;

	[SerializeField]
	[Tooltip("The amount of gravity that is applied while gliding. For reference, gravity while falling is 25.")]
	[Range(0f, 25f)]
	private float _glidingGravityAmount;

	[SerializeField]
	[Tooltip("The amount of left/right tilt to apply to the avatar while turning.")]
	[Range(0f, 20f)]
	private float _glidingRollAmount;

	[SerializeField]
	[Tooltip("The max degree we allow for roll rotation in either direction.")]
	[Range(0f, 270f)]
	private float _glidingMaxRollAngle;

	[SerializeField]
	[Tooltip("This value is multiplied to the avatars running speed to determine how fast it can glide.")]
	[Range(0.1f, 3f)]
	private float _maxSpeedMultiplier;

	[SerializeField]
	[Tooltip("Determines how quickly an avatar is thrown into the air from an updraft. Note that this is the base value for all updrafts, but each updraft can apply their own speed multiplier on this base number.")]
	[Range(1f, 35f)]
	private float _updraftAcceleration;

	[SerializeField]
	[Tooltip("When the avatar reaches this speed inside of an updraft, it will no longer accelerate.")]
	[Range(10f, 50f)]
	private float _maxUpdraftSpeed;

	[SerializeField]
	[Tooltip("Apply this to the normal movement turn speed while gliding.")]
	[Range(0.002f, 1f)]
	private float _glideTurnSpeed;

	[SerializeField]
	[Tooltip("Links up the updraft prefab so that it can be instantiated at runtime if desired.")]
	private GameObject _glidingUpdraftPrefab;

	public WindUpdraft latestUpdraftActingOnPlayer;

	private int _updraftsActingOnPlayer;

	internal List<MPWindUpdraft> currentMPWindUpdrafts;

	private ObscuredBool _hasWingsEquipped;

	internal static float sendExitWait;

	internal ObscuredBool passedServerValidation;

	internal ObscuredBool recheckNeeded;

	private readonly List<WindUpdraft> _updrafts;

	private bool IsAvatarLoaded
	{
		get
		{
			return default(bool);
		}
	}

	public ObscuredBool IsInUpdraft
	{
		get
		{
			return default(ObscuredBool);
		}
	}

	public bool GlidingButtonDown
	{
		get
		{
			return default(bool);
		}
	}

	public bool GlidingButton
	{
		get
		{
			return default(bool);
		}
	}

	internal MPWindUpdraft currentMPWindUpdraft
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

	public ObscuredBool IsGlidingEnabled
	{
		get
		{
			return default(ObscuredBool);
		}
	}

	public bool IsGlidingOutsideOfUpdraftAllowed
	{
		get
		{
			return default(bool);
		}
	}

	public GlidingControlsType GlidingControlsType
	{
		get
		{
			return default(GlidingControlsType);
		}
	}

	public KeyCode GlidingControlKey
	{
		get
		{
			return default(KeyCode);
		}
	}

	public float GlidingGravityAmount
	{
		get
		{
			return default(float);
		}
	}

	public float GlidingRollAmount
	{
		get
		{
			return default(float);
		}
	}

	public float GlidingMaxRollAngle
	{
		get
		{
			return default(float);
		}
	}

	public float MaxSpeedMultiplier
	{
		get
		{
			return default(float);
		}
	}

	public float UpdraftAccerleration
	{
		get
		{
			return default(float);
		}
	}

	public float MaxUpdraftSpeed
	{
		get
		{
			return default(float);
		}
	}

	public float GlideTurnSpeed
	{
		get
		{
			return default(float);
		}
	}

	internal void RemoveUpdraft(MPWindUpdraft inMPWindUpdraft)
	{
	}

	internal void IconUpdate()
	{
	}

	public override void MStart()
	{
	}

	public override void MUpdate()
	{
	}

	public override void MOnDestroy()
	{
	}

	private void WingsEquippedCheck(WindowClosedMessage inMessage)
	{
	}

	public void IncrementUpdraftCount(WindUpdraft inWindUpdraft)
	{
	}

	public void DecrementUpdraftCount()
	{
	}

	private void Reload(Message message)
	{
	}

	private void SetGlideKey(KeyCode keyCode)
	{
	}

	internal void ClearUpdrafts()
	{
	}
}
