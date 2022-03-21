using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent]
	public sealed class TouchRegion : TouchInteractable
	{
		[Serializable]
		private class VugHNrGwwHElkQqEnXvUfCcjxrP : UnityEvent<PointerEventData>
		{
		}

		[Serializable]
		private class CrxIoZnoppQKNwyWvmQiwZtYobn : UnityEvent<PointerEventData>
		{
		}

		[Serializable]
		private class lXaicWqqBSGvYByyEwgDfbHqNqBG : UnityEvent<PointerEventData>
		{
		}

		[Serializable]
		private class HWOFyvATWrreAjbnVGpGUIverogH : UnityEvent<PointerEventData>
		{
		}

		[Serializable]
		private class SYSBHvHssiKLGADHvbktEKUHzWMu : UnityEvent<PointerEventData>
		{
		}

		[Serializable]
		private class keGNuzKnrKSOAsgUAArSamgbDVxQ : UnityEvent<PointerEventData>
		{
		}

		[Serializable]
		private class dmjQJcwGEPJgGEbWvxDPQrJacpI : UnityEvent<PointerEventData>
		{
		}

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("If enabled, the Touch Region will be hidden when gameplay starts.")]
		private bool _hideAtRuntime;

		private VugHNrGwwHElkQqEnXvUfCcjxrP _onPointerDown;

		private CrxIoZnoppQKNwyWvmQiwZtYobn _onPointerUp;

		private lXaicWqqBSGvYByyEwgDfbHqNqBG _onPointerEnter;

		private HWOFyvATWrreAjbnVGpGUIverogH _onPointerExit;

		private SYSBHvHssiKLGADHvbktEKUHzWMu _onBeginDrag;

		private keGNuzKnrKSOAsgUAArSamgbDVxQ _onDrag;

		private dmjQJcwGEPJgGEbWvxDPQrJacpI _onEndDrag;

		public bool hideAtRuntime
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public event UnityAction<PointerEventData> PointerDownEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction<PointerEventData> PointerUpEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction<PointerEventData> PointerEnterEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction<PointerEventData> PointerExitEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction<PointerEventData> BeginDragEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction<PointerEventData> DragEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction<PointerEventData> EndDragEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		[CustomObfuscation]
		private TouchRegion()
		{
		}

		[CustomObfuscation]
		internal override void Awake()
		{
		}

		public override void ClearValue()
		{
		}

		internal override void OnCustomControllerUpdate()
		{
		}

		internal override void OnPointerDown(PointerEventData eventData)
		{
		}

		internal override void OnPointerUp(PointerEventData eventData)
		{
		}

		internal override void OnPointerEnter(PointerEventData eventData)
		{
		}

		internal override void OnPointerExit(PointerEventData eventData)
		{
		}

		internal override void OnBeginDrag(PointerEventData eventData)
		{
		}

		internal override void OnDrag(PointerEventData eventData)
		{
		}

		internal override void OnEndDrag(PointerEventData eventData)
		{
		}
	}
}
