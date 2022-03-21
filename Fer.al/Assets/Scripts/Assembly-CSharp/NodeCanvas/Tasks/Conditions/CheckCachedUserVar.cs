using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("WildWorks/CachedUserVar")]
	[Description("Check CachedUserVar - !!NEEDS VERIFICATION THAT IT WORKS!!")]
	public class CheckCachedUserVar : ConditionTask
	{
		public string cachedUserVarName;

		public string cachedUserVarDefId;

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
