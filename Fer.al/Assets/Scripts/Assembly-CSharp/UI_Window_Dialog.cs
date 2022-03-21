using System;
using DG.DeInspektor.Attributes;
using DG.Tweening;
using NodeCanvas.DialogueTrees;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WW.TextAnimation;

public class UI_Window_Dialog : UI_Window
{
	[Serializable]
	public class DialogOption
	{
		public CanvasGroup group;

		public WWTextMeshProUGUI text;

		public LayoutElement layoutElement;
	}

	[Serializable]
	public class SubtitleDelays
	{
		public float characterDelay;

		public float sentenceDelay;

		public float commaDelay;

		public float finalDelay;
	}

	[SerializeField]
	private WWSmoothContentSizeFitter _smoothContentSizeFitter;

	[SerializeField]
	private float _tweenTime;

	[SerializeField]
	private FeralAudioInfo _showDialogueSound;

	[SerializeField]
	private UI_TextAnimator _textAnimator;

	private AudioSource _localSource;

	public CanvasGroup nextButton;

	public GameObject nextScrim;

	public WWImage imageNfcIcon;

	private string _npcImageDefId;

	public WWTextMeshProUGUI dialogText;

	public WWTextMeshProUGUI dialogTextForCalculation;

	public WWTextMeshProUGUI npcNameText;

	[SerializeField]
	private GameObject _dialogGroup;

	[SerializeField]
	private GameObject _choiceGroup;

	[SerializeField]
	private CanvasGroup _nameBarGroup;

	public DialogOption[] dialogOptions;

	private SubtitleDelays _subtitleDelays;

	private MultipleChoiceRequestInfo _choiceRequestInfo;

	private bool _isRemovingOldDialogue;

	private bool _textIsAnimating;

	private bool _windowIsFresh;

	private bool _hasDialogue;

	private bool _hasChoices;

	private bool _isThought;

	private bool _isNarration;

	private bool _allowNextScrim;

	private bool _allowNextButton;

	private bool _optionClicked;

	private Transform _actorDialoging;

	[SerializeField]
	private float _visibleCharacters;

	private int _flip;

	private string _lastParse;

	private AudioSource localSource
	{
		get
		{
			return null;
		}
	}

	public float VisibleCharacters
	{
		get
		{
			return default(float);
		}
		private set
		{
		}
	}

	public static bool IsInstantiatedAndOpen
	{
		get
		{
			return default(bool);
		}
	}

	public static void CloseWindow()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnOpenComplete()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public void Setup(string inNPCLocalizedNameDefId, string inNPCImageDefId, Transform inActorDialoging, bool inIsShopMode = false)
	{
	}

	private void OnMultipleChoiceRequest(MultipleChoiceRequestInfo inInfo)
	{
	}

	private void SetDialogText(string inString)
	{
	}

	private Sequence ShowDialogue()
	{
		return null;
	}

	private Sequence FadeInText(string inText)
	{
		return null;
	}

	private Sequence ShowOptions()
	{
		return null;
	}

	public void BtnClicked_NextDialog()
	{
	}

	public void BtnClicked_DialogOption(int inIdx)
	{
	}

	public void NextButtonActive(bool inActive)
	{
	}

	private void SkipTextFade()
	{
	}

	private void SetImage(string inNpcImageDefID)
	{
	}

	private void Update()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	private void Flip()
	{
	}

	private void RefreshFlip()
	{
	}
}
