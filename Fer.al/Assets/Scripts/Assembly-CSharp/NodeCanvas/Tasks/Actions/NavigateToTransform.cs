using System.Collections;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/NPC")]
	[Description("Sends a navigation command to a NavMesh Agent")]
	public class NavigateToTransform : ActionTask
	{
		public NavMeshAgent navMeshAgent;

		public Transform destinationTransform;

		public bool waitForFinish;

		public bool matchNPCRotation;

		public bool disableFacePlayerBeforeMove;

		public bool enableFacePlayerAfterMove;

		public float speed;

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

		[IteratorStateMachine(typeof(<ExecuteCoroutine>d__10))]
		private IEnumerator ExecuteCoroutine()
		{
			return null;
		}
	}
}
