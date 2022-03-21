using NodeCanvas.Framework;
using ParadoxNotion.Design;
using World_Challenge;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/WorldChallenge/Puzzle")]
	[Description("Start a world puzzle")]
	public class StartPuzzle : ActionTask
	{
		public BBParameter<bool> success;

		public BBParameter<bool> endPan;

		public BBParameter<WorldPuzzle> worldPuzzle;

		public BBParameter<bool> waitToContinue;

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

		internal void GameOver(bool completed)
		{
		}
	}
}
