using UnityEngine;

public class EnableInRangeToLocalActor : ManagedBehaviour
{
	public enum ERangeState
	{
		NONE,
		OUTOFRANGE,
		INRANGE
	}

	public enum EScreenState
	{
		NONE,
		OFFSCREEN,
		ONSCREEN
	}

	public float range;

	public GameObject gameObjectReference;

	public bool disableOffScreen;

	private float? _rangeSq;

	[HideInInspector]
	public ERangeState desiredRangeState;

	[HideInInspector]
	public ERangeState currentRangeState;

	[HideInInspector]
	public EScreenState desiredScreenState;

	[HideInInspector]
	public EScreenState currentScreenState;

	private EnableInRangeToLocalActorController enableInRangeToLocalActorControllerInstance;

	public float rangeSq
	{
		get
		{
			return default(float);
		}
	}

	public static void Setup(GameObject inParentGameObject, GameObject inGameObjectReference, float inRange, bool inDisableOffScreen)
	{
	}

	public override void MOnEnable()
	{
	}

	public override void MOnDisable()
	{
	}

	public void Setup(GameObject inGameObjectReference, float inRange, bool inDisableOffScreen)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
