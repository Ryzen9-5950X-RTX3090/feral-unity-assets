using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("â\u009c« Utility")]
	[Description("Check if an event is received and return true for one frame")]
	public class CheckEvent : ConditionTask<GraphOwner>
	{
		[RequiredField]
		public BBParameter<string> eventName;

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

		protected override bool OnCheck()
		{
			return default(bool);
		}

		private void OnCustomEvent(string eventName, IEventData data)
		{
		}
	}
}
