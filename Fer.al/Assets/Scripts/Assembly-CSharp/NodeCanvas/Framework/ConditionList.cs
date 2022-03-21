using System.Collections.Generic;
using ParadoxNotion.Design;

namespace NodeCanvas.Framework
{
	[DoNotList]
	public class ConditionList : ConditionTask
	{
		public enum ConditionsCheckMode
		{
			AllTrueRequired,
			AnyTrueSuffice
		}

		public ConditionsCheckMode checkMode;

		public List<ConditionTask> conditions;

		private bool allTrueRequired
		{
			get
			{
				return default(bool);
			}
		}

		protected override string info
		{
			get
			{
				return null;
			}
		}

		public override Task Duplicate(ITaskSystem newOwnerSystem)
		{
			return null;
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override bool OnCheck()
		{
			return default(bool);
		}

		public override void OnDrawGizmosSelected()
		{
		}

		public void AddCondition(ConditionTask condition)
		{
		}

		internal override string GetWarningOrError()
		{
			return null;
		}
	}
}
