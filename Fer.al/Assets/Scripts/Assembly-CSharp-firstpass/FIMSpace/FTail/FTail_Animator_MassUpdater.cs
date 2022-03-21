using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FIMSpace.Basics;
using UnityEngine;

namespace FIMSpace.FTail
{
	public class FTail_Animator_MassUpdater : MonoBehaviour
	{
		protected List<FTail_AnimatorBase> tails;

		private List<FTail_AnimatorBase> tailsQueue;

		[Space]
		[Space]
		[Header("Use this component only when")]
		[Space(-11f)]
		[Header("you use a lot of tail animators")]
		[Space(7f)]
		public EFUpdateClock UpdateClock;

		public List<Transform> TailAnimatorsFrom;

		[Space]
		[Space]
		[Header("With new instatiated tail animators")]
		[Space(-11f)]
		[Header("list must be refreshed from code")]
		[Space(7f)]
		[Tooltip("Refersh tail animators by using AddTailToUpdate() method")]
		public bool GetFromWholeScene;

		private static FTail_Animator_MassUpdater WholeSceneGetter;

		public bool DelayedStart;

		private bool initialized;

		[IteratorStateMachine(typeof(<Start>d__8))]
		protected virtual IEnumerator Start()
		{
			return null;
		}

		protected virtual void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}

		private void UpdateTails()
		{
		}

		public void AddTailToUpdate(FTail_AnimatorBase tail)
		{
		}
	}
}
