using System.Collections.Generic;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Transform")]
	[Description("Picks a Transform from a specified list.")]
	public class SelectTransformFromList : ActionTask
	{
		public enum SelectType
		{
			IndexBased,
			Random
		}

		public List<Transform> transforms;

		public SelectType selectType;

		[ShowIf("selectType", 0)]
		public BBParameter<int> index;

		public BBParameter<Transform> result;

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
