using System;
using UnityEngine;

namespace UnityAtoms
{
	[EditorIcon("atom-icon-sand")]
	public abstract class AtomFunction<R> : BaseAtom
	{
		[HideInInspector]
		public Func<R> Func;

		public virtual R Call()
		{
			return (R)null;
		}

		public AtomFunction<R> SetFunc(Func<R> func)
		{
			return null;
		}
	}
}
