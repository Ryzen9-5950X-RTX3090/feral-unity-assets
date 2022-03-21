namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/Primitives/Diamond Graph")]
	public class DiamondGraph : UIPrimitiveBase
	{
		[SerializeField]
		private float m_a;

		[SerializeField]
		private float m_b;

		[SerializeField]
		private float m_c;

		[SerializeField]
		private float m_d;

		public float A
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float B
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float C
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float D
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}
	}
}
