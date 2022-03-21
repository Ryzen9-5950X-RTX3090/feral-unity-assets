using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("â\u009c« Blackboard")]
	public class SetEnum : ActionTask
	{
		[BlackboardOnly]
		[RequiredField]
		public BBObjectParameter valueA;

		public BBObjectParameter valueB;

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
