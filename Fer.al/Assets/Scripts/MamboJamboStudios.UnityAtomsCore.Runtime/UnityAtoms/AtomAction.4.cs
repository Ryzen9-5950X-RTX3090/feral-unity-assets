using System;
using UnityEngine;

namespace UnityAtoms
{
	public abstract class AtomAction<T1, T2, T3, T4> : AtomAction
	{
		[HideInInspector]
		public Action<T1, T2, T3, T4> Action;

		public virtual void Do(T1 t1, T2 t2, T3 t3, T4 t4)
		{
		}
	}
}
