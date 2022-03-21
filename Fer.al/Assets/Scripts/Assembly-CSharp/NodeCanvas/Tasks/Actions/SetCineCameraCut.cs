using Cinemachine;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/CineMachine")]
	[Description("Cuts to or from a CinemachineVirtualCamera")]
	public class SetCineCameraCut : ActionTask
	{
		public BBParameter<CinemachineVirtualCamera> cinemachineVirtualCamera;

		public BBParameter<bool> setActive;

		public BBParameter<FeralAudioEmitter> audioEmitter;

		public BBParameter<float> audioDelay;

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

		protected override void OnExecute()
		{
		}
	}
}
