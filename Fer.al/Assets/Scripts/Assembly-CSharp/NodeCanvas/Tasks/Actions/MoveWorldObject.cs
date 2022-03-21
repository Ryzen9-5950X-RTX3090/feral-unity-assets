using System.Collections;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/WorldObject")]
	[Description("Sends move info to a world object.")]
	public class MoveWorldObject : ActionTask<ActorNPCSpawner>
	{
		public enum EMoveType
		{
			StartToEnd,
			StartToWaynpoint,
			WaypointToWaynpoint,
			WaypointToEnd
		}

		public Transform destination;

		public float speed;

		public float stopDistance;

		private RaycastHit _moverGroundHit;

		private Vector3 _lastPosition;

		public EMoveType moveType;

		private ActorBase _actorBase;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		private void SetFaceLocalPlayer(bool inFace)
		{
		}

		protected override void OnExecute()
		{
		}

		[IteratorStateMachine(typeof(<MoveIt>d__12))]
		private IEnumerator MoveIt()
		{
			return null;
		}
	}
}
