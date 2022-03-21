using UnityEngine;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	[AddComponentMenu("UI/UIEffect/UITransitionEffect", 5)]
	public class UITransitionEffect : UIEffectBase
	{
		public enum EffectMode
		{
			Fade = 1,
			Cutoff,
			Dissolve
		}

		public const string shaderName = "UI/Hidden/UI-Effect-Transition";

		private static readonly ParameterTexture _ptex;

		[SerializeField]
		[Tooltip("Effect mode.")]
		private EffectMode m_EffectMode;

		[SerializeField]
		[Tooltip("Effect factor between 0(hidden) and 1(shown).")]
		[Range(0f, 1f)]
		private float m_EffectFactor;

		[SerializeField]
		[Tooltip("Transition texture (single channel texture).")]
		private Texture m_TransitionTexture;

		[SerializeField]
		[Tooltip("The area for effect.")]
		private EffectArea m_EffectArea;

		[SerializeField]
		[Tooltip("Keep effect aspect ratio.")]
		private bool m_KeepAspectRatio;

		[SerializeField]
		[Tooltip("Dissolve edge width.")]
		[Range(0f, 1f)]
		private float m_DissolveWidth;

		[SerializeField]
		[Tooltip("Dissolve edge softness.")]
		[Range(0f, 1f)]
		private float m_DissolveSoftness;

		[SerializeField]
		[Tooltip("Dissolve edge color.")]
		[ColorUsage(false)]
		private Color m_DissolveColor;

		[SerializeField]
		[Tooltip("Disable graphic's raycast target on hidden.")]
		private bool m_PassRayOnHidden;

		[SerializeField]
		[Header("Effect Player")]
		private EffectPlayer m_Player;

		private MaterialCache _materialCache;

		public float effectFactor
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Texture transitionTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public EffectMode effectMode
		{
			get
			{
				return default(EffectMode);
			}
		}

		public bool keepAspectRatio
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public override ParameterTexture ptex
		{
			get
			{
				return null;
			}
		}

		public float dissolveWidth
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float dissolveSoftness
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Color dissolveColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float duration
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool passRayOnHidden
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public AnimatorUpdateMode updateMode
		{
			get
			{
				return default(AnimatorUpdateMode);
			}
			set
			{
			}
		}

		private EffectPlayer _player
		{
			get
			{
				return null;
			}
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public override void ModifyMaterial()
		{
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void SetDirty()
		{
		}
	}
}
