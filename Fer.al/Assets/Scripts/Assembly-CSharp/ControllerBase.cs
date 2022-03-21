using UnityEngine;

public class ControllerBase : MonoBehaviour
{
	public int updateInterval;

	private static ActorBase _localActor;

	private static Transform _cachedLocalActorTransform;

	private static Transform _cachedPlayerCamera;

	protected static ActorBase localActor
	{
		get
		{
			return null;
		}
	}

	protected static Transform cachedLocalActorTransform
	{
		get
		{
			return null;
		}
	}

	protected static Transform cachedPlayerCameraTransform
	{
		get
		{
			return null;
		}
	}
}
