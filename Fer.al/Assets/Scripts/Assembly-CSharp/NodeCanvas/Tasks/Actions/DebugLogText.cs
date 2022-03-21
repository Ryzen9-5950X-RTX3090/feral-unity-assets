using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Name("Debug Log", 0)]
	[Category("â\u009c« Utility")]
	[Description("Display a UI label on the agent's position if seconds to run is not 0 and also logs the message, which can also be mapped to any variable.")]
	public class DebugLogText : ActionTask<Transform>
	{
		public enum LogMode
		{
			Log,
			Warning,
			Error
		}

		public enum VerboseMode
		{
			LogAndDisplayLabel,
			LogOnly,
			DisplayLabelOnly
		}

		[RequiredField]
		public BBParameter<string> log;

		public float labelYOffset;

		public float secondsToRun;

		public VerboseMode verboseMode;

		public LogMode logMode;

		public CompactStatus finishStatus;

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

		protected override void OnStop()
		{
		}

		protected override void OnUpdate()
		{
		}

		private void OnGUI()
		{
		}
	}
}
