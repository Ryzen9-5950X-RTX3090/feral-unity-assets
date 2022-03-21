using System.Collections.Generic;
using UnityEngine;

namespace Prototype.QuickGames.GatherDroppedItems
{
	public class GatherDroppedItemsMaker : UnityEngine.MonoBehaviour
	{
		public bool showDbg;

		[Tooltip("The boundaries this object will circle in")]
		public float yMaxDist;

		[Tooltip("The boundaries this object will circle in")]
		public float xMaxDist;

		public int segmentsPerQuarter;

		public float segmentQuarterArchHeight;

		public int segmentsTravelMin;

		public int segmentsTravelMax;

		public float segmentTimeMin;

		public float segmentTimeMax;

		public float segmentInnerScaler;

		public float startStopSpeedScaler;

		public float speedScalerDampTime;

		public float newItemTimeMin;

		public float newItemTimeMax;

		internal GatherDroppedItems game;

		internal Transform trans;

		private int _pointListIndexMaster;

		private float _currentMoveTime;

		private float _currentItemTime;

		private float _itemTime;

		private float _segmentTime;

		private float _speedScaler;

		private float _totalCurrentTime;

		private float _speedScalerDampTime;

		private bool _dirControl;

		private int _pointListIndexCurrent;

		private List<Vector3> _allPointsList;

		private List<Vector3> _currentPointsList;

		private List<Transform> _goList;

		public float timeBetweenRewardMin;

		public float timeBetweenRewardMax;

		public int embersBeforeRareMin;

		public int embersBeforeRareMax;

		private float _timeBetweenReward;

		private int _embersBeforeRare;

		private bool _rareSpawned;

		private void Awake()
		{
		}

		internal void Init()
		{
		}

		internal void ItemMakerUpdate()
		{
		}

		private void GetNewCurrentPointsList()
		{
		}

		private void MakeAllPointsList(bool inMakeGO)
		{
		}

		private void MakeGO(Vector3 inV3)
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
