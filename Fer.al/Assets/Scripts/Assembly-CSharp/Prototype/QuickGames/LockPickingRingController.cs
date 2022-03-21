using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames
{
	public class LockPickingRingController : MonoBehaviour
	{
		public List<GameObject> ringModelPrefabs;

		private float rotationSpeed;

		private bool moving;

		private GameObject ringModel;

		private LockPickingRingModelController ringModelController;

		public LockPickingController parentController
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float FadeTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Setup(int inRingIndex, QGEChestSettings.RingInfo inRingInfo, float inDirection, int inLevelTypeIndex, LockPickingController inLockPickingController)
		{
		}

		public void EnteredByPick()
		{
		}

		public bool CanPickEnterRing()
		{
			return default(bool);
		}

		public void Unlock()
		{
		}

		public void Freeze()
		{
		}

		public void UnFreeze()
		{
		}

		private void Update()
		{
		}

		[IteratorStateMachine(typeof(<FadeOut>d__20))]
		public IEnumerator FadeOut()
		{
			return null;
		}
	}
}
