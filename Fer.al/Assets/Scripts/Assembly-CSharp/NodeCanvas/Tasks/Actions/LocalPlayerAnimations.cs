using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Player")]
	[Description("Controls for using the local players animations. Should only be used when control has been removed?")]
	public class LocalPlayerAnimations : ActionTask
	{
		public enum EAnimationControlType
		{
			play,
			stop
		}

		public enum EAnimation
		{
			NONE,
			dig
		}

		public BBParameter<EAnimationControlType> animationControlType;

		public BBParameter<EAnimation> animation;

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
