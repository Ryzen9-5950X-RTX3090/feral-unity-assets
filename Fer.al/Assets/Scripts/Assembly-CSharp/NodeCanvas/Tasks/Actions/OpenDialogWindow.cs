using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/UI")]
	[Description("Open Dialog Window")]
	public class OpenDialogWindow : ActionTask
	{
		public enum EActorDisplayType
		{
			Custom,
			Parent,
			OtherActor,
			Thought
		}

		public bool queueWindow;

		public EActorDisplayType actorDisplayType;

		[ShowIf("actorDisplayType", 0)]
		public BBParameter<string> npcLocalizedNameDefId;

		[ShowIf("actorDisplayType", 0)]
		public BBParameter<string> npcImageDefId;

		[ShowIf("actorDisplayType", 2)]
		public BBParameter<ActorNPCSpawner> actorNPCSpawner;

		private string _localizedNameDefId;

		private string _imageDefId;

		private const string placholderImg = "178";

		private const string thoughtLocID = "1326";

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

		private void GetIDs(ActorNPCSpawner inSpawner)
		{
		}
	}
}
