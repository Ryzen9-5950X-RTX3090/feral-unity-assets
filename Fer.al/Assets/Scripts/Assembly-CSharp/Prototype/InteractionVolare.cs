using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Prototype
{
	public class InteractionVolare : Interactable
	{
		public static List<InteractionVolare> activeVolares;

		private Rigidbody _rigidbody;

		private NavMeshAgent _agent;

		private Transform _followTarget;

		public Rigidbody m_rigidbody
		{
			get
			{
				return null;
			}
		}
	}
}
