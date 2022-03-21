using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-purple")]
	public class IncrementObscuredIntVariable : VoidAction
	{
		[SerializeField]
		private ObscuredIntVariable _variable;

		public override void Do()
		{
		}
	}
}
