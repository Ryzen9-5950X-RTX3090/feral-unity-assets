using System.Collections.Generic;
using UnityEngine;

namespace Prototype.QuickGames
{
	public class Timing : QuickGamesBase
	{
		public GameObject cursorPrefab;

		public GameObject targetPrefab;

		public float playAreaWidth;

		public float playAreaHeight;

		public float targetAreaWidth;

		public float targetAreaHeight;

		public float cursorWidth;

		public float cursorHeight;

		public float cursorGap;

		public int numCursors;

		public float cursorVelocity;

		private List<GameObject> cursors;

		private GameObject currentCursor;

		private int ccIdx;

		public override void MStart()
		{
		}

		private void Initialize()
		{
		}

		public override void QuickGameUpdate()
		{
		}
	}
}
