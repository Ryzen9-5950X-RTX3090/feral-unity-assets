using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	[Name("Is In Transition", 0)]
	[Category("Animator")]
	public class MecanimIsInTransition : ConditionTask<Animator>
	{
		public BBParameter<int> layerIndex;

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
