using UnityEngine;

namespace UnityAtoms
{
	public abstract class BaseAtom : ScriptableObject
	{
		[Multiline]
		[SerializeField]
		private string _developerDescription;
	}
}
