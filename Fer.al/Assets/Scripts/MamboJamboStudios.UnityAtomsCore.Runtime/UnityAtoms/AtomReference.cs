using UnityEngine;

namespace UnityAtoms
{
	public abstract class AtomReference
	{
		public enum Usage
		{
			Value,
			Constant,
			Variable
		}

		[SerializeField]
		protected Usage _usage;
	}
}
