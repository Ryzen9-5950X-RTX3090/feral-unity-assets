using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames.GatherDroppedItems
{
	public class GatherDroppedItems : QuickGamesBase
	{
		[Header("Intro")]
		public float timeForIntro;

		[Header("Gather Dropped Items")]
		public GatherDroppedItemsMaker itemMaker;

		public Transform itemGatherer;

		public Transform itemHolder;

		public GatherDroppedItemsItem item;

		public RawImage bgRawImage;

		public float itemGathererMatchRotateTime;

		public float itemSpeedScalerTime;

		public float itemLifeSpanMin;

		public float itemLifeSpanMax;

		public float itemFadeOutTime;

		public float itemDamp;

		public float bgUvDamp;

		public float gatherRange;

		public float followRange;

		public float followTime;

		public float followScaler;

		internal float followRatio;

		internal bool isPressed;

		internal float dTime;

		internal Vector3 moveDir;

		internal List<GatherDroppedItemsItem> allItems;

		private float _currentFollowTime;

		private int _embersCaught;

		private float _itemSpeedScalerTime;

		private float _itemGathererMatchRotateTime;

		private Vector3 _startMoveDir;

		private Quaternion _startGatherRotation;

		private bool _rareCaught;

		private float currentFollowTime
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public override void MStart()
		{
		}

		[IteratorStateMachine(typeof(<ShowIntro>d__33))]
		public override IEnumerator ShowIntro()
		{
			return null;
		}

		public override void QuickGameUpdate()
		{
		}

		private void Gather(int i)
		{
		}

		[IteratorStateMachine(typeof(<ShowResults>d__36))]
		public override IEnumerator ShowResults()
		{
			return null;
		}

		internal void NewItem(Vector3 inLocalPosition, GatherDroppedItemsItem.EItemType inItemType = GatherDroppedItemsItem.EItemType.ITEM)
		{
		}

		private void GetImage(RawImage inRawImage, WinIngredient inWinIngredient)
		{
		}
	}
}
