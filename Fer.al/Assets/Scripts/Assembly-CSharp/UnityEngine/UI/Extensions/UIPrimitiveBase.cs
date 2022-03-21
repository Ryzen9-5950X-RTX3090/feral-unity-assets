using System;

namespace UnityEngine.UI.Extensions
{
	public class UIPrimitiveBase : MaskableGraphic, ILayoutElement, ICanvasRaycastFilter
	{
		protected static Material s_ETC1DefaultUI;

		[SerializeField]
		private Sprite m_Sprite;

		[NonSerialized]
		private Sprite m_OverrideSprite;

		internal float m_EventAlphaThreshold;

		[SerializeField]
		private ResolutionMode m_improveResolution;

		[SerializeField]
		protected float m_Resolution;

		[SerializeField]
		private bool m_useNativeSize;

		public Sprite sprite
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Sprite overrideSprite
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected Sprite activeSprite
		{
			get
			{
				return null;
			}
		}

		public float eventAlphaThreshold
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public ResolutionMode ImproveResolution
		{
			get
			{
				return default(ResolutionMode);
			}
			set
			{
			}
		}

		public float Resoloution
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool UseNativeSize
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public static Material defaultETC1GraphicMaterial
		{
			get
			{
				return null;
			}
		}

		public override Texture mainTexture
		{
			get
			{
				return null;
			}
		}

		public bool hasBorder
		{
			get
			{
				return default(bool);
			}
		}

		public float pixelsPerUnit
		{
			get
			{
				return default(float);
			}
		}

		public override Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual float minWidth
		{
			get
			{
				return default(float);
			}
		}

		public virtual float preferredWidth
		{
			get
			{
				return default(float);
			}
		}

		public virtual float flexibleWidth
		{
			get
			{
				return default(float);
			}
		}

		public virtual float minHeight
		{
			get
			{
				return default(float);
			}
		}

		public virtual float preferredHeight
		{
			get
			{
				return default(float);
			}
		}

		public virtual float flexibleHeight
		{
			get
			{
				return default(float);
			}
		}

		public virtual int layoutPriority
		{
			get
			{
				return default(int);
			}
		}

		protected UIPrimitiveBase()
		{
		}

		protected UIVertex[] SetVbo(Vector2[] vertices, Vector2[] uvs)
		{
			return null;
		}

		protected Vector2[] IncreaseResolution(Vector2[] input)
		{
			return null;
		}

		protected virtual void GeneratedUVs()
		{
		}

		protected virtual void ResolutionToNativeSize(float distance)
		{
		}

		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		public virtual void CalculateLayoutInputVertical()
		{
		}

		public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
		{
			return default(bool);
		}

		private Vector2 MapCoordinate(Vector2 local, Rect rect)
		{
			return default(Vector2);
		}

		private Vector4 GetAdjustedBorders(Vector4 border, Rect rect)
		{
			return default(Vector4);
		}

		protected override void OnEnable()
		{
		}
	}
}
