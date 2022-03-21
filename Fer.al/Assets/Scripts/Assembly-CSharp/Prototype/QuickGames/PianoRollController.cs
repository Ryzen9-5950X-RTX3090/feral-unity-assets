using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames
{
	public class PianoRollController : MonoBehaviour
	{
		public GameObject pianoNotePrefab;

		public GameObject pianoBarPrefab;

		private PianoSong song;

		private PianoController parentController;

		private List<PianoBarController> bars;

		private List<PianoNoteController> notes;

		private Rigidbody2D body;

		public float BeatHeight
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float BarHeight
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void SetUp(PianoSong song, PianoController parentController)
		{
		}

		private void Create()
		{
		}

		public void QuickGameUpdate()
		{
		}

		public Vector2 GetNotePosition(PianoSong.Note note)
		{
			return default(Vector2);
		}
	}
}
