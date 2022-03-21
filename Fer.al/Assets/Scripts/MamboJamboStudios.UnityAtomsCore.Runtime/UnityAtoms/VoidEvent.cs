using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-cherry")]
	public sealed class VoidEvent : AtomEvent<Void>
	{
		public void Raise()
		{
		}
	}
}
