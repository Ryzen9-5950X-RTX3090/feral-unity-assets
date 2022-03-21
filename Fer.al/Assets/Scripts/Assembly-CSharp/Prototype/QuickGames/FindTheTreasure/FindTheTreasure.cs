using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames.FindTheTreasure
{
	public class FindTheTreasure : QuickGamesBase
	{
		[Header("Intro")]
		public float timeForIntro;

		[Header("Find The Treasure")]
		public FindTheTreasure_dragTarget dragTarget;

		public int minNonRareObjects;

		public int maxNonRareOnjects;

		public Transform aObject;

		public Transform spawnLocations_rare;

		public Transform spawnLocations_nonRare;

		public float spotAngle;

		public float discoverDistanceMin;

		public float discoverDistanceMax;

		public float revealTime;

		private List<Transform> _allObjects;

		private List<RawImage> _allRawImages;

		private bool _rareFound;

		private int _nonRaresFound;

		private float _colorVal;

		private float _dist2obj;

		public override void UAwake()
		{
		}

		public override void MStart()
		{
		}

		private void GetImage(RawImage inRawImage, WinIngredient inWinIngredient)
		{
		}

		[IteratorStateMachine(typeof(<ShowIntro>d__20))]
		public override IEnumerator ShowIntro()
		{
			return null;
		}

		public override void QuickGameUpdate()
		{
		}

		[IteratorStateMachine(typeof(<FoundObject>d__22))]
		private IEnumerator FoundObject(Transform inTrans, RawImage inRawImage)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<ShowResults>d__23))]
		public override IEnumerator ShowResults()
		{
			return null;
		}
	}
}
