using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/GameObject")]
	[Description("Set game object active or inactive. Same thing as 'GameObject -> Set Visibility'")]
	public class SetGameObjectActive : ActionTask
	{
		public BBParameter<GameObject> gameObject;

		public BBParameter<bool> setActive;

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
