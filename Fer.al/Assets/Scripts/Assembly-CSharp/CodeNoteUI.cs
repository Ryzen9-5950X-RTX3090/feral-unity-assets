using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class CodeNoteUI : MonoBehaviour
{
	public List<WWImage> code;

	public List<WWImage> hintsMiddle;

	public List<WWImage> hintsTopBottom;

	[EnumList(typeof(CodeColor), 0.35f)]
	public List<Sprite> ingredients;

	public WWImage allWrongImage;

	public WWImage allCorrectImage;

	public GameObject someHintsContainer;

	public GameObject someHintsOkBackground;

	public GameObject someHintsGoodBackground;

	public GameObject allHintsContainer;

	public Sprite correctPlaceHintSprite;

	public Sprite incorrectPlaceHintSprite;

	public Sprite wrongHintSprite;

	public GameObject hintFx_AllWrong;

	public GameObject hintFx_AllRight;

	public GameObject hintFx_SomeCorrectPosition;

	public GameObject hintFx_SomeIncorrectPosition;

	public WWImage separator;

	private GameObject _revealFx;

	private int _revealSfxCounter;

	private CodeAttempt NoteAttempt
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

	public void SetCodeLength(int inLength)
	{
	}

	public void SetNote(CodeAttempt inAttempt)
	{
	}

	public void RevealNotes()
	{
	}

	private void DisableAllHints()
	{
	}

	public void SetSeparatorVisible(bool inVisible)
	{
	}
}
