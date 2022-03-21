using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames.CatchTheFish
{
	public class CatchTheFish : QuickGamesBase
	{
		[Serializable]
		public class LocatorInfo
		{
			public Transform spawnLaunch;

			public Transform spawnLand;

			public Transform catchLand;
		}

		private class Fish : UnityEngine.MonoBehaviour
		{
			internal bool isRare;

			internal bool canCatch;

			internal bool done;

			internal LocatorInfo MyLocatorInfo;

			private bool _caught;

			private bool _landing;

			private float _inAirTime;

			private float _caughtTime;

			private Vector3 _caughtPosition;

			private Quaternion _startRotation;

			private Quaternion _endRotation;

			private RawImage _image;

			private Transform _trans;

			internal CatchTheFish Game
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

			private void Awake()
			{
			}

			[IteratorStateMachine(typeof(<LaunchFish>d__18))]
			internal IEnumerator LaunchFish()
			{
				return null;
			}

			internal void MoveFish()
			{
			}

			[IteratorStateMachine(typeof(<LandFish>d__20))]
			private IEnumerator LandFish()
			{
				return null;
			}

			internal void Caught()
			{
			}
		}

		[Header("Intro")]
		public float timeForIntro;

		[Header("Catch The Fish")]
		public GameObject rareFish;

		public GameObject fish;

		public float minTimeBetweenFish;

		public float maxTimeBetweenFish;

		public int minFishBeforeRare;

		public int maxFishBeforeRare;

		public float launchLandTime;

		public float fishInAirTime;

		public float caughtTime;

		public LocatorInfo[] locatorInfos;

		private float _nextFishTime;

		private int[] _rndPattern;

		private int _patternIndex;

		private int _fishBeforeRare;

		private int _fishIndex;

		private List<Fish> _allFish;

		private RectTransform _hudRect;

		private Camera _cam;

		private bool _rareFishHit;

		private int _fishCaught;

		private Vector3 _cursorPosition;

		public override void UAwake()
		{
		}

		public override void MStart()
		{
		}

		[IteratorStateMachine(typeof(<ShowIntro>d__25))]
		public override IEnumerator ShowIntro()
		{
			return null;
		}

		public override void QuickGameUpdate()
		{
		}

		[IteratorStateMachine(typeof(<ShowResults>d__27))]
		public override IEnumerator ShowResults()
		{
			return null;
		}
	}
}
