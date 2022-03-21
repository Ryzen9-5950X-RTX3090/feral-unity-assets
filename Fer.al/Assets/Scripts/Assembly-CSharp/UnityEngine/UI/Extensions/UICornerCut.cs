namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/Primitives/Cut Corners")]
	public class UICornerCut : UIPrimitiveBase
	{
		public Vector2 cornerSize;

		[SerializeField]
		[Header("Corners to cut")]
		private bool m_cutUL;

		[SerializeField]
		private bool m_cutUR;

		[SerializeField]
		private bool m_cutLL;

		[SerializeField]
		private bool m_cutLR;

		[SerializeField]
		[Tooltip("Up-Down colors become Left-Right colors")]
		private bool m_makeColumns;

		[SerializeField]
		[Header("Color the cut bars differently")]
		private bool m_useColorUp;

		[SerializeField]
		private Color32 m_colorUp;

		[SerializeField]
		private bool m_useColorDown;

		[SerializeField]
		private Color32 m_colorDown;

		public bool CutUL
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool CutUR
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool CutLL
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool CutLR
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool MakeColumns
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool UseColorUp
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Color32 ColorUp
		{
			get
			{
				return default(Color32);
			}
			set
			{
			}
		}

		public bool UseColorDown
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Color32 ColorDown
		{
			get
			{
				return default(Color32);
			}
			set
			{
			}
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		private static void AddSquare(Rect rect, Rect rectUV, Color32 color32, VertexHelper vh)
		{
		}

		private static void AddSquare(Vector2 a, Vector2 b, Vector2 c, Vector2 d, Rect rectUV, Color32 color32, VertexHelper vh)
		{
		}

		private static int AddVert(float x, float y, Rect area, Color32 color32, VertexHelper vh)
		{
			return default(int);
		}
	}
}
