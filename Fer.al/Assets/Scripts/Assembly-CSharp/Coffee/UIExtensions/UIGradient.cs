using UnityEngine;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	[DisallowMultipleComponent]
	[AddComponentMenu("UI/UIEffect/UIGradient", 101)]
	public class UIGradient : BaseMeshEffect
	{
		public enum Direction
		{
			Horizontal,
			Vertical,
			Angle,
			Diagonal
		}

		public enum GradientStyle
		{
			Rect,
			Fit,
			Split
		}

		private struct Matrix2x3
		{
			public float m00;

			public float m01;

			public float m02;

			public float m10;

			public float m11;

			public float m12;

			public Matrix2x3(Rect rect, float cos, float sin)
			{
			}

			public static Vector2 operator *(Matrix2x3 m, Vector2 v)
			{
				return default(Vector2);
			}
		}

		[SerializeField]
		[Tooltip("Gradient Direction.")]
		private Direction m_Direction;

		[SerializeField]
		[Tooltip("Color1: Top or Left.")]
		private Color m_Color1;

		[SerializeField]
		[Tooltip("Color2: Bottom or Right.")]
		private Color m_Color2;

		[SerializeField]
		[Tooltip("Color3: For diagonal.")]
		private Color m_Color3;

		[SerializeField]
		[Tooltip("Color4: For diagonal.")]
		private Color m_Color4;

		[SerializeField]
		[Tooltip("Gradient rotation.")]
		[Range(-180f, 180f)]
		private float m_Rotation;

		[SerializeField]
		[Tooltip("Gradient offset for Horizontal, Vertical or Angle.")]
		[Range(-1f, 1f)]
		private float m_Offset1;

		[SerializeField]
		[Tooltip("Gradient offset for Diagonal.")]
		[Range(-1f, 1f)]
		private float m_Offset2;

		[SerializeField]
		[Tooltip("Gradient style for Text.")]
		private GradientStyle m_GradientStyle;

		[SerializeField]
		[Tooltip("Color space to correct color.")]
		private ColorSpace m_ColorSpace;

		[SerializeField]
		[Tooltip("Ignore aspect ratio.")]
		private bool m_IgnoreAspectRatio;

		private static readonly Vector2[] s_SplitedCharacterPosition;

		public Graphic targetGraphic
		{
			get
			{
				return null;
			}
		}

		public Direction direction
		{
			get
			{
				return default(Direction);
			}
			set
			{
			}
		}

		public Color color1
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color color2
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color color3
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color color4
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float rotation
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float offset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Vector2 offset2
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public GradientStyle gradientStyle
		{
			get
			{
				return default(GradientStyle);
			}
			set
			{
			}
		}

		public ColorSpace colorSpace
		{
			get
			{
				return default(ColorSpace);
			}
			set
			{
			}
		}

		public bool ignoreAspectRatio
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}
	}
}
