using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Rewired.UI;
using Rewired.Utils.Attributes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public abstract class TouchInteractable : TouchControl, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IEventSystemHandler
	{
		public enum InteractionState
		{
			Normal,
			Highlighted,
			Pressed,
			Disabled
		}

		[Flags]
		public enum TransitionTypeFlags
		{
			None = 0,
			ColorTint = 1,
			SpriteSwap = 2,
			Animation = 4
		}

		[Flags]
		public enum MouseButtonFlags
		{
			None = 0,
			LeftButton = 1,
			RightButton = 2,
			MiddleButton = 4,
			AnyButton = -1
		}

		[Serializable]
		public class InteractionStateTransitionEventHandler : UnityEvent<InteractionStateTransitionArgs>
		{
		}

		[Serializable]
		public class VisibilityChangedEventHandler : UnityEvent<bool>
		{
		}

		public class InteractionStateTransitionArgs
		{
			private TouchInteractable BHsZlcPmudzzrVEaeCtsoDPceWKg;

			private InteractionState rBokgqdrsZuLZsBTVapGfihGpbU;

			private float OyidXNnuWGQINLNaEhmkwlZPCwz;

			public TouchInteractable sender
			{
				get
				{
					return null;
				}
			}

			public InteractionState state
			{
				get
				{
					return default(InteractionState);
				}
			}

			public float duration
			{
				get
				{
					return default(float);
				}
			}

			internal InteractionStateTransitionArgs()
			{
			}

			internal void bnteExvucnBsCpxQAJWOTetSFlq(TouchInteractable P_0, InteractionState P_1, float P_2)
			{
			}
		}

		public interface IInteractionStateTransitionHandler
		{
			void OnInteractionStateTransition(InteractionStateTransitionArgs data);
		}

		public const int POINTER_ID_NULL = int.MinValue;

		public const int POINTER_ID_MOUSE_LEFT_BUTTON = -1;

		public const int POINTER_ID_MOUSE_RIGHT_BUTTON = -2;

		public const int POINTER_ID_MOUSE_MIDDLE_BUTTON = -3;

		internal const int MAX_MOUSE_BUTTONS = 3;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Toggles whether the control can be interacted with by the user.")]
		private bool _interactable;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Toggles visibility. An invisible control can still be interacted with. This property only has any effect when used with an Image Component.")]
		private bool _visible;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Sets visibility to False when the control is idle. When the control is no longer idle, visibility will be set to True again.")]
		private bool _hideWhenIdle;

		[CustomObfuscation]
		[SerializeField]
		[Bitmask(typeof(MouseButtonFlags))]
		[Tooltip("The mouse buttons that are allowed to interact with this control.")]
		private MouseButtonFlags _allowedMouseButtons;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("The transition type(s) to be used when transitioning to various states. Multiple transition types can be used simultaneously.")]
		[Bitmask(typeof(TransitionTypeFlags))]
		private TransitionTypeFlags _transitionType;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Settings using for Color Tint transitions.")]
		private ColorBlock _transitionColorTint;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Settings using for Sprite State transitions.")]
		private SpriteState _transitionSpriteState;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Settings using for Animation Trigger transitions.")]
		private AnimationTriggers _transitionAnimationTriggers;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The target Graphic component for interaction state transitions. This should normally be set to an Image component on this GameObject.")]
		private Graphic _targetGraphic;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Event sent when the Interaction State changes.")]
		private InteractionStateTransitionEventHandler _onInteractionStateTransition;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Event sent when visibility changes.")]
		private VisibilityChangedEventHandler _onVisibilityChanged;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Event sent when interaction state changes to Normal.")]
		private UnityEvent _onInteractionStateChangedToNormal;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Event sent when interaction state changes to Highlighted.")]
		private UnityEvent _onInteractionStateChangedToHighlighted;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Event sent when interaction state changes to Pressed.")]
		private UnityEvent _onInteractionStateChangedToPressed;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Event sent when interaction state changes to Disabled.")]
		private UnityEvent _onInteractionStateChangedToDisabled;

		private readonly List<CanvasGroup> _canvasGroupCache;

		private bool _groupsAllowInteraction;

		private InteractionState _interactionState;

		[NonSerialized]
		private bool IXgubBiHZOnBAjLkDRcJjAfbtyr;

		[NonSerialized]
		private bool byeanBfvjEeOOwRBSBerFwsuBMBA;

		private bool _varWatch_visible;

		private bool _varWatch_interactable;

		private bool _allowSendingEvents;

		private static InteractionStateTransitionArgs _transitionArgs;

		private QGjnOCnHKfrjIqlAonYthHKMREQ.HierarchyEventHelper<IVisibilityChangedHandler, bool> __hierarchyVisibilityChangedHandlers;

		private QGjnOCnHKfrjIqlAonYthHKMREQ.HierarchyEventHelper<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> __hierarchyInteractionStateTransitionHandlers;

		private static QGjnOCnHKfrjIqlAonYthHKMREQ.EventFunction<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> __interactionStateTransitionHandlerDelegate;

		private QGjnOCnHKfrjIqlAonYthHKMREQ.HierarchyEventHelper<IVisibilityChangedHandler, bool> hierarchyVisibilityChangedHandlers
		{
			get
			{
				return null;
			}
		}

		private QGjnOCnHKfrjIqlAonYthHKMREQ.HierarchyEventHelper<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> hierarchyInteractionStateTransitionHandlers
		{
			get
			{
				return null;
			}
		}

		public bool interactable
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool visible
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool hideWhenIdle
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public MouseButtonFlags allowedMouseButtons
		{
			get
			{
				return default(MouseButtonFlags);
			}
			set
			{
			}
		}

		public TransitionTypeFlags transitionType
		{
			get
			{
				return default(TransitionTypeFlags);
			}
			set
			{
			}
		}

		public ColorBlock transitionColorTint
		{
			get
			{
				return default(ColorBlock);
			}
			set
			{
			}
		}

		public SpriteState transitionSpriteState
		{
			get
			{
				return default(SpriteState);
			}
			set
			{
			}
		}

		public AnimationTriggers transitionAnimationTriggers
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Graphic targetGraphic
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Image image
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Animator animator
		{
			get
			{
				return null;
			}
		}

		public InteractionState interactionState
		{
			get
			{
				return default(InteractionState);
			}
		}

		internal static QGjnOCnHKfrjIqlAonYthHKMREQ.EventFunction<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> interactionStateTransitionHandlerDelegate
		{
			get
			{
				return null;
			}
		}

		public event UnityAction<InteractionStateTransitionArgs> InteractionStateSetEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction<bool> VisibilityChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction InteractionStateChangedToNormal
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction InteractionStateChangedToHighlighted
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction InteractionStateChangedToPressed
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction InteractionStateChangedToDisabled
		{
			add
			{
			}
			remove
			{
			}
		}

		[CustomObfuscation]
		internal TouchInteractable()
		{
		}

		[CustomObfuscation]
		internal override void Awake()
		{
		}

		[CustomObfuscation]
		internal override void OnCanvasGroupChanged()
		{
		}

		[CustomObfuscation]
		internal override void OnDidApplyAnimationProperties()
		{
		}

		[CustomObfuscation]
		internal override void OnEnable()
		{
		}

		[CustomObfuscation]
		internal override void OnDisable()
		{
		}

		[CustomObfuscation]
		internal override void OnValidate()
		{
		}

		[CustomObfuscation]
		internal override void Reset()
		{
		}

		internal override void OnSetProperty()
		{
		}

		internal override void FindEventHandlers()
		{
		}

		private void lXXihxaGwUqiAesOLyAhYAOaHUTF()
		{
		}

		private void SYNlHHRrbZcAJodCuaKCnCWbJLf(InteractionState P_0, bool P_1)
		{
		}

		private void EqHRSTidijHvHCzjafITwRmHRek(Color P_0, bool P_1)
		{
		}

		private void ZTgcHEUFatyMOsotIsfeFdGabwT(Sprite P_0)
		{
		}

		private void WDCQCdpqVqalHhBdpcWeKLDbEKBn(string P_0)
		{
		}

		private void vQItACpvQdVvDThyFEokrAlWHpk(bool P_0)
		{
		}

		public bool IsInteractable()
		{
			return default(bool);
		}

		internal virtual bool IsPressed()
		{
			return default(bool);
		}

		internal void bEywVhSimReqAWaZxErFkjJjVtGP(BaseEventData P_0)
		{
		}

		internal virtual bool IsThisOrTouchRegionGameObject(GameObject P_0)
		{
			return default(bool);
		}

		private bool FwZXnhkBucajliMuWRCjmtpVpftx(BaseEventData P_0)
		{
			return default(bool);
		}

		private bool FwZXnhkBucajliMuWRCjmtpVpftx(bool P_0, GameObject P_1)
		{
			return default(bool);
		}

		private InteractionState iPvJBXPeCclLOnwPetnhgIQsLDZ(BaseEventData P_0)
		{
			return default(InteractionState);
		}

		private bool AlxDDcfwGckuFUYweCgYtwrdgQkE(InteractionState P_0)
		{
			return default(bool);
		}

		private void VgChwotAchouzECAvCsSsIzLjHr()
		{
		}

		private void ZqkunzJCzHBRZRpDdDGYJArAIWI()
		{
		}

		private void GyytlVmiBRgVIBlxHTTMcNlOiTAt(bool P_0, bool P_1)
		{
		}

		private void mqiaGywLlRymbsGGeFSVkHQPXjn()
		{
		}

		private void ixjtpheoJlhcHpvQksvNDhgeKCH()
		{
		}

		private void LZtLIradkTZxeuvnkQoCvQBxNXr()
		{
		}

		private void mXxeTnZEpQaukGpVlCughHfuIUBy()
		{
		}

		internal virtual void OnPointerDown(PointerEventData P_0)
		{
		}

		internal virtual void OnPointerUp(PointerEventData P_0)
		{
		}

		internal virtual void OnPointerEnter(PointerEventData P_0)
		{
		}

		internal virtual void OnPointerExit(PointerEventData P_0)
		{
		}

		internal virtual void OnBeginDrag(PointerEventData P_0)
		{
		}

		internal virtual void OnDrag(PointerEventData P_0)
		{
		}

		internal virtual void OnEndDrag(PointerEventData P_0)
		{
		}

		void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
		{
		}

		void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
		{
		}

		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
		{
		}

		void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
		{
		}

		void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
		{
		}

		void IDragHandler.OnDrag(PointerEventData eventData)
		{
		}

		void IEndDragHandler.OnEndDrag(PointerEventData eventData)
		{
		}

		internal static bool HnDYYyEyytpwLaJegWvMADlHFsSd(int P_0)
		{
			return default(bool);
		}

		internal static Vector3 cUxvuyDqpidwABRzxIDKypbqGbj(int P_0)
		{
			return default(Vector3);
		}

		internal static bool YqHoLRMcduRQOWkGZqPZbSXCqMr(int P_0)
		{
			return default(bool);
		}

		internal static bool RKuBNDBltyOHRbYmamVpbyrCxlHD(int P_0)
		{
			return default(bool);
		}

		private static int jdocHahTlBXSaoXdrVnORQOhnMr(int P_0)
		{
			return default(int);
		}

		internal static bool zXZcOyXprfvKGdTogolTEsqpkNr(MouseButtonFlags P_0, int P_1)
		{
			return default(bool);
		}

		private static bool VJAvTiGJAjWQpqLdvzMxtBhsiBuJ(MouseButtonFlags P_0, int P_1)
		{
			return default(bool);
		}

		private static int ehbuqvZMycoCNLbMSlrJgEAhxJr(int P_0)
		{
			return default(int);
		}

		internal static bool mDtvTOyiODjBcicqmdrKnRoVnYx(MouseButtonFlags P_0, out int P_1)
		{
			return default(bool);
		}

		internal static bool zXZcOyXprfvKGdTogolTEsqpkNr(int P_0, MouseButtonFlags P_1, EventTriggerType P_2)
		{
			return default(bool);
		}

		internal static bool wqlomoLqWqbNsWcBNmubucLvszN(MouseButtonFlags P_0)
		{
			return default(bool);
		}

		[CompilerGenerated]
		private void PiZvjlDfphRqtQeIlaOPmkLmwDj(bool P_0)
		{
		}

		[CompilerGenerated]
		private static void DDwUPgHHEKNvYLHTYIUQEMQYUeA(IInteractionStateTransitionHandler P_0, InteractionStateTransitionArgs P_1)
		{
		}
	}
}
