using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(BoxCollider), typeof(WorldMapLocation))]
public class LevelGate : ManagedBehaviour
{
	[Header("Level Gate")]
	[RootSelector("To Level", "LevelChartData", false, false)]
	public string toLevelID;

	[SerializeField]
	private LevelGateType type;

	[SerializeField]
	[Header("Detection")]
	private float _range;

	private float? _rangeSq;

	private bool _particlesEnabled;

	private float _particleDotLimit;

	[Header("FX")]
	[RootSelector("Door Fx", "BundleIDChartData", false, false)]
	public string doorFxBundleId;

	[SerializeField]
	private Transform _fxSpawnPoint;

	[HideInInspector]
	public List<ParticleSystem> doorParticles;

	[SerializeField]
	[Header("Enabled/Disabled Objects")]
	private List<GameObject> gateEnabledObjects;

	[SerializeField]
	private List<GameObject> gateDisabledObjects;

	[Header("Spawn Points")]
	public Transform returnSpawnPoint;

	[SerializeField]
	private Transform exitSpawnPoint;

	public List<Transform> returnSpawnDestinations;

	private LevelDefComponent _levelDef;

	public float rangeSq
	{
		get
		{
			return default(float);
		}
	}

	public Transform fxSpawnPoint
	{
		get
		{
			return null;
		}
	}

	private LevelDefComponent LevelDef
	{
		get
		{
			return null;
		}
	}

	private void OnDrawGizmos()
	{
	}

	public override void MStartAfterLocal()
	{
	}

	private void OnTriggerEnter(Collider inCollider)
	{
	}

	public void ExitToLevel()
	{
	}

	[IteratorStateMachine(typeof(<DelayBeforeLoadingLevelForExitAnimation>d__25))]
	private IEnumerator DelayBeforeLoadingLevelForExitAnimation(float inDelay = 0f)
	{
		return null;
	}

	public void LoadLevel()
	{
	}

	public override void MUpdate()
	{
	}

	private void EnableParticles()
	{
	}

	private void DisableParticles()
	{
	}
}
