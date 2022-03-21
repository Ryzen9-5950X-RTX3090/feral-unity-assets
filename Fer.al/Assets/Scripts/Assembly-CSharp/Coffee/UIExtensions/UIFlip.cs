using UnityEngine;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Graphic))]
	[AddComponentMenu("UI/UIEffect/UIFlip", 102)]
	public class UIFlip : BaseMeshEffect
	{
		[SerializeField]
		[Tooltip("Flip horizontally.")]
		private bool m_Horizontal;

		[SerializeField]
		[Tooltip("Flip vertically.")]
		private bool m_Veritical;

		public bool horizontal
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool vertical
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
