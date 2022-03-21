using NodeCanvas.Framework;
using ParadoxNotion.Design;
using World_Challenge.World_Puzzle;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/WorldChallenge/Puzzle")]
	[Description("Plays RingStatuePuzzle solved fx")]
	public class PlaySolvedStatuePuzzleFX : ActionTask
	{
		public BBParameter<RingStatuePuzzle> ringStatuePuzzle;

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
