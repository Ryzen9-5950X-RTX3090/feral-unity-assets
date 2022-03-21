using System.Collections.Generic;
using UnityEngine;

[ManagedBehaviourManager("SanctuaryManager")]
public class SanctuaryDoor : ManagedBehaviour
{
	public class DoorPivot
	{
		public Transform pivot;

		public bool isOpen;

		public Vector3 openRotation;

		public Vector3 closeRotation;

		public Quaternion desiredRotation;
	}

	private List<DoorPivot> _doorPivots;

	private float _openDistance;

	private float _forceOpenDistance;

	private float _openCloseTime;

	private float _dot;

	private bool _flipRotation;

	private Transform _cachedPlayerTransform;

	private Transform cachedPlayerTransform
	{
		get
		{
			return null;
		}
	}

	public override void MStart()
	{
	}

	public void Setup(bool inFlipRotation)
	{
	}

	private DoorPivot SetupDoorPivot(Transform inTransform)
	{
		return null;
	}

	public override void MUpdate()
	{
	}
}
