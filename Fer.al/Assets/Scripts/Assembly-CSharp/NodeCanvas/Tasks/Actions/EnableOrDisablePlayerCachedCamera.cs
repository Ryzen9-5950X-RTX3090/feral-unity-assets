using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Player")]
	[Description("Enable Or Disable Player Cached Camera.")]
	public class EnableOrDisablePlayerCachedCamera : ActionTask
	{
		public bool enableCamera;

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
