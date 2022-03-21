using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Transform")]
	[Description("Stores a transforms position to a blackboard variable")]
	public class GetTransformPosition : ActionTask<Transform>
	{
		[BlackboardOnly]
		public BBParameter<Vector3> savePosition;

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
