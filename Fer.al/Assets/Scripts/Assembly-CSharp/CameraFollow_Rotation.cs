using UnityEngine;

public class CameraFollow_Rotation : ManagedBehaviour
{
	public float viewAngle;

	private Vector3 _forward;

	private static int _lastFramePlayerPositionUpdated;

	private static bool _playerIsNull;

	private static Vector3 _playerPosition;

	private Transform _cachedTransform;

	public override void MStart()
	{
	}

	protected static void UpdatePlayerPosition()
	{
	}

	public override void MUpdate()
	{
	}
}
