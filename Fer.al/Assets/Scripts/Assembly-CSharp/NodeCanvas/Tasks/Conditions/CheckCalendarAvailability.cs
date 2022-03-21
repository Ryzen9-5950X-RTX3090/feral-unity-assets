using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("WildWorks/CalendarAvailability")]
	[Description("Check Calendar Availability")]
	public class CheckCalendarAvailability : ConditionTask
	{
		public string calendarName;

		public string calendarDefId;

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
