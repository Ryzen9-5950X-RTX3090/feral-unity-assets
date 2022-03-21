using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-purple")]
	public class IncrementIntVariable : VoidAction
	{
		[SerializeField]
		private IntVariable _variable;

		public override void Do()
		{
		}
	}
}
