using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GestureRecognizer
{
	public class DrawDetector : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IPointerClickHandler
	{
		public enum DrawDetectorMode
		{
			Touch,
			Controller
		}

		public enum RemoveStrategy
		{
			RemoveOld,
			ClearAll
		}

		[Serializable]
		public class ResultEvent : UnityEvent<RecognitionResult>
		{
		}

		public Recognizer recognizer;

		public UILineRenderer line;

		private List<UILineRenderer> lines;

		[Range(0f, 1f)]
		public float scoreToAccept;

		[Range(1f, 10f)]
		public int minLines;

		[Range(1f, 10f)]
		public int maxLines;

		public RemoveStrategy removeStrategy;

		public bool clearNotRecognizedLines;

		public bool fixedArea;

		public Image controllerCursor;

		public float cursorSpeed;

		private GestureData data;

		public ResultEvent OnRecognize;

		private RectTransform rectTransform;

		public int MinLines
		{
			set
			{
			}
		}

		public int MaxLines
		{
			set
			{
			}
		}

		public DrawDetectorMode DrawMode
		{
			[CompilerGenerated]
			get
			{
				return default(DrawDetectorMode);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Start()
		{
		}

		private void OnValidate()
		{
		}

		private void Update()
		{
		}

		public void UpdateLines()
		{
		}

		private Vector2 RealToLine(Vector2 position)
		{
			return default(Vector2);
		}

		private Vector2 FixedPosition(Vector2 position)
		{
			return default(Vector2);
		}

		public void ClearLines()
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		private void LineStart(Vector2 inPos)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		private void LineMove(Vector2 inPos)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}

		private void LineEnd(Vector2 inPos)
		{
		}

		[IteratorStateMachine(typeof(<OnEndDragCoroutine>d__39))]
		private IEnumerator OnEndDragCoroutine(Vector2 inPos)
		{
			return null;
		}

		public void OnGestureSelected(List<GesturePattern> inGestures)
		{
		}

		public void ChangeDrawMode(DrawDetectorMode inMode)
		{
		}
	}
}
