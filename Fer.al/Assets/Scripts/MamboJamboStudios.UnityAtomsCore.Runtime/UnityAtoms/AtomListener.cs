using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms
{
	[AddComponentMenu("Unity Atoms/Listeners/Atom Listener")]
	[EditorIcon("atom-icon-orange")]
	public sealed class AtomListener : BaseAtomListener, IAtomListener
	{
		[SerializeField]
		private AtomEvent _event;

		[SerializeField]
		public UnityEvent _unityEventResponse;

		[SerializeField]
		private List<AtomAction> _actionResponses;

		public AtomEvent Event
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

		public void OnEventRaised()
		{
		}
	}
}
