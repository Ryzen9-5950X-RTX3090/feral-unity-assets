using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/GameObject")]
	[Description("Set game object by name active or inactive. Same thing as 'GameObject -> Set Visibility'")]
	public class SetGameObjectActiveByName : ActionTask
	{
		public BBParameter<string> gameObjectName;

		public BBParameter<bool> setActive;

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
