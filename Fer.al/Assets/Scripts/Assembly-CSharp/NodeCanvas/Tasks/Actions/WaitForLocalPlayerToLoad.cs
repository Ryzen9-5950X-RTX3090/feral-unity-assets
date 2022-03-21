using System.Collections;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("â\u009c« Utility")]
	[Description("Wait For Local Player To Load")]
	public class WaitForLocalPlayerToLoad : ActionTask
	{
		public float failTimeout;

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

		[IteratorStateMachine(typeof(<DoWait>d__4))]
		private IEnumerator DoWait()
		{
			return null;
		}
	}
}
