using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	[Name("Check Parameter Int", 0)]
	[Category("Animator")]
	public class MecanimCheckInt : ConditionTask<Animator>
	{
		[RequiredField]
		public BBParameter<string> parameter;

		public CompareMethod comparison;

		public BBParameter<int> value;

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
