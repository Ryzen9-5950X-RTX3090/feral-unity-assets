using System.Collections.Generic;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/GameObject")]
	[Description("Removes a component from one or more transforms.")]
	public class RemoveComponents<T> : ActionTask where T : Component
	{
		[Tooltip("DestroyImmediately is recomended if you are destroying objects in use of the framework.")]
		public bool immediately;

		public bool includeChildern;

		public List<BBParameter<Transform>> transforms;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		private void DestroyComponent(T inComponent)
		{
		}

		protected override void OnExecute()
		{
		}
	}
}
