using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	[ExecuteAlways]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Graphic))]
	[AddComponentMenu("UI/UIEffect/UIEffect", 1)]
	public class UIEffect : UIEffectBase
	{
		public enum BlurEx
		{
			None,
			Ex
		}

		public const string shaderName = "UI/Hidden/UI-Effect";

		private static readonly ParameterTexture _ptex;

		[SerializeField]
		[FormerlySerializedAs("m_ToneLevel")]
		[Tooltip("Effect factor between 0(no effect) and 1(complete effect).")]
		[Range(0f, 1f)]
		private float m_EffectFactor;

		[SerializeField]
		[Tooltip("Color effect factor between 0(no effect) and 1(complete effect).")]
		[Range(0f, 1f)]
		private float m_ColorFactor;

		[SerializeField]
		[FormerlySerializedAs("m_Blur")]
		[Tooltip("How far is the blurring from the graphic.")]
		[Range(0f, 1f)]
		private float m_BlurFactor;

		[SerializeField]
		[FormerlySerializedAs("m_ToneMode")]
		[Tooltip("Effect mode")]
		private EffectMode m_EffectMode;

		[SerializeField]
		[Tooltip("Color effect mode")]
		private ColorMode m_ColorMode;

		[SerializeField]
		[Tooltip("Blur effect mode")]
		private BlurMode m_BlurMode;

		[SerializeField]
		[Tooltip("Advanced blurring remove common artifacts in the blur effect for uGUI.")]
		private bool m_AdvancedBlur;

		[Obsolete]
		[HideInInspector]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_ShadowBlur;

		[Obsolete]
		[HideInInspector]
		[SerializeField]
		private ShadowStyle m_ShadowStyle;

		[Obsolete]
		[HideInInspector]
		[SerializeField]
		private Color m_ShadowColor;

		[Obsolete]
		[HideInInspector]
		[SerializeField]
		private Vector2 m_EffectDistance;

		[Obsolete]
		[HideInInspector]
		[SerializeField]
		private bool m_UseGraphicAlpha;

		[Obsolete]
		[HideInInspector]
		[SerializeField]
		private Color m_EffectColor;

		[Obsolete]
		[HideInInspector]
		[SerializeField]
		private List<UIShadow.AdditionalShadow> m_AdditionalShadows;

		[Obsolete]
		public float toneLevel
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

		public float colorFactor
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
		public float blur
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
		public float blurFactor
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
		public EffectMode toneMode
		{
			get
			{
				return default(EffectMode);
			}
		}

		public EffectMode effectMode
		{
			get
			{
				return default(EffectMode);
			}
		}

		public ColorMode colorMode
		{
			get
			{
				return default(ColorMode);
			}
		}

		public BlurMode blurMode
		{
			get
			{
				return default(BlurMode);
			}
		}

		public Color effectColor
		{
			get
			{
				return default(Color);
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

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		protected override void SetDirty()
		{
		}

		private static void GetBounds(List<UIVertex> verts, int start, int count, ref Rect posBounds, ref Rect uvBounds, bool global)
		{
		}
	}
}
