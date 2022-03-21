using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

namespace Prototype.QuickGames
{
	public class LockPickingUIController : MonoBehaviour
	{
		public List<Image> pickImages;

		private int currentPick;

		private int numPicks;

		public void Setup(int numPicks)
		{
		}

		public int BreakPick()
		{
			return default(int);
		}

		[IteratorStateMachine(typeof(<AnimatePickFadeOut>d__5))]
		private IEnumerator AnimatePickFadeOut(int pickIndex, float fadeTime = 0.5f)
		{
			return null;
		}
	}
}
