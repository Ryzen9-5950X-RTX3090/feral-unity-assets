using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-purple")]
	public class SetIntVariableIfHigher : VoidAction
	{
		[SerializeField]
		private IntVariable _currentIntVariable;

		[SerializeField]
		private IntVariable _highestIntVariable;

		public override void Do()
		{
		}
	}
}
