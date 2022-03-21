using System;
using UnityEngine;

namespace UnityAtoms
{
	[EditorIcon("atom-icon-sand")]
	public abstract class AtomFunction<R, T1> : BaseAtom
	{
		[HideInInspector]
		public Func<T1, R> Func;

		public virtual R Call(T1 t1)
		{
			return (R)null;
		}

		public AtomFunction<R, T1> SetFunc(Func<T1, R> func)
		{
			return null;
		}
	}
}
