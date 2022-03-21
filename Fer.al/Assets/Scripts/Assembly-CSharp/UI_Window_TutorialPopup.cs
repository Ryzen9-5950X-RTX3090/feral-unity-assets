using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_TutorialPopup : UI_Window
{
	private class TutorialPageData
	{
		public string imageDefId;

		private Sprite _sprite;

		public string localizationDefId;

		private string _localizedText;

		public Sprite Sprite
		{
			get
			{
				return null;
			}
		}

		public string LocalizedText
		{
			get
			{
				return null;
			}
		}

		public TutorialPageData(TutorialPageInfo inPageInfo)
		{
		}

		public TutorialPageData(string inImageDefId, string inLocalizationDefId)
		{
		}

		[IteratorStateMachine(typeof(<Init>d__10))]
		public IEnumerator Init(GameObject inReferenceGo)
		{
			return null;
		}
	}

	[SerializeField]
	[Header("Frame Elements")]
	private WWTextMeshProUGUI _headerText;

	[SerializeField]
	private GameObject _footer;

	[SerializeField]
	private UI_TabGroup _tabGroup;

	[SerializeField]
	private WWTextMeshProUGUI _nextBtnText;

	[SerializeField]
	[Header("Page Elements")]
	private CanvasGroup _pageGroup;

	[SerializeField]
	private WWImage _pageImage;

	[SerializeField]
	private WWTextMeshProUGUI _pageText;

	private List<TutorialPageData> _pageDatas;

	private TutorialPageData _currentPageData;

	private QRoutine _setupRoutine;

	private Sequence _pageTransitionSequence;

	public static void OpenWindow(BaseDef inTutorialDef)
	{
	}

	public static void QueueWindow(BaseDef inTutorialDef)
	{
	}

	public static void CloseWindow()
	{
	}

	public void BtnClicked_NextPage()
	{
	}

	protected override void DoDelayedOpenAnimation()
	{
	}

	private void Setup(BaseDef inTutorialDef)
	{
	}

	[IteratorStateMachine(typeof(<SetupPages>d__17))]
	private IEnumerator SetupPages()
	{
		return null;
	}

	private void OnPageSelected(int inPageIndex)
	{
	}

	private void DoPageTransition(TutorialPageData inPageData)
	{
	}

	private void LoadPage(TutorialPageData inPageData)
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public override void MOnDestroy()
	{
	}
}
