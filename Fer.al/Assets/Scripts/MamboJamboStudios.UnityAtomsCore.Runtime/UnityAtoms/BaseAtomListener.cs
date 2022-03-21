using UnityEngine;

namespace UnityAtoms
{
	public abstract class BaseAtomListener : MonoBehaviour
	{
		[SerializeField]
		[Multiline]
		private string _developerDescription;
	}
}
