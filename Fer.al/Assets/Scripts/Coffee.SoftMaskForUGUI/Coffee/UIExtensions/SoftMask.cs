using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	public class SoftMask : Mask, IMeshModifier
	{
		public enum DesamplingRate
		{
			None = 0,
			x1 = 1,
			x2 = 2,
			x4 = 4,
			x8 = 8
		}

		private static readonly List<SoftMask>[] s_TmpSoftMasks;

		private static readonly Color[] s_ClearColors;

		[SerializeField]
		[Tooltip("The desampling rate for soft mask buffer.")]
		private DesamplingRate m_DesamplingRate;

		[SerializeField]
		[Tooltip("The value used by the soft mask to select the area of influence defined over the soft mask's graphic.")]
		[Range(0.01f, 1f)]
		private float m_Softness;

		[SerializeField]
		[Tooltip("Should the soft mask ignore parent soft masks?")]
		private bool m_IgnoreParent;

		[SerializeField]
		[Tooltip("Is the soft mask a part of parent soft mask?")]
		private bool m_PartOfParent;

		private static Shader s_SoftMaskShader;

		private static Texture2D s_ReadTexture;

		private static List<SoftMask> s_ActiveSoftMasks;

		private static List<SoftMask> s_TempRelatables;

		private static int s_StencilCompId;

		private static int s_ColorMaskId;

		private static int s_MainTexId;

		private static int s_SoftnessId;

		private MaterialPropertyBlock _mpb;

		private CommandBuffer _cb;

		private Material _material;

		private RenderTexture _softMaskBuffer;

		private int _stencilDepth;

		private Mesh _mesh;

		private SoftMask _parent;

		private List<SoftMask> _children;

		private bool _hasChanged;

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

		public bool ignoreParent
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool partOfParent
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public RenderTexture softMaskBuffer
		{
			get
			{
				return null;
			}
		}

		public bool hasChanged
		{
			get
			{
				return default(bool);
			}
			private set
			{
			}
		}

		public SoftMask parent
		{
			get
			{
				return null;
			}
		}

		private Material material
		{
			get
			{
				return null;
			}
		}

		private Mesh mesh
		{
			get
			{
				return null;
			}
		}

		public override Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		void IMeshModifier.ModifyMesh(VertexHelper verts)
		{
		}

		public void ModifyMesh(Mesh inMesh)
		{
		}

		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera, Graphic g, int[] interactions)
		{
			return default(bool);
		}

		public override bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return default(bool);
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnTransformParentChanged()
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		private static void UpdateMaskTextures()
		{
		}

		private void UpdateMaskTexture()
		{
		}

		private void GetDesamplingSize(DesamplingRate rate, out int w, out int h)
		{
		}

		private void ReleaseRT(ref RenderTexture tmpRT)
		{
		}

		private void ReleaseObject(Object obj)
		{
		}

		private void SetParent(SoftMask newParent)
		{
		}

		private float GetPixelValue(int x, int y, int[] interactions)
		{
			return default(float);
		}
	}
}
