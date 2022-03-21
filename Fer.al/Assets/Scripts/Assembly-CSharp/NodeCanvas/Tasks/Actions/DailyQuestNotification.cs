using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Quest")]
	[Description("Daily Quest Notification")]
	public class DailyQuestNotification : NetworkActionTask<Blackboard>
	{
		public enum ENotificationType
		{
			Start,
			Complete,
			Progress,
			BasicNotification
		}

		public ENotificationType notificationType;

		public Statement questPrefix;

		public Statement questStarted;

		public Statement questCompleted;

		public Statement questName;

		public Statement progress;

		public Statement basicNotification;

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
