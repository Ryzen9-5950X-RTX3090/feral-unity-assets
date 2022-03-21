using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/UI")]
	public class RevealEnigma : ActionTask
	{
		public bool reveal;

		public bool waitToContinue;

		public UI_Window_RevealEnigma.EnigmaType enigmaType;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnExecute()
		{
		}
	}
}
