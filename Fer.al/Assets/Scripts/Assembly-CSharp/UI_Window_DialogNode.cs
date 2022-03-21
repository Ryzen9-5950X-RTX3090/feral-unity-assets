using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NodeCanvas.DialogueTrees;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_DialogNode : UI_Window
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

	private SubtitleDelays subtitleDelays;

	public List<AudioClip> typingSounds;

	[Header("Multiple Choice")]
	public RectTransform optionsGroup;

	public Button optionButton;

	private Dictionary<Button, int> cachedButtons;

	private Vector3 originalSubsPosition;

	private bool isWaitingChoice;

	private AudioSource _localSource;

	private bool _hideHud;

	private bool _removeControl;

	private AudioSource localSource
	{
		get
		{
			return null;
		}
	}

	public static void Open(bool inHideHud, bool inRemoveControl, SubtitleDelays inSubtitleDelays, Action<UI_Window_DialogNode> callback)
	{
	}

	[IteratorStateMachine(typeof(<OpenCoroutine>d__21))]
	private static IEnumerator OpenCoroutine(bool inHideHud, bool inRemoveControl, SubtitleDelays inSubtitleDelays, Action<UI_Window_DialogNode> callback)
	{
		return null;
	}

	public new static void Close(bool inAnimate = false)
	{
	}

	public void Init(bool inHideHud, bool inRemoveControl, SubtitleDelays inSubtitleDelays)
	{
	}

	private void Subscribe()
	{
	}

	private void Unsubscribe()
	{
	}

	public override void MOnDestroy()
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

	[IteratorStateMachine(typeof(<Internal_OnSubtitlesRequestInfo>d__32))]
	private IEnumerator Internal_OnSubtitlesRequestInfo(SubtitlesRequestInfo info)
	{
		return null;
	}

	private void PlayTypeSound()
	{
	}

	[IteratorStateMachine(typeof(<CheckInput>d__34))]
	private IEnumerator CheckInput(Action Do)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<DelayPrint>d__35))]
	private IEnumerator DelayPrint(float time)
	{
		return null;
	}

	private void OnMultipleChoiceRequest(MultipleChoiceRequestInfo info)
	{
	}

	[IteratorStateMachine(typeof(<CountDown>d__37))]
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
