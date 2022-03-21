using UnityEngine;

public static class GetLayer
{
	private static int _actor;

	private static LayerMask _actorMask;

	private static int _decal;

	private static LayerMask _decalMask;

	private static int _playerAndCameraCollision;

	private static LayerMask _playerAndCameraCollisionMask;

	private static int _playerCollision;

	private static LayerMask _playerCollisionMask;

	private static int _water;

	private static LayerMask _waterMask;

	public static int CombinedLayerMask(int[] inLayerIDs)
	{
		return default(int);
	}

	public static int Actor(bool inReturnMask = false)
	{
		return default(int);
	}

	public static int Decal(bool inReturnMask = false)
	{
		return default(int);
	}

	public static int PlayerAndCameraCollision(bool inReturnMask = false)
	{
		return default(int);
	}

	public static int PlayerCollision(bool inReturnMask = false)
	{
		return default(int);
	}

	public static int Water(bool inReturnMask = false)
	{
		return default(int);
	}
}
