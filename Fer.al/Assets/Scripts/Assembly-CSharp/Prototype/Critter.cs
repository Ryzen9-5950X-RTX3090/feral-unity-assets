using UnityEngine;
using UnityEngine.AI;

namespace Prototype
{
	public class Critter : ManagedBehaviour
	{
		private NavMeshAgent _agent;

		private Animation _animation;

		[SerializeField]
		private Transform _navParent;

		[SerializeField]
		private AnimationClip[] _clips;

		private float _pathTimer;

		[SerializeField]
		private float _pathRandomMinTime;

		[SerializeField]
		private float _pathRandomMaxTime;

		private float _animTimer;

		[SerializeField]
		private float _randomAnimMinTime;

		[SerializeField]
		private float _randomAnimMaxTime;

		private static Critter _critter;

		public static Critter Get()
		{
			return null;
		}

		public override void MStart()
		{
		}

		public override void MUpdate()
		{
		}

		private void SetNewAnim()
		{
		}

		private void SetNewPath()
		{
		}
	}
}
