using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace NodeCanvas.DialogueTrees.UI.Examples
{
	public class DialogueUGUI : ManagedBehaviour
	{
		[Serializable]
		public class SubtitleDelays
		{
			public float characterDelay;

			public float sentenceDelay;

			public float commaDelay;

			public float finalDelay;
		}

		[Header("Input Options")]
		public bool skipOnInput;

		public bool waitForInput;

		[Header("Subtitles")]
		public RectTransform subtitlesGroup;

		public Text actorSpeech;

		public Text actorName;

		public Image actorPortrait;

		public RectTransform waitInputIndicator;

		public SubtitleDelays subtitleDelays;

		public List<AudioClip> typingSounds;

		[Header("Multiple Choice")]
		public RectTransform optionsGroup;

		public Button optionButton;

		private Dictionary<Button, int> cachedButtons;

		private Vector2 originalSubsPosition;

		private bool isWaitingChoice;

		private AudioSource _localSource;

		private AudioSource localSource
		{
			get
			{
				return null;
			}
		}

		public override void MOnEnable()
		{
		}

		public override void MOnDisable()
		{
		}

		public override void MStart()
		{
		}

		private void OnDialogueStarted(DialogueTree dlg)
		{
		}

		private void OnDialoguePaused(DialogueTree dlg)
		{
		}

		private void OnDialogueFinished(DialogueTree dlg)
		{
		}

		private void OnSubtitlesRequest(SubtitlesRequestInfo info)
		{
		}

		[IteratorStateMachine(typeof(<Internal_OnSubtitlesRequestInfo>d__25))]
		private IEnumerator Internal_OnSubtitlesRequestInfo(SubtitlesRequestInfo info)
		{
			return null;
		}

		private void PlayTypeSound()
		{
		}

		[IteratorStateMachine(typeof(<CheckInput>d__27))]
		private IEnumerator CheckInput(Action Do)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<DelayPrint>d__28))]
		private IEnumerator DelayPrint(float time)
		{
			return null;
		}

		private void OnMultipleChoiceRequest(MultipleChoiceRequestInfo info)
		{
		}

		[IteratorStateMachine(typeof(<CountDown>d__30))]
		private IEnumerator CountDown(MultipleChoiceRequestInfo info)
		{
			return null;
		}

		private void Finalize(MultipleChoiceRequestInfo info, int index)
		{
		}

		private void SetMassAlpha(RectTransform root, float alpha)
		{
		}
	}
}
