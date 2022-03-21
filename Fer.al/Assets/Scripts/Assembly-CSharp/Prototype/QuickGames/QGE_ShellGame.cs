using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames
{
	public class QGE_ShellGame : QuickGamesBase
	{
		[Header("Shell Game")]
		public QGE_ShellGameObject obj_shell;

		public GameObject obj_ball;

		[Header("Shuffleing")]
		public float xOffset;

		public float yShuffleOffset;

		[Header("Intro")]
		public float timeToShowBall;

		public int numberOfShuffles;

		public float timePerShuffle;

		[Header("Results")]
		public float fadeOutTime;

		private QGE_ShellGameObject[] _shells;

		private Transform[] _shells_transforms;

		public override void MStart()
		{
		}

		[IteratorStateMachine(typeof(<ShowIntro>d__11))]
		public override IEnumerator ShowIntro()
		{
			return null;
		}

		public void ButtonClick(bool inFoundBall)
		{
		}

		[IteratorStateMachine(typeof(<ShowResults>d__13))]
		public override IEnumerator ShowResults()
		{
			return null;
		}
	}
}
