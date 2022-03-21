using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Prototype.QuickGames
{
	public class CoinCatch : QuickGamesBase, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		public GameObject instructions;

		public float instructionTime;

		public List<GameObject> catcherPrefabs;

		public List<GameObject> coinPrefabs;

		public GameObject deathVolumePrefab;

		public int numCoins;

		public int numRareCoins;

		public int rareValue;

		public int rareSpawnWait;

		public Sprite rareSprite;

		private GameObject coinPrefab;

		private GameObject catcherPrefab;

		private GameObject board;

		private GameObject foreground;

		private GameObject catcher;

		private List<CatchTargetController> catchTargets;

		private RectTransform catcherRect;

		private bool pointerDown;

		private bool anchorSet;

		private float pointerDownX;

		private bool forceLeftMovement;

		private bool forceRightMovement;

		private TargetJoint2D targetJoint;

		public GameObject DeathVolume
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public override void MStart()
		{
		}

		[IteratorStateMachine(typeof(<ShowIntro>d__28))]
		public override IEnumerator ShowIntro()
		{
			return null;
		}

		private void Initialize()
		{
		}

		public override void QuickGameUpdate()
		{
		}

		public void OnPointerDown(PointerEventData pointerEventData)
		{
		}

		public void OnPointerUp(PointerEventData pointerEventData)
		{
		}

		public void KillTarget(CatchTargetController catchTargetController)
		{
		}

		[IteratorStateMachine(typeof(<ShowResults>d__34))]
		public override IEnumerator ShowResults()
		{
			return null;
		}
	}
}
