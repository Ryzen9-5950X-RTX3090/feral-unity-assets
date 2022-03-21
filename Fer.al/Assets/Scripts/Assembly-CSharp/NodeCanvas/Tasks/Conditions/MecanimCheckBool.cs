using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	[Name("Check Parameter Bool", 0)]
	[Category("Animator")]
	public class MecanimCheckBool : ConditionTask<Animator>
	{
		[RequiredField]
		public BBParameter<string> parameter;

		public BBParameter<bool> value;

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
