using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/CachedUserVar")]
	[Description("Set CachedUserVar - !!NEEDS VERIFICATION THAT IT WORKS!!")]
	public class SetCachedUserVar : ActionTask
	{
		public string cachedUserVarName;

		public string cachedUserVarDefId;

		public bool setTrue;

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
