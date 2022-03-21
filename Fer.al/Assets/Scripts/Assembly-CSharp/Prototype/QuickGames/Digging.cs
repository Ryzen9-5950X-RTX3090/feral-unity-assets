using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames
{
	public class Digging : QuickGamesBase
	{
		public GameObject instructions;

		public float instructionTime;

		public GameObject cellPrefab;

		public GameObject borderPrefab;

		public Sprite defaultContentsPartial;

		public Sprite defaultContents;

		public Sprite tripleEmberContentsPartial;

		public Sprite tripleEmberContents;

		public Sprite uncommonContentsPartial;

		public Sprite uncommonContents;

		public Sprite uncommonContentsOpen;

		public Sprite rareContentsPartial;

		public Sprite rareContents;

		public Sprite rareContentsOpen;

		public Sprite bombContentsPartial;

		public Sprite bombContents;

		public Sprite emptyContentsPartial;

		public Sprite emptyContents;

		public int numRows;

		public int numColumns;

		public int numRares;

		public int numUncommons;

		public int numBombs;

		public int numTripleEmbers;

		public int numEmbers;

		[Range(0f, 1f)]
		public float difficultyChance;

		public int maxDifficults;

		private GameObject board;

		private Rect boardRect;

		private Rect cellRect;

		private int collectedEmbers;

		private int collectedUncommons;

		private int collectedRares;

		public override void MStart()
		{
		}

		[IteratorStateMachine(typeof(<ShowIntro>d__34))]
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

		public void Collect(DiggingCellController diggingCell)
		{
		}

		[IteratorStateMachine(typeof(<ShowResults>d__38))]
		public override IEnumerator ShowResults()
		{
			return null;
		}
	}
}
