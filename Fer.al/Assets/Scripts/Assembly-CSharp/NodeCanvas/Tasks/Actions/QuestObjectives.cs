using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Quest")]
	[Description("Server script - Handle quest objectives. Make sure the task index is correct in the selected objective in the charts. Note: Final objectives do not show up here since they have no tasks.")]
	public class QuestObjectives : NetworkActionTask
	{
		public enum EObjectiveAction
		{
			UpdateTask,
			GiveObjective
		}

		public EObjectiveAction objectiveAction;

		[Space]
		[Space(6f)]
		[RootSelectorCompact("Quest Chart ID", "QuestChartData", null, false, false)]
		public string questChartID;

		public int questObjectiveListIndex;

		public int objectiveIndex;

		public int taskIndex;

		public QuestManager.EGiveObjectiveResetMode resetMode;

		protected override string info
		{
			get
			{
				return null;
			}
		}
	}
}
