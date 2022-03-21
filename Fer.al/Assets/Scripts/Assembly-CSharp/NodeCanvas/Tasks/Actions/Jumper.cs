using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Control")]
	[Color("00b9e8")]
	[Name("JUMP", 0)]
	[Icon("Set", false, "")]
	public class Jumper : ActionTask
	{
		private string _priorTag;

		public BBParameter<string> tag;

		private object _sourceNode;

		private Node sourceNode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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
