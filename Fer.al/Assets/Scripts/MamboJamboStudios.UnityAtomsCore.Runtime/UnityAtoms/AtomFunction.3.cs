using System;
using UnityEngine;

namespace UnityAtoms
{
	[EditorIcon("atom-icon-sand")]
	public abstract class AtomFunction<R, T1, T2> : BaseAtom
	{
		[HideInInspector]
		public Func<T1, T2, R> Func;

		public virtual R Call(T1 t1, T2 t2)
		{
			return (R)null;
		}

		public AtomFunction<R, T1, T2> SetFunc(Func<T1, T2, R> func)
		{
			return null;
		}
	}
}
