using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/WorldChallenge")]
	[Description("Start a world challenge")]
	public class StartGameDigSpot : ActionTask<SocialExpanseDigSpot>
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
