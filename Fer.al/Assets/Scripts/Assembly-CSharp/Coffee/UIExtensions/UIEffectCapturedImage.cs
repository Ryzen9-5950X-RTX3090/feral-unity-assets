using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	[AddComponentMenu("UI/UIEffect/UIEffectCapturedImage", 200)]
	public class UIEffectCapturedImage : RawImage
	{
		public enum DesamplingRate
		{
			None = 0,
			x1 = 1,
			x2 = 2,
			x4 = 4,
			x8 = 8
		}

		public const string shaderName = "UI/Hidden/UI-EffectCapture";

		[SerializeField]
		[Tooltip("Effect factor between 0(no effect) and 1(complete effect).")]
		[FormerlySerializedAs("m_ToneLevel")]
		[Range(0f, 1f)]
		private float m_EffectFactor;

		[SerializeField]
		[Tooltip("Color effect factor between 0(no effect) and 1(complete effect).")]
		[Range(0f, 1f)]
		private float m_ColorFactor;

		[SerializeField]
		[Tooltip("How far is the blurring from the graphic.")]
		[FormerlySerializedAs("m_Blur")]
		[Range(0f, 1f)]
		private float m_BlurFactor;

		[SerializeField]
		[Tooltip("Effect mode.")]
		[FormerlySerializedAs("m_ToneMode")]
		private EffectMode m_EffectMode;

		[SerializeField]
		[Tooltip("Color effect mode.")]
		private ColorMode m_ColorMode;

		[SerializeField]
		[Tooltip("Blur effect mode.")]
		private BlurMode m_BlurMode;

		[SerializeField]
		[Tooltip("Color for the color effect.")]
		private Color m_EffectColor;

		[SerializeField]
		[Tooltip("Desampling rate of the generated RenderTexture.")]
		private DesamplingRate m_DesamplingRate;

		[SerializeField]
		[Tooltip("Desampling rate of reduction buffer to apply effect.")]
		private DesamplingRate m_ReductionRate;

		[SerializeField]
		[Tooltip("FilterMode for capturing.")]
		private FilterMode m_FilterMode;

		[SerializeField]
		[Tooltip("Effect material.")]
		private Material m_EffectMaterial;

		[SerializeField]
		[Tooltip("Blur iterations.")]
		[FormerlySerializedAs("m_Iterations")]
		[Range(1f, 8f)]
		private int m_BlurIterations;

		[SerializeField]
		[Tooltip("Fits graphic size to screen on captured.")]
		[FormerlySerializedAs("m_KeepCanvasSize")]
		private bool m_FitToScreen;

		[SerializeField]
		[Tooltip("Capture automatically on enable.")]
		private bool m_CaptureOnEnable;

		[SerializeField]
		[Tooltip("Capture immediately.")]
		private bool m_ImmediateCapturing;

		private RenderTexture _rt;

		private static int s_CopyId;

		private static int s_EffectId1;

		private static int s_EffectId2;

		private static int s_EffectFactorId;

		private static int s_ColorFactorId;

		private static CommandBuffer s_CommandBuffer;

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

		public virtual Material effectMaterial
		{
			get
			{
				return null;
			}
		}

		public DesamplingRate desamplingRate
		{
			get
			{
				return default(DesamplingRate);
			}
			set
			{
			}
		}

		public DesamplingRate reductionRate
		{
			get
			{
				return default(DesamplingRate);
			}
			set
			{
			}
		}

		public FilterMode filterMode
		{
			get
			{
				return default(FilterMode);
			}
			set
			{
			}
		}

		public RenderTexture capturedTexture
		{
			get
			{
				return null;
			}
		}

		[Obsolete]
		public int iterations
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int blurIterations
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		[Obsolete]
		public bool keepCanvasSize
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool fitToScreen
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
		public RenderTexture targetTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool captureOnEnable
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool immediateCapturing
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		public void GetDesamplingSize(DesamplingRate rate, out int w, out int h)
		{
		}

		public void Capture()
		{
		}

		private void SetupCommandBuffer()
		{
		}

		public void Release()
		{
		}

		private void _Release(bool releaseRT)
		{
		}

		[Conditional("UNITY_EDITOR")]
		private void _SetDirty()
		{
		}

		private void _Release(ref RenderTexture obj)
		{
		}

		[IteratorStateMachine(typeof(<_CoUpdateTextureOnNextFrame>d__95))]
		private IEnumerator _CoUpdateTextureOnNextFrame()
		{
			return null;
		}

		private void UpdateTexture()
		{
		}
	}
}
