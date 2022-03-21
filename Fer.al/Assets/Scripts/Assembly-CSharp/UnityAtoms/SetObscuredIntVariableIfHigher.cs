using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-purple")]
	public class SetObscuredIntVariableIfHigher : VoidAction
	{
		[SerializeField]
		private ObscuredIntVariable _currentIntVariable;

		[SerializeField]
		private ObscuredIntVariable _highestIntVariable;

		public override void Do()
		{
		}
	}
}
