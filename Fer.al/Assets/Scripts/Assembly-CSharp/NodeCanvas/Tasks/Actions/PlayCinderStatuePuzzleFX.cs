using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/WorldChallenge/Puzzle")]
	[Description("Plays or stops RingStatuePuzzle cinder handAttack fx")]
	public class PlayCinderStatuePuzzleFX : ActionTask
	{
		public BBParameter<QuestCinder> questCinder;

		public BBParameter<bool> start;

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
