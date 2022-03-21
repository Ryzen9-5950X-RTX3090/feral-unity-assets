using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Tutorial")]
	[Description("Sets the player's avatar type.")]
	public class SetAvatar : NetworkActionTask
	{
		public string classID;

		protected override void OnExecute()
		{
		}
	}
}
