using System;
using UnityEngine;

namespace UnityAtoms
{
	public abstract class AtomAction<T1> : AtomAction
	{
		[HideInInspector]
		public Action<T1> Action;

		public virtual void Do(T1 t1)
		{
		}
	}
}
