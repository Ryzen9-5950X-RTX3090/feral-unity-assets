using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("â\u009c« Utility")]
	[Description("Return true or false based on the probability settings. Outcome is calculated EACH time this is checked")]
	public class Probability : ConditionTask
	{
		public BBParameter<float> probability;

		public BBParameter<float> maxValue;

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
