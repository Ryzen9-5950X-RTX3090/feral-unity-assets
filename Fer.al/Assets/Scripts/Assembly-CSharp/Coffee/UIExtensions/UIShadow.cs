using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	[RequireComponent(typeof(Graphic))]
	[AddComponentMenu("UI/UIEffect/UIShadow", 100)]
	public class UIShadow : Shadow, IParameterTexture
	{
		[Serializable]
		[Obsolete]
		public class AdditionalShadow
		{
			[FormerlySerializedAs("shadowBlur")]
			[Range(0f, 1f)]
			public float blur;

			[FormerlySerializedAs("shadowMode")]
			public ShadowStyle style;

			[FormerlySerializedAs("shadowColor")]
			public Color effectColor;

			public Vector2 effectDistance;

			public bool useGraphicAlpha;
		}

		[SerializeField]
		[Tooltip("How far is the blurring shadow from the graphic.")]
		[FormerlySerializedAs("m_Blur")]
		[Range(0f, 1f)]
		private float m_BlurFactor;

		[SerializeField]
		[Tooltip("Shadow effect style.")]
		private ShadowStyle m_Style;

		[HideInInspector]
		[Obsolete]
		[SerializeField]
		private List<AdditionalShadow> m_AdditionalShadows;

		private int _graphicVertexCount;

		private static readonly List<UIShadow> tmpShadows;

		private UIEffect _uiEffect;

		private static readonly List<UIVertex> s_Verts;

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

		public ShadowStyle style
		{
			get
			{
				return default(ShadowStyle);
			}
			set
			{
			}
		}

		public int parameterIndex
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ParameterTexture ptex
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		private void _ApplyShadow(List<UIVertex> verts, Color color, ref int start, ref int end, Vector2 effectDistance, ShadowStyle style, bool useGraphicAlpha)
		{
		}

		private void _ApplyShadowZeroAlloc(List<UIVertex> verts, Color color, ref int start, ref int end, float x, float y, bool useGraphicAlpha)
		{
		}

		private void _SetDirty()
		{
		}
	}
}
