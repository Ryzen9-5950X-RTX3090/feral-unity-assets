using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Player")]
	[Description("Set Player Camera Mode")]
	public class SetCameraMode : ActionTask
	{
		public PlayerCameraMode cameraMode;

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
