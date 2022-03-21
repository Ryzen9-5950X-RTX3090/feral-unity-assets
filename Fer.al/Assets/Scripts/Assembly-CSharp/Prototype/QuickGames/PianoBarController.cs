using System.Collections.Generic;
using UnityEngine;

namespace Prototype.QuickGames
{
	public class PianoBarController : MonoBehaviour
	{
		public GameObject pianoBeatPrefab;

		private PianoSong.Bar bar;

		private PianoRollController parentController;

		private List<PianoNoteController> noteControllers;

		public void SetUp(PianoSong.Bar bar, PianoRollController parentController)
		{
		}

		public void AddNotes()
		{
		}
	}
}
