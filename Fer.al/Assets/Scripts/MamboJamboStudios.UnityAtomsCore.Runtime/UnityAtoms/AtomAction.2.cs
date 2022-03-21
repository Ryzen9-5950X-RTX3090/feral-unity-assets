using System;
using UnityEngine;

namespace UnityAtoms
{
	public abstract class AtomAction<T1, T2> : AtomAction
	{
		[HideInInspector]
		public Action<T1, T2> Action;

		public virtual void Do(T1 t1, T2 t2)
		{
		}
	}
}
