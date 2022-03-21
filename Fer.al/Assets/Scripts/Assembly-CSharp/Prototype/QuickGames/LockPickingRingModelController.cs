using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames
{
	public class LockPickingRingModelController : MonoBehaviour
	{
		[Serializable]
		public class RingInfo
		{
			public Image ringImage;

			public float minAngle;

			public float maxAngle;
		}

		public List<RingInfo> ringVariatons;

		private RingInfo _currentRing;

		private float elapsedTime;

		private float fadeTime;

		private Color colorA;

		private Color colorB;

		public bool IsRingBetweenAngles
		{
			get
			{
				return default(bool);
			}
		}

		public void Setup(int inRingIndex, int inRingVariantIndex, int inLevelIndex, LockPickingRingController inParent)
		{
		}

		public void Rotate(float amount)
		{
		}

		public void Unlock(bool fadeImmediate = false)
		{
		}

		public void SetUpFadeOut(float time)
		{
		}

		public void UnlockFade(bool immediate = false)
		{
		}

		[IteratorStateMachine(typeof(<FadeOut>d__14))]
		public IEnumerator FadeOut()
		{
			return null;
		}
	}
}
