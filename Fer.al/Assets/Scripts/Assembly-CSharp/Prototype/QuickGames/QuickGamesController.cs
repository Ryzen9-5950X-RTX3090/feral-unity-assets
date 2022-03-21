using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames
{
	public class QuickGamesController : NPCInteract
	{
		private class TmpGame : MonoBehaviour
		{
			internal QuickGamesController Controller;

			private void OnDestroy()
			{
			}
		}

		[Header("QuickGamesController")]
		public Transform canvas;

		public Transform list;

		public Button button;

		public QuickGamesBase[] quickGames;

		public override void MStart()
		{
		}

		public override void PlayAudioAndFX()
		{
		}

		public void ButtonClicked()
		{
		}

		private void GameOver()
		{
		}
	}
}
