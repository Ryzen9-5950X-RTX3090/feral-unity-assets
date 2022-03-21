using System;
using UnityEngine;

namespace UnityAtoms
{
	[EditorIcon("atom-icon-sand")]
	public abstract class AtomFunction<R, T1, T2, T3, T4> : BaseAtom
	{
		[HideInInspector]
		public Func<T1, T2, T3, T4, R> Func;

		public virtual R Call(T1 t1, T2 t2, T3 t3, T4 t4)
		{
			return (R)null;
		}

		public AtomFunction<R, T1, T2, T3, T4> SetFunc(Func<T1, T2, T3, T4, R> func)
		{
			return null;
		}
	}
}
