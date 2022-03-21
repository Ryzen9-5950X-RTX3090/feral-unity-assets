using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/â\u009c« Blackboard")]
	[Description("Set a blackboard integer variable at random between min and max value to something it wasn't before")]
	public class SetRandomInt : ActionTask
	{
		public BBParameter<int> min;

		public BBParameter<int> max;

		[BlackboardOnly]
		public BBParameter<int> valueA;

		private int _priorInt;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		private int RandomInt()
		{
			return default(int);
		}

		protected override void OnExecute()
		{
		}
	}
}
