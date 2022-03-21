using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms
{
	[EditorIcon("atom-icon-orange")]
	public abstract class AtomListener<T, A, E, UER> : BaseAtomListener, IAtomListener<T> where A : AtomAction<T> where E : AtomEvent<T> where UER : UnityEvent<T>
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

		public void OnEventRaised(T item)
		{
		}

		public void DebugLog(T item)
		{
		}
	}
}
