using System.Collections;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;

public class TerraceTreasurePuzzle : ManagedBehaviour
{
	public CinemachineVirtualCamera virtualStartCam;

	public Color activeColor;

	public GameObject correctFX;

	public GameObject[] blocks;

	public GameObject[] waterLevels;

	public GameObject[] waterParticles;

	public GameObject[] treasureWater;

	public GameObject startBlock;

	public GameObject endBlock;

	public float moveDuration;

	public float waitTime;

	private Camera _camera;

	private int _defaultLayerMask;

	private bool _treasure1;

	private bool _treasure2;

	private bool _treasure3;

	private bool _treasure4;

	private bool _treasure5;

	private bool _treasure6;

	private bool _treasure7;

	public override void MStart()
	{
	}

	[IteratorStateMachine(typeof(<finalTreasure>d__21))]
	public IEnumerator finalTreasure()
	{
		return null;
	}

	public void BlockMoveUp(GameObject blockMove)
	{
	}

	[IteratorStateMachine(typeof(<ResetGame>d__23))]
	public IEnumerator ResetGame()
	{
		return null;
	}

	public void CheckTreasure()
	{
	}

	public void EndGame()
	{
	}

	public void BlockDisabler(GameObject[] obj, int startVal, int endVal)
	{
	}

	public void ParticleDisabler(GameObject[] obj, int startVal)
	{
	}

	public void WaterLevelReset(GameObject[] watObj, int starVal)
	{
	}

	public override void MUpdate()
	{
	}
}
