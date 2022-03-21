using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames
{
	public class WhackAMole : QuickGamesBase
	{
		public GameObject holePrefab;

		private GameObject board;

		private Rect boardRect;

		private Rect holeRect;

		private GameObject topHole;

		private GameObject rightHole;

		private GameObject bottomHole;

		private GameObject leftHole;

		private WhackAMoleHoleController[] holeControllers;

		private int[] holeOrder;

		private int currentOrder;

		private int score;

		private float testF;

		private bool madeRare;

		private bool needRare;

		public override void MStart()
		{
		}

		private void Initialize()
		{
		}

		public override void QuickGameUpdate()
		{
		}

		public void MoleWhacked(WhackAMoleHoleController controller)
		{
		}

		[IteratorStateMachine(typeof(<ShowResults>d__19))]
		public override IEnumerator ShowResults()
		{
			return null;
		}
	}
}
