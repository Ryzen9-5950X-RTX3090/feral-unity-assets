using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BuildersFollyTile : MonoBehaviour
{
	[Serializable]
	public struct Path
	{
		[SerializeField]
		public Transform[] pathPoints;
	}

	[RootSelector("Station Name", "LocalizationChartData", false, false)]
	public string StationName;

	public BuildersFollyData.ETileTypes tileType;

	public BuildersFollyData.ETileGridPlacement tileGridPlacement;

	public BuildersFollyGridSpot[] gridSpots;

	public Path[] paths;

	public GameObject invalidIndicator;

	public Sprite stationImage;

	public GameObject selectedIndicator;

	public GameObject flip;

	public GameObject rotate;

	public Transform fxAttachPoint;

	public bool useHeightForMoveIndicator;

	public float moveIndicatorHeight;

	public bool useColorChangeForMoveIndication;

	public Color moveIndicatorColor;

	public bool useJiggleForMovementIndicator;

	public Transform jiggleTransform;

	public Vector3 jiggleMaxRotation;

	public float jiggleRotationSpeed;

	private Quaternion _initialRotation;

	internal bool trappedTwiggle;

	internal bool flipped;

	internal bool inMoveMode;

	internal int tileRotation;

	internal int gridXspot;

	internal int gridZspot;

	internal bool _isValid;

	internal Animator animator;

	internal BuildersFollyGridSpot closestGridSpot;

	internal BuildersFollyTile previousTile;

	internal BuildersFollyTile nextTile;

	private bool wasValid;

	internal bool isValid
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	internal void UpdateValid()
	{
	}

	internal void AnimationDelivered()
	{
	}

	internal void AnimationTrigger(bool inPlay)
	{
	}

	[IteratorStateMachine(typeof(<PulseIndicator>d__40))]
	internal IEnumerator PulseIndicator()
	{
		return null;
	}
}
