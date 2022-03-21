using System.Collections.Generic;
using Rewired.UI;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
	public abstract class RewiredPointerInputModule : BaseInputModule
	{
		protected class MouseState
		{
			private List<ButtonState> m_TrackedButtons;

			public bool AnyPressesThisFrame()
			{
				return default(bool);
			}

			public bool AnyReleasesThisFrame()
			{
				return default(bool);
			}

			public ButtonState GetButtonState(int button)
			{
				return null;
			}

			public void SetButtonState(int button, PointerEventData.FramePressState stateForMouseButton, PlayerPointerEventData data)
			{
			}
		}

		public class MouseButtonEventData
		{
			public PointerEventData.FramePressState buttonState;

			public PlayerPointerEventData buttonData;

			public bool PressedThisFrame()
			{
				return default(bool);
			}

			public bool ReleasedThisFrame()
			{
				return default(bool);
			}
		}

		protected class ButtonState
		{
			private int m_Button;

			private MouseButtonEventData m_EventData;

			public MouseButtonEventData eventData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public int button
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
		}

		private sealed class UnityInputSource : IMouseInputSource, ITouchInputSource
		{
			private Vector2 m_MousePosition;

			private Vector2 m_MousePositionPrev;

			private int m_LastUpdatedFrame;

			int IMouseInputSource.playerId
			{
				get
				{
					return default(int);
				}
			}

			int ITouchInputSource.playerId
			{
				get
				{
					return default(int);
				}
			}

			bool IMouseInputSource.enabled
			{
				get
				{
					return default(bool);
				}
			}

			bool IMouseInputSource.locked
			{
				get
				{
					return default(bool);
				}
			}

			int IMouseInputSource.buttonCount
			{
				get
				{
					return default(int);
				}
			}

			Vector2 IMouseInputSource.screenPosition
			{
				get
				{
					return default(Vector2);
				}
			}

			Vector2 IMouseInputSource.screenPositionDelta
			{
				get
				{
					return default(Vector2);
				}
			}

			Vector2 IMouseInputSource.wheelDelta
			{
				get
				{
					return default(Vector2);
				}
			}

			bool ITouchInputSource.touchSupported
			{
				get
				{
					return default(bool);
				}
			}

			int ITouchInputSource.touchCount
			{
				get
				{
					return default(int);
				}
			}

			bool IMouseInputSource.GetButtonDown(int button)
			{
				return default(bool);
			}

			bool IMouseInputSource.GetButtonUp(int button)
			{
				return default(bool);
			}

			bool IMouseInputSource.GetButton(int button)
			{
				return default(bool);
			}

			Touch ITouchInputSource.GetTouch(int index)
			{
				return default(Touch);
			}

			private void TryUpdate()
			{
			}
		}

		public const int kMouseLeftId = -1;

		public const int kMouseRightId = -2;

		public const int kMouseMiddleId = -3;

		public const int kFakeTouchesId = -4;

		private const int customButtonsStartingId = -2147483520;

		private const int customButtonsMaxCount = 128;

		private const int customButtonsLastId = -2147483392;

		private readonly List<IMouseInputSource> m_MouseInputSourcesList;

		private Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> m_PlayerPointerData;

		private ITouchInputSource m_UserDefaultTouchInputSource;

		private UnityInputSource __m_DefaultInputSource;

		private readonly MouseState m_MouseState;

		private UnityInputSource defaultInputSource
		{
			get
			{
				return null;
			}
		}

		private IMouseInputSource defaultMouseInputSource
		{
			get
			{
				return null;
			}
		}

		protected ITouchInputSource defaultTouchInputSource
		{
			get
			{
				return null;
			}
		}

		protected virtual bool isMouseSupported
		{
			get
			{
				return default(bool);
			}
		}

		protected bool IsDefaultMouse(IMouseInputSource mouse)
		{
			return default(bool);
		}

		public IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex)
		{
			return null;
		}

		public void RemoveMouseInputSource(IMouseInputSource source)
		{
		}

		public void AddMouseInputSource(IMouseInputSource source)
		{
		}

		public int GetMouseInputSourceCount(int playerId)
		{
			return default(int);
		}

		public ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex)
		{
			return null;
		}

		public void RemoveTouchInputSource(ITouchInputSource source)
		{
		}

		public void AddTouchInputSource(ITouchInputSource source)
		{
		}

		public int GetTouchInputSourceCount(int playerId)
		{
			return default(int);
		}

		protected void ClearMouseInputSources()
		{
		}

		protected abstract bool IsDefaultPlayer(int playerId);

		protected bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType)
		{
			return default(bool);
		}

		private PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType)
		{
			return null;
		}

		protected void RemovePointerData(PlayerPointerEventData data)
		{
		}

		protected PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released)
		{
			return null;
		}

		protected virtual MouseState GetMousePointerEventData(int playerId, int mouseIndex)
		{
			return null;
		}

		protected PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType)
		{
			return null;
		}

		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			return default(bool);
		}

		protected virtual void ProcessMove(PlayerPointerEventData pointerEvent)
		{
		}

		protected virtual void ProcessDrag(PlayerPointerEventData pointerEvent)
		{
		}

		public override bool IsPointerOverGameObject(int pointerTypeId)
		{
			return default(bool);
		}

		protected void ClearSelection()
		{
		}

		public override string ToString()
		{
			return null;
		}

		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
		}

		protected void CopyFromTo(PointerEventData from, PointerEventData to)
		{
		}

		protected PointerEventData.FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId)
		{
			return default(PointerEventData.FramePressState);
		}
	}
}
