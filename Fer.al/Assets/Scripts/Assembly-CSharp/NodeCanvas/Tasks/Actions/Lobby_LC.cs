using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/LobbyCommands/Messages")]
	[Description("Send a network message")]
	public class Lobby_LC : ActionTask
	{
		[RequiredField]
		public LobbyManager.ELobbyType lobbyType;

		[Tooltip("Leave empty for quest room type, fill in with e.g. minigame def id for minigame lobbies or other def ids for other lobbies.")]
		public string associatedDefId;

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
	}
}
