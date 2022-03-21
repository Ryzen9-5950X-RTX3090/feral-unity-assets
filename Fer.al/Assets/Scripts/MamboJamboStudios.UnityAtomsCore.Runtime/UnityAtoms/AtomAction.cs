using System;
using UnityEngine;

namespace UnityAtoms
{
	public abstract class AtomAction : BaseAtom
	{
		[HideInInspector]
		public Action ActionNoValue;

		public virtual void Do()
		{
		}
	}
}
