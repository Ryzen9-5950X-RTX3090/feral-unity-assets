using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace GestureRecognizer
{
	public class UILineRenderer : MaskableGraphic
	{
		private enum SegmentType
		{
			Start,
			Middle,
			End
		}

		public enum JoinType
		{
			Bevel,
			Miter
		}

		private const float MIN_MITER_JOIN = (float)Math.PI / 12f;

		private const float MIN_BEVEL_NICE_JOIN = (float)Math.PI / 6f;

		private static readonly Vector2 UV_TOP_LEFT;

		private static readonly Vector2 UV_BOTTOM_LEFT;

		private static readonly Vector2 UV_TOP_CENTER;

		private static readonly Vector2 UV_BOTTOM_CENTER;

		private static readonly Vector2 UV_TOP_RIGHT;

		private static readonly Vector2 UV_BOTTOM_RIGHT;

		private static readonly Vector2[] startUvs;

		private static readonly Vector2[] middleUvs;

		private static readonly Vector2[] endUvs;

		[SerializeField]
		private Texture m_Texture;

		[SerializeField]
		private Rect m_UVRect;

		public float LineThickness;

		public bool UseMargins;

		public Vector2 Margin;

		public Vector2[] Points;

		public bool relativeSize;

		public bool LineList;

		public bool LineCaps;

		public JoinType LineJoins;

		public override Texture mainTexture
		{
			get
			{
				return null;
			}
		}

		public Texture texture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Rect uvRect
		{
			get
			{
				return default(Rect);
			}
			set
			{
			}
		}

		public event Action OnPopulateCallback
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		private UIVertex[] CreateLineCap(Vector2 start, Vector2 end, SegmentType type)
		{
			return null;
		}

		private UIVertex[] CreateLineSegment(Vector2 start, Vector2 end, SegmentType type)
		{
			return null;
		}

		protected UIVertex[] SetVbo(Vector2[] vertices, Vector2[] uvs)
		{
			return null;
		}
	}
}
