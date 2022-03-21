using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Demos
{
	[AddComponentMenu("")]
	[RequireComponent(typeof(RectTransform))]
	public sealed class UIPointer : UIBehaviour
	{
		[SerializeField]
		[Tooltip("Should the hardware pointer be hidden?")]
		private bool _hideHardwarePointer;

		[SerializeField]
		[Tooltip("Sets the pointer to the last sibling in the parent hierarchy. Do not enable this on multiple UIPointers under the same parent transform or they will constantly fight each other for dominance.")]
		private bool _autoSort;

		[NonSerialized]
		private RectTransform _canvasRectTransform;

		public bool autoSort
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		protected override void OnTransformParentChanged()
		{
		}

		protected override void OnCanvasGroupChanged()
		{
		}

		public void OnScreenPositionChanged(Vector2 screenPosition)
		{
		}

		private void GetDependencies()
		{
		}
	}
}
