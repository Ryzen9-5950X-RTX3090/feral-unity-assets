using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Toboggan")]
	[Description("Plays the toboggan part.")]
	public class PlayToboggan : ActionTask
	{
		public BBParameter<bool> Success;

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

		public void GameOver(bool inWin)
		{
		}
	}
}
