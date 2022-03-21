using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("â\u009c« Blackboard")]
	public class CheckVectorDistance : ConditionTask
	{
		[BlackboardOnly]
		public BBParameter<Vector3> vectorA;

		[BlackboardOnly]
		public BBParameter<Vector3> vectorB;

		public CompareMethod comparison;

		public BBParameter<float> distance;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override bool OnCheck()
		{
			return default(bool);
		}
	}
}
