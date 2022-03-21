using NodeCanvas.Framework;
using ParadoxNotion.Design;
using World_Challenge;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/WorldChallenge/Puzzle")]
	[Description("End a world puzzle")]
	public class EndPuzzle : ActionTask
	{
		public BBParameter<WorldPuzzle> worldPuzzle;

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
