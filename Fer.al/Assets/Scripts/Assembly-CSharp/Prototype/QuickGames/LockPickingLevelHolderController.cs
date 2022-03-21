using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames
{
	public class LockPickingLevelHolderController : MonoBehaviour
	{
		public List<Sprite> rewardSprites;

		private Image rewardImage;

		private Color startColor;

		private Color revealColor;

		private float revealTime;

		private float elapsedTime;

		public void Setup(int levelIndex)
		{
		}

		[IteratorStateMachine(typeof(<RevealReward>d__7))]
		public IEnumerator RevealReward()
		{
			return null;
		}
	}
}
