using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace FIMSpace.Basics
{
	public class FBasic_Shared_PanelAnimations : MonoBehaviour
	{
		[Tooltip("How long in seconds should be played animation of button going down")]
		public float AnimationTime;

		[Tooltip("Extra value for easing functions to change a little their elasticity or other beahaviour")]
		public float EaseExtraValue;

		private Transform buttonTransform;

		private Vector3 buttonInitPosition;

		protected virtual void Start()
		{
		}

		public virtual void Click()
		{
		}

		[IteratorStateMachine(typeof(<ClickAniamtion>d__6))]
		private IEnumerator ClickAniamtion()
		{
			return null;
		}
	}
}
