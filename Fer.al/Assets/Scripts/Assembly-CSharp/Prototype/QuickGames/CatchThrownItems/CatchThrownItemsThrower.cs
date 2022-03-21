using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames.CatchThrownItems
{
	public class CatchThrownItemsThrower : UnityEngine.MonoBehaviour
	{
		private enum EState
		{
			WAITING,
			BACK,
			SPAWN,
			THROW,
			LAUNCH,
			FOLLOWTHROUGH
		}

		public Transform throwPoint;

		public int archDir;

		internal CatchThrownItems game;

		private EState _state;

		private float _currentTime;

		private Quaternion _startRotation;

		private Quaternion _backRotation;

		private CatchThrownItemsItem _currentItem;

		public float rockAngleMin;

		public float rockAngleMax;

		public float rockTimeMin;

		public float rockTimeMax;

		private bool _rockinBack;

		private bool _rockin;

		private float _currentRockTime;

		private Quaternion _rockLeft;

		private Quaternion _rockRight;

		internal void Init()
		{
		}

		[IteratorStateMachine(typeof(<Rockin>d__19))]
		private IEnumerator Rockin()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		internal void ThrowerUpdate()
		{
		}
	}
}
