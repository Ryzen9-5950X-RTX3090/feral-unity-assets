using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("â\u009c« Utility")]
	[Description("Will return true after a specific amount of time has passed and false while still counting down")]
	public class Timeout : ConditionTask
	{
		public BBParameter<float> timeout;

		private float currentTime;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void MoveNext()
		{
		}

		protected override bool OnCheck()
		{
			return default(bool);
		}
	}
}
