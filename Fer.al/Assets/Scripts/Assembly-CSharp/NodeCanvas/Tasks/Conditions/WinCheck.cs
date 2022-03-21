using NodeCanvas.Framework;
using ParadoxNotion.Design;
using World_Challenge;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("WildWorks/WorldChallenge")]
	[Description("Is the Parlor game in a win state")]
	public class WinCheck : ConditionTask<WorldChallenge>
	{
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
