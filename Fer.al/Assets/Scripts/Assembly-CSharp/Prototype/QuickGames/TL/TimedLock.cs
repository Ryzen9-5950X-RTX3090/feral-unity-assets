using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames.TL
{
	public class TimedLock : QuickGamesBase
	{
		[Header("Timed Lock")]
		public TimedLock_Lock[] locks;

		public Texture rewardImage;

		public Texture unlockImage;

		public float keyholeRotateSpeedMin;

		public float keyholeRotateSpeedMax;

		public float winThreshold;

		public float keyStartOffsetX;

		public float flashTime;

		public int flashes;

		[Header("Intro")]
		public float timeForIntro;

		private int _currentLockIndex;

		public override void MStart()
		{
		}

		[IteratorStateMachine(typeof(<ShowIntro>d__12))]
		public override IEnumerator ShowIntro()
		{
			return null;
		}

		public override void QuickGameUpdate()
		{
		}

		[IteratorStateMachine(typeof(<ShowResults>d__14))]
		public override IEnumerator ShowResults()
		{
			return null;
		}
	}
}
