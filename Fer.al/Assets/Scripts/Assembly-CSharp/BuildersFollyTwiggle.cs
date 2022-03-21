using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BuildersFollyTwiggle : MonoBehaviour
{
	internal enum EState
	{
		Collect,
		GotoPathPartEnd,
		Deliver,
		WaitForOtherTwiggle,
		OutputBuilding,
		InputBuilding,
		WaitAfterBuild,
		Celebrate,
		DeadEnd,
		OutOfResources,
		Trapped
	}

	internal enum ECelebrateType
	{
		Fail,
		Success,
		Goal
	}

	public Transform twist;

	[RootSelector("World Object Prefab", "WorldObjectChartData", false, false)]
	public string actorPrefabDefID;

	[RootSelector("NPC", "ActorNPCChartData", false, false)]
	public string actorNPCDefID;

	public Sprite image;

	public float collectTime;

	public float deliverTime;

	public float deliverAudioWaitTime;

	public float jumpAudioWaitTime;

	public float twiggleKOSpeed;

	public float footstepDelay;

	public float cutTime;

	public float sewTime;

	public float buildTime;

	public float kilnTime;

	public float dyeTime;

	public float deadEndTime;

	public float spawnTime;

	public float turnTime;

	public Vector3 upDir;

	public Vector3 downDir;

	public Vector3 leftDir;

	public Vector3 rightDir;

	public GameObject fxSpawn;

	public GameObject fxFail;

	public GameObject fxSuccess;

	public GameObject fxConfetti;

	public GameObject fxMovement;

	internal int currentPathIndex;

	internal BuildersFollyData.BuildersFollyPath.PathPart pathPart;

	internal BuildersFollyData.Station inputStation;

	internal BuildersFollyData.Station outputStation;

	internal BuildersFollyTwiggleManager twiggleManager;

	internal BuildersFollyResource resource;

	internal EState state;

	private ECelebrateType _celebrateType;

	private Vector3 _startPos;

	private Transform _headFXpoint;

	private Vector3 _oldDir;

	private Vector3 _currentDir;

	private Vector3 _desiredDir;

	private BuildersFollyGame _game;

	private static Vector3 _endScale;

	private IEnumerator _playFootStep;

	internal bool trapped;

	private Animator _animator;

	internal int stationMoveWaits;

	private Animator animator
	{
		get
		{
			return null;
		}
	}

	private void Start()
	{
	}

	internal void InstantiateActor()
	{
	}

	[IteratorStateMachine(typeof(<Spawn>d__51))]
	internal IEnumerator Spawn()
	{
		return null;
	}

	internal void Despawn()
	{
	}

	[IteratorStateMachine(typeof(<CollectWait>d__53))]
	internal IEnumerator CollectWait()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<PlayFootsteps>d__54))]
	private IEnumerator PlayFootsteps()
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	internal void UpdateMove()
	{
	}

	internal void UpdateUnitMove()
	{
	}

	[IteratorStateMachine(typeof(<TwiggleKO>d__58))]
	private IEnumerator TwiggleKO()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<DeliverWait>d__59))]
	private IEnumerator DeliverWait()
	{
		return null;
	}

	private void SetCelebrateType()
	{
	}

	internal void SetInitialDirection()
	{
	}

	[IteratorStateMachine(typeof(<SetCurrentDirection>d__62))]
	private IEnumerator SetCurrentDirection()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<TurnToDir>d__63))]
	private IEnumerator TurnToDir()
	{
		return null;
	}

	internal void Celebrate(ECelebrateType inCelebrateType)
	{
	}

	[IteratorStateMachine(typeof(<UseStation>d__66))]
	internal IEnumerator UseStation()
	{
		return null;
	}

	internal void SetPathPart(BuildersFollyData.BuildersFollyPath.PathPart inPathPart)
	{
	}

	internal void CrossedSaw(BuildersFollyGridSpot[] inSawGridSpots)
	{
	}
}
