using System;
using System.Runtime.InteropServices;
using UnityEngine;
using WW.Waiters;

public class UI_CreaturePedestal : MonoBehaviour
{
	[SerializeField]
	private GameObject _loadingGroup;

	[SerializeField]
	private Transform _spinGroup;

	private ActorBase _spawnedCreature;

	private CreatureCustomizationTarget _creatureCustomizationTarget;

	private WW.Waiters.Waiter _loadWaiter;

	public Transform SpinGroup
	{
		get
		{
			return null;
		}
	}

	public ActorBase SpawnedAvatar
	{
		get
		{
			return null;
		}
	}

	public CreatureCustomizationTarget CreatureCustomizationTarget
	{
		get
		{
			return null;
		}
	}

	public Transform FallbackCameraTarget
	{
		get
		{
			return null;
		}
	}

	public void SetTarget(CreatureCustomizationTarget inTarget, [Optional] Action<ActorBase> inOnCreatureLoaded)
	{
	}

	public void Hide()
	{
	}

	private void Update()
	{
	}
}
