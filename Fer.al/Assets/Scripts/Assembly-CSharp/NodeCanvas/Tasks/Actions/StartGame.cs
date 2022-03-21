using NodeCanvas.Framework;
using ParadoxNotion.Design;
using World_Challenge;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/WorldChallenge")]
	[Description("Start a world challenge")]
	public class StartGame : ActionTask<WorldChallenge>
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

		internal void GameOver()
		{
		}
	}
}
