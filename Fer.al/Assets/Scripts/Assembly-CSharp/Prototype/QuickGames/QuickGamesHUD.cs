using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames
{
	public class QuickGamesHUD : ManagedBehaviour
	{
		private QuickGamesBase _game;

		private GameObject bg;

		private GameObject fg;

		public GameObject quickGamesRootPrefab;

		public GameObject quickGamesRoot
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Camera quickGamesCamera
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public override void UAwake()
		{
		}

		public void Init(QuickGamesBase inGame)
		{
		}

		private void MakeResults(QuickGamesBase.QuickGameReward inReward, RawImage inImageResult, WWTextMeshProUGUI inTextResult)
		{
		}

		public void ShowResults(List<QuickGamesBase.QuickGameReward> inRewards)
		{
		}

		public void BtnClicked_Close()
		{
		}
	}
}
