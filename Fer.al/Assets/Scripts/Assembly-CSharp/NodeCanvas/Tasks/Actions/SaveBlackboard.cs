using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("â\u009c« Blackboard")]
	[Description("Saves the blackboard variables in the provided key and to be loaded later on")]
	public class SaveBlackboard : ActionTask<Blackboard>
	{
		[RequiredField]
		public BBParameter<string> saveKey;

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
