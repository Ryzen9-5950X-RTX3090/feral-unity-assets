using System;
using System.Collections.Generic;
using UnityEngine;

public class ActorDependencyVolumeController : ControllerBase
{
	public enum EShape
	{
		SPHERE,
		RECTANGLE
	}

	public enum EState
	{
		NONE,
		ENTER,
		EXIT
	}

	[Serializable]
	public class Dependencies
	{
		public int players;

		public int playerExperience;

		public List<string> clothingItemDefId;

		public List<string> animationDefId;

		public List<string> bodyPartDefId;

		public List<string> classDefId;

		[HideInInspector]
		public List<string> inventoryDefId;

		[HideInInspector]
		public List<string> factionDefId;

		[HideInInspector]
		public List<string> familiarDefId;

		[HideInInspector]
		public List<string> familiarClassDefId;

		[HideInInspector]
		public List<string> objectiveCompletedDefId;
	}

	private static ActorDependencyVolumeController _instance;

	public List<ActorDependencyVolume> _actorDependencyVolumes;

	public static ActorDependencyVolumeController instance
	{
		get
		{
			return null;
		}
	}

	public void Add(ActorDependencyVolume inEnableInRangeToLocalActor)
	{
	}

	public void Remove(ActorDependencyVolume inEnableInRangeToLocalActor)
	{
	}

	private void Update()
	{
	}

	private bool InRange(ActorDependencyVolume inVolume)
	{
		return default(bool);
	}

	private Vector3 GetRelativePosition(ActorDependencyVolume inVolume)
	{
		return default(Vector3);
	}

	private bool ValidDependencies(ActorDependencyVolume inVolume)
	{
		return default(bool);
	}

	private bool ValidAnimation(ActorDependencyVolume inVolume)
	{
		return default(bool);
	}

	private bool ValidClothingItem(ActorDependencyVolume inVolume)
	{
		return default(bool);
	}

	private bool ValidBodyPart(ActorDependencyVolume inVolume)
	{
		return default(bool);
	}

	private bool ValidClass(ActorDependencyVolume inVolume)
	{
		return default(bool);
	}

	private bool ValidInventory(ActorDependencyVolume inVolume)
	{
		return default(bool);
	}

	private bool ValidFaction(ActorDependencyVolume inVolume)
	{
		return default(bool);
	}

	private bool ValidFamiliar(ActorDependencyVolume inVolume)
	{
		return default(bool);
	}

	private bool ValidFamiliarClass(ActorDependencyVolume inVolume)
	{
		return default(bool);
	}

	private bool ValidObjectiveCompleted(ActorDependencyVolume inVolume)
	{
		return default(bool);
	}

	private bool ValidExperience(ActorDependencyVolume inVolume)
	{
		return default(bool);
	}
}
