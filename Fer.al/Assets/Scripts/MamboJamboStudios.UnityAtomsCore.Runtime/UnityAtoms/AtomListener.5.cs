using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms
{
	[EditorIcon("atom-icon-orange")]
	public abstract class AtomListener<T1, T2, A, E, UER> : BaseAtomListener, IAtomListener<T1, T2> where A : AtomAction<T1, T2> where E : AtomEvent<T1, T2> where UER : UnityEvent<T1, T2>
	{
		[SerializeField]
		private E _event;

		public UER _unityEventResponse;

		[SerializeField]
		private List<A> _actionResponses;

		public E Event
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnEventRaised(T1 first, T2 second)
		{
		}

		public void DebugLog(T1 item1, T2 item2)
		{
		}
	}
}
