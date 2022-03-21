using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames
{
	public class CatchObject : QuickGamesBase
	{
		public enum ECatchDirection
		{
			DOWN,
			UP,
			LEFT,
			RIGHT,
			OUT,
			IN
		}

		public Transform objectToCatch;

		public Transform catcher;

		public int numberOfCatchSlots;

		public float slotBorderMinDist;

		public float slotBorderMaxDist;

		public float objectToCatchMoveSpeed;

		public float catcherOffsetForWinLoss;

		public ECatchDirection catchDirection;

		private int _catcherSlotIndex;

		private int _objectToCatchSlotIndex;

		private Vector3 _objectToCatchPosition;

		private Vector3 _objectToCatchDirection;

		private Vector3[] _catcherLocations;

		private Quaternion[] _catcherRotations;

		private Renderer _objectToCatchRenderer;

		public override void MStart()
		{
		}

		public override void QuickGameUpdate()
		{
		}

		[IteratorStateMachine(typeof(<FinishGame>d__18))]
		private IEnumerator FinishGame()
		{
			return null;
		}

		private void MoveObjectToCatch()
		{
		}

		private void MoveCatcher()
		{
		}
	}
}
