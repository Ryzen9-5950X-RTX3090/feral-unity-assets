using System.Collections;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/CineMachine")]
	[Description("Custom action for the tutorial")]
	public class TutorialCameraControl : ActionTask
	{
		public enum EActionType
		{
			DisablePlayerCamera,
			NPC_Look,
			Return
		}

		public EActionType actionType;

		public Transform cineCamera;

		public Transform priorCineCamera;

		private readonly float _alignTime;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnExecute()
		{
		}

		[IteratorStateMachine(typeof(<DoCameraTransition>d__8))]
		private IEnumerator DoCameraTransition()
		{
			return null;
		}
	}
}
