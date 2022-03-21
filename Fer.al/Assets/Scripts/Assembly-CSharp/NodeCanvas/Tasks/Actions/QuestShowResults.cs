using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Quest")]
	[Description("Show quest results screen.")]
	public class QuestShowResults : ActionTask
	{
		private bool _init;

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

		internal void Return(bool inLeave)
		{
		}
	}
}
