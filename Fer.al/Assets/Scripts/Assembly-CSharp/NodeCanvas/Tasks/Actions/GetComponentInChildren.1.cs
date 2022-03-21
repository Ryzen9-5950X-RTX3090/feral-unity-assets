using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/GameObject")]
	[Description("Gets a component in children of specified transform")]
	public class GetComponentInChildren<T> : ActionTask<Transform> where T : Component
	{
		[BlackboardOnly]
		public BBParameter<T> saveAs;

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
