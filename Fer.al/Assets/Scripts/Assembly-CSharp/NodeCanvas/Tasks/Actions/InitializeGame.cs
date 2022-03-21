using NodeCanvas.Framework;
using ParadoxNotion.Design;
using World_Challenge;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/WorldChallenge")]
	[Description("Initializes a world challenge")]
	public class InitializeGame : ActionTask<WorldChallenge>
	{
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
