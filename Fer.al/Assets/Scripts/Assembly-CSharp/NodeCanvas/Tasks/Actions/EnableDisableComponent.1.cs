using System.Collections.Generic;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/GameObject")]
	[Description("Set component enabled or disabled")]
	public class EnableDisableComponent<T> : ActionTask<Transform> where T : Behaviour
	{
		public enum EActionObjects
		{
			single,
			multiple
		}

		public BBParameter<bool> includeChildTransforms;

		public BBParameter<bool> enable;

		public BBParameter<bool> searchParents;

		public EActionObjects actionObjects;

		[ShowIf("actionObjects", 1)]
		public List<BBParameter<Transform>> transforms;

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

		private void DoIt(Transform inT)
		{
		}

		private void EnableOrDisable(T[] inT)
		{
		}
	}
}
