using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/GameObject")]
	[Description("Set multiple game objects active or inactive")]
	public class SetGameObjectsActive : ActionTask
	{
		public BBParameter<GameObject[]> gameObjects;

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
