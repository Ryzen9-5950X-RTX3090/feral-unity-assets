using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("â\u009c« Utility")]
	[Description("Send a graph event with T value. If global is true, all graph owners in scene will receive this event. Use along with the 'Check Event' Condition")]
	public class SendEvent<T> : ActionTask<GraphOwner>
	{
		[RequiredField]
		public BBParameter<string> eventName;

		public BBParameter<T> eventValue;

		public BBParameter<float> delay;

		public bool sendGlobal;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnUpdate()
		{
		}
	}
}
