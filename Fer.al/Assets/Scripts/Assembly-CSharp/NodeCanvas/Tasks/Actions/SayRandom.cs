using System.Collections.Generic;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("Dialogue")]
	[Icon("Dialogue", false, "")]
	[Description("A random statement will be chosen each time for the actor to say")]
	public class SayRandom : ActionTask<IDialogueActor>
	{
		public List<Statement> statements;

		public bool allowNextButton;

		protected override void OnExecute()
		{
		}
	}
}
