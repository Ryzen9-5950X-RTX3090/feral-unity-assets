using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks")]
	[Description("Broadcasts a SocialExpanseStartup message. This should happen in the Startup of a social expanse scene, before fading in.")]
	public class SendSocialExpanseStartupMessage : ActionTask
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

		private void SendStartupMessage()
		{
		}
	}
}
