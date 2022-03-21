using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames.CatchThrownItems
{
	public class CatchThrownItems : QuickGamesBase
	{
		[Header("Intro")]
		public float timeForIntro;

		[Header("Catch Thrown Items")]
		public Transform forground;

		public CatchThrownItemsThrower thrower1_arm;

		public CatchThrownItemsThrower thrower2_arm;

		public Transform landLocations;

		public Transform basket;

		public CatchThrownItemsItem thrownItem;

		public Transform shadow;

		public CatchThrownItemsDragTarget dragTarget;

		public float throwArmRotateRange;

		public float throwTimeBack;

		public float throwTimeSpawnItem;

		public float throwTimeThrow;

		public float throwTimeFollowThrough;

		public float throwWaitTimeMin;

		public float throwWaitTimeMax;

		public int itemArchSegments;

		public float itemInAirTime;

		public float itemCatchTime;

		public float itemArchHeightMin;

		public float itemArchHeightMax;

		public float itemArchDistMin;

		public float itemArchDistMax;

		public int numItemsBeforeRareMin;

		public int numItemsBeforeRareMax;

		internal List<CatchThrownItemsItem> allItems;

		internal int itemsCaught;

		internal bool rareCaught;

		private int _numItemsThrown;

		private int _throwRare;

		internal List<Transform> itemLandLocations;

		public override void MStart()
		{
		}

		[IteratorStateMachine(typeof(<ShowIntro>d__31))]
		public override IEnumerator ShowIntro()
		{
			return null;
		}

		public override void QuickGameUpdate()
		{
		}

		internal CatchThrownItemsItem SpawnIten(Transform inTrans)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<ShowResults>d__35))]
		public override IEnumerator ShowResults()
		{
			return null;
		}
	}
}
