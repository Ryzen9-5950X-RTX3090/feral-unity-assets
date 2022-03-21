using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Quest")]
	[Description("Adds or removes a QuestIcon to the local player")]
	public class QuestIconAddRemove : ActionTask
	{
		public enum EIconActionType
		{
			Attach,
			Remove
		}

		public EIconActionType iconActionType;

		[ShowIf("iconActionType", 0)]
		public QuestIcon questIconPrefab;

		[ShowIf("iconActionType", 0)]
		public string imageDefId;

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

		private void RemoveAllIcons()
		{
		}
	}
}
