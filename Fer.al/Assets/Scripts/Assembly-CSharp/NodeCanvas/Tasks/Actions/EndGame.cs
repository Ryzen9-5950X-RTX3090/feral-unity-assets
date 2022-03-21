using NodeCanvas.Framework;
using ParadoxNotion.Design;
using World_Challenge;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/WorldChallenge")]
	[Description("End a world challenge. Destroys any gameobject loaded in the Initialize game.")]
	public class EndGame : ActionTask<WorldChallenge>
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
