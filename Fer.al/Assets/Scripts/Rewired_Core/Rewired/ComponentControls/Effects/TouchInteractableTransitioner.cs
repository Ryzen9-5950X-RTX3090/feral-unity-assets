using Rewired.UI;
using Rewired.Utils.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.ComponentControls.Effects
{
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public sealed class TouchInteractableTransitioner : MonoBehaviour, IVisibilityChangedHandler, TouchInteractable.IInteractionStateTransitionHandler
	{
		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Toggles visibility. An invisible control can still be interacted with. This property only has any effect when used with an Image Component.")]
		private bool _visible;

		[SerializeField]
		[CustomObfuscation]
		[Bitmask(typeof(TouchInteractable.TransitionTypeFlags))]
		[Tooltip("The transition type(s) to be used when transitioning to various states. Multiple transition types can be used simultaneously.")]
		private TouchInteractable.TransitionTypeFlags _transitionType;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Settings using for Color Tint transitions.")]
		private ColorBlock _transitionColorTint;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Settings using for Sprite State transitions.")]
		private SpriteState _transitionSpriteState;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Settings using for Animation Trigger transitions.")]
		private AnimationTriggers _transitionAnimationTriggers;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The target Graphic component for interaction state transitions. This should normally be set to an Image component on this GameObject.")]
		private Graphic _targetGraphic;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Toggles whether the fade duration is set by incoming transition events. If enabled, the duration of fades for visibility and Color Tint transitions will be synchronized with the event sender.")]
		private bool _syncFadeDurationWithTransitionEvent;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Toggles whether the color tint is set by incoming transition events. If enabled, the color tint transition of the event sender will override any color tint setting here. This setting overrides Sync Fade Duration With Transition Event.")]
		private bool _syncColorTintWithTransitionEvent;

		private TouchInteractable.InteractionState mPICZYrNYhUJdchMmZHBJgfeuVU;

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

		public TouchInteractable.TransitionTypeFlags transitionType
		{
			get
			{
				return default(TouchInteractable.TransitionTypeFlags);
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

		public bool syncFadeDurationWithTransitionEvent
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool syncColorTintWithTransitionEvent
		{
			get
			{
				return default(bool);
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

		[CustomObfuscation]
		private TouchInteractableTransitioner()
		{
		}

		[CustomObfuscation]
		private void Awake()
		{
		}

		[CustomObfuscation]
		private void OnEnable()
		{
		}

		[CustomObfuscation]
		private void OnDisable()
		{
		}

		[CustomObfuscation]
		private void OnValidate()
		{
		}

		[CustomObfuscation]
		private void Reset()
		{
		}

		[CustomObfuscation]
		private void OnCanvasGroupWasChanged()
		{
		}

		[CustomObfuscation]
		private void OnAnimationPropertiesWereApplied()
		{
		}

		private void cmtbuFqVYbwoFNiprYsdGZCxOJZ()
		{
		}

		private void LZtLIradkTZxeuvnkQoCvQBxNXr()
		{
		}

		private void vQItACpvQdVvDThyFEokrAlWHpk(bool P_0)
		{
		}

		private void GyytlVmiBRgVIBlxHTTMcNlOiTAt(bool P_0, bool P_1)
		{
		}

		private bool xDlyBuvNkVnisWaDfdGdVigncyt()
		{
			return default(bool);
		}

		private void lXXihxaGwUqiAesOLyAhYAOaHUTF()
		{
		}

		private void SYNlHHRrbZcAJodCuaKCnCWbJLf(TouchInteractable.InteractionState P_0, bool P_1)
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

		public void OnInteractionStateTransition(TouchInteractable.InteractionStateTransitionArgs args)
		{
		}

		public void OnVisibilityChanged(bool state)
		{
		}
	}
}
