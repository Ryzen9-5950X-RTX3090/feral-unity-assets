using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames.TL
{
	public class TimedLock_Lock : MonoBehaviour
	{
		internal enum ERewardType
		{
			EMBER,
			REWARD,
			NONE
		}

		public Transform keyhole;

		public Transform key;

		public Transform reward;

		internal RawImage rewardImage;

		private RawImage _lockImage;

		private RawImage _keyImage;

		private RawImage _keyholeImage;

		private Vector3 _keyStartPosition;

		internal ERewardType RewardType
		{
			[CompilerGenerated]
			get
			{
				return default(ERewardType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public TimedLock Game
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool Rotating
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Awake()
		{
		}

		[IteratorStateMachine(typeof(<StartRotate>d__22))]
		public IEnumerator StartRotate()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<Flash>d__23))]
		internal IEnumerator Flash(bool inPass)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<TryLock>d__24))]
		internal IEnumerator TryLock(bool inPass)
		{
			return null;
		}
	}
}
