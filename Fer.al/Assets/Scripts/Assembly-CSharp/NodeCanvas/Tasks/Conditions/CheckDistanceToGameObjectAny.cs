using System.Collections.Generic;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	[Name("Any Target Within Distance", 0)]
	[Category("GameObject")]
	public class CheckDistanceToGameObjectAny : ConditionTask<Transform>
	{
		public BBParameter<List<GameObject>> targetObjects;

		public CompareMethod checkType;

		public BBParameter<float> distance;

		[SliderField(0f, 0.1f)]
		public float floatingPoint;

		[BlackboardOnly]
		public BBParameter<List<GameObject>> allResults;

		[BlackboardOnly]
		public BBParameter<GameObject> closerResult;

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

		public override void OnDrawGizmosSelected()
		{
		}
	}
}
