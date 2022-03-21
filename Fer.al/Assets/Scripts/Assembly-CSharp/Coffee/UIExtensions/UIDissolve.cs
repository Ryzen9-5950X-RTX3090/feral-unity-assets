using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	[AddComponentMenu("UI/UIEffect/UIDissolve", 3)]
	public class UIDissolve : UIEffectBase
	{
		public const string shaderName = "UI/Hidden/UI-Effect-Dissolve";

		private static readonly ParameterTexture _ptex;

		[SerializeField]
		[Tooltip("Current location[0-1] for dissolve effect. 0 is not dissolved, 1 is completely dissolved.")]
		[FormerlySerializedAs("m_Location")]
		[Range(0f, 1f)]
		private float m_EffectFactor;

		[SerializeField]
		[Tooltip("Edge width.")]
		[Range(0f, 1f)]
		private float m_Width;

		[SerializeField]
		[Tooltip("Edge softness.")]
		[Range(0f, 1f)]
		private float m_Softness;

		[SerializeField]
		[Tooltip("Edge color.")]
		[ColorUsage(false)]
		private Color m_Color;

		[SerializeField]
		[Tooltip("Edge color effect mode.")]
		private ColorMode m_ColorMode;

		[SerializeField]
		[Tooltip("Noise texture for dissolving (single channel texture).")]
		private Texture m_NoiseTexture;

		[SerializeField]
		[Tooltip("The area for effect.")]
		protected EffectArea m_EffectArea;

		[SerializeField]
		[Tooltip("Keep effect aspect ratio.")]
		private bool m_KeepAspectRatio;

		[SerializeField]
		[Header("Effect Player")]
		private EffectPlayer m_Player;

		[Obsolete]
		[HideInInspector]
		[SerializeField]
		[Range(0.1f, 10f)]
		private float m_Duration;

		[Obsolete]
		[HideInInspector]
		[SerializeField]
		private AnimatorUpdateMode m_UpdateMode;

		private MaterialCache _materialCache;

		[Obsolete]
		public float location
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

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

		public float width
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float softness
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Color color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Texture noiseTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public EffectArea effectArea
		{
			get
			{
				return default(EffectArea);
			}
			set
			{
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

		public ColorMode colorMode
		{
			get
			{
				return default(ColorMode);
			}
		}

		[Obsolete]
		public bool play
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[Obsolete]
		public bool loop
		{
			get
			{
				return default(bool);
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

		[Obsolete]
		public float loopDelay
		{
			get
			{
				return default(float);
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

		public override ParameterTexture ptex
		{
			get
			{
				return null;
			}
		}

		private EffectPlayer _player
		{
			get
			{
				return null;
			}
		}

		public override void ModifyMaterial()
		{
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		protected override void SetDirty()
		{
		}

		public void Play()
		{
		}

		public void Stop()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}
	}
}
