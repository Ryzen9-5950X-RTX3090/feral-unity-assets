using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames
{
	public class PianoController : QuickGamesBase
	{
		public List<PianoKeyController> keys;

		public PianoRollController pianoRollController;

		public PianoKeyboardController keyboardController;

		private PianoSong song;

		private bool isPlaying;

		private int score;

		private Text scoreText;

		private Text popupText;

		private Color popupStartColor;

		private Color popupEndColor;

		private float popupTime;

		private float elapsedPopupTime;

		private bool showingPopup;

		private bool popupChanged;

		private IEnumerator popupCoroutine;

		private int targetScore;

		private Rect meterRect;

		private RectTransform meterLevelRectTransform;

		private string[] popupMessages;

		public override void MStart()
		{
		}

		private void Initialize()
		{
		}

		[IteratorStateMachine(typeof(<StartSong>d__20))]
		private IEnumerator StartSong()
		{
			return null;
		}

		private PianoSong CreateSong()
		{
			return null;
		}

		public void NoteSuccess(int quality)
		{
		}

		public void NoteFailure()
		{
		}

		public float GetNoteX(PianoSong.Note note)
		{
			return default(float);
		}

		public override void QuickGameUpdate()
		{
		}

		[IteratorStateMachine(typeof(<ShowResults>d__27))]
		public override IEnumerator ShowResults()
		{
			return null;
		}

		private void UpdateUI()
		{
		}

		private void PopupMessage(string message)
		{
		}

		[IteratorStateMachine(typeof(<FadePopupMessage>d__30))]
		private IEnumerator FadePopupMessage()
		{
			return null;
		}
	}
}
