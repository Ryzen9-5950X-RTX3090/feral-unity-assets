using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/GameObject")]
	[Description("Destroys Multiple GameObjects")]
	public class DestroyMultipleGameObjects : ActionTask
	{
		[Tooltip("DestroyImmediately is recomended if you are destroying objects in use of the framework.")]
		public bool immediately;

		public BBParameter<GameObject[]> gameObjects;

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
