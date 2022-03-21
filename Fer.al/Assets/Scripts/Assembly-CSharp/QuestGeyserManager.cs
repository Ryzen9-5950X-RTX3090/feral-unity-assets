using System;
using NodeCanvas.Framework;
using UnityEngine;

public class QuestGeyserManager : MonoBehaviour
{
	[Serializable]
	public class QuestGeyserCollection
	{
		public GameObject geysersParent;

		internal QuestGeyser[] geysers;

		public void Init()
		{
		}
	}

	[Serializable]
	public class QuestGeyserTimedSequence
	{
		public float geysersOnTime;

		public float geysersSwitchTime;

		public float geyserOffTime;

		public QuestGeyserCollection[] timedGeysers;

		private int _collectionIndex;

		private float _geysersOnTime;

		private float _geysersSwitchTime;

		private float _geyserOffTime;

		internal void InitSequence()
		{
		}

		internal void UpdateSequence(float inDeltaTime)
		{
		}
	}

	public GraphOwner respawnGraphOwner;

	public QuestGeyserTimedSequence[] timedSequences;

	public GameObject randomGeysersParent;

	private QuestGeyser[] _randomGeysers;

	public GameObject alwaysOnGeysersParent;

	private QuestGeyser[] _alwaysOnGeysers;

	public float randomTimeOnMin;

	public float randomTimeOffMin;

	public float randomTimeOnMax;

	public float randomTimeOffMax;

	public FeralAudioEmitter impactAudio;

	private static bool _respawning;

	private bool _controlsEnabled;

	private bool _active;

	internal static QuestGeyserManager instance;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	public void Activate()
	{
	}

	private void Update()
	{
	}

	internal void TrapPlayer()
	{
	}

	public void RespawnFinished()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
