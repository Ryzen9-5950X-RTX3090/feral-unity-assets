using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/NPC")]
	[Description("Controls for using an animator for a NPC. Stop returns to idle")]
	public class NPCAnimations : ActionTask<ActorNPCSpawner>
	{
		public enum EAnimationControlType
		{
			play,
			stop
		}

		public EAnimationControlType animationControlType;

		[ShowIf("animationControlType", 0)]
		public AnimatorSetter.EActions actionId;

		public BBParameter<bool> disableFaceLocalPlayer;

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
