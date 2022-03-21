using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Prototype.QuickGames;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/WorldChallenge")]
	[Description("Start the Lock Picking Game")]
	public class StartLockpickingQGE : StartGameQGE
	{
		public BBParameter<QGEChestSettings> chestSettings;

		public BBParameter<NetworkedObjectInfo> usePickNetworkObject;

		public BBParameter<bool> autoDestroyGameController;

		private LockPickingController _lockPickingGame;

		protected override void InitializeQuickGame(QuickGamesBase inQuickGame)
		{
		}
	}
}
