using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace WW.Debug
{
	public class DebugLogPopup : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
	{
		private RectTransform popupTransform;

		private Vector2 halfSize;

		private Image backgroundImage;

		private CanvasGroup canvasGroup;

		[SerializeField]
		private DebugConsoleWindow _console;

		[SerializeField]
		private Text newInfoCountText;

		[SerializeField]
		private Text newWarningCountText;

		[SerializeField]
		private Text newErrorCountText;

		[SerializeField]
		private TextMeshProUGUI _fpsText;

		private int newInfoCount;

		private int newWarningCount;

		private int newErrorCount;

		private Color normalColor;

		[SerializeField]
		private Color alertColorInfo;

		[SerializeField]
		private Color alertColorWarning;

		[SerializeField]
		private Color alertColorError;

		private bool isPopupBeingDragged;

		private IEnumerator moveToPosCoroutine;

		private float _fpsUpdateInterval;

		private float _fps;

		private float _fpsAccumulator;

		private int _fpsFrames;

		private float _fpsTimeleft;

		private float _fpsMin;

		private float _fpsMax;

		private float _lastFPS;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void OnViewportDimensionsChanged()
		{
		}

		public void NewInfoLogArrived()
		{
		}

		public void NewWarningLogArrived()
		{
		}

		public void NewErrorLogArrived()
		{
		}

		private void Reset()
		{
		}

		[IteratorStateMachine(typeof(<MoveToPosAnimation>d__33))]
		private IEnumerator MoveToPosAnimation(Vector3 targetPos)
		{
			return null;
		}

		public void OnPointerClick(PointerEventData data)
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public void OnBeginDrag(PointerEventData data)
		{
		}

		public void OnDrag(PointerEventData data)
		{
		}

		public void OnEndDrag(PointerEventData data)
		{
		}

		private void UpdateFPS()
		{
		}
	}
}
