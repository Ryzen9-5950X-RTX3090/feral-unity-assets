using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UnityAtoms
{
	[EditorIcon("atom-icon-cherry")]
	public abstract class AtomEvent : BaseAtom, ISerializationCallbackReceiver
	{
		public event Action OnEventNoValue
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected void RaiseNoValue()
		{
		}

		public void Register(Action del)
		{
		}

		public void Unregister(Action del)
		{
		}

		public void RegisterListener(IAtomListener listener)
		{
		}

		public void UnregisterListener(IAtomListener listener)
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public virtual void OnAfterDeserialize()
		{
		}
	}
}
