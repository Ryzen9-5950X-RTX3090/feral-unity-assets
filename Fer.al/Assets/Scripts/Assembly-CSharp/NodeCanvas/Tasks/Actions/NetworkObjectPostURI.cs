using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Network")]
	[Description("Server script - Post a URI message on the server")]
	public class NetworkObjectPostURI : NetworkActionTask
	{
		public enum EURIMessageType
		{
			QUEST_START,
			TUTORIAL_INTRO_CINEMATIC_COMPLETE,
			TUTORIAL_CUSTOMIZATION_COMPLETE,
			TUTORIAL_COMPLETE
		}

		public EURIMessageType messageType;

		protected override string info
		{
			get
			{
				return null;
			}
		}
	}
}
