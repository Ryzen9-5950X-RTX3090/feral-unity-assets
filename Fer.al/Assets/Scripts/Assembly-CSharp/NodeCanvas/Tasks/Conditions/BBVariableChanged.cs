using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	[Name("On Variable Changed", 0)]
	[Category("â\u009c« Blackboard")]
	public class BBVariableChanged : ConditionTask
	{
		[BlackboardOnly]
		public BBObjectParameter targetVariable;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override string OnInit()
		{
			return null;
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override bool OnCheck()
		{
			return default(bool);
		}

		private void OnValueChanged(object varValue)
		{
		}
	}
}
