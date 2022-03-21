using UnityEngine;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	[AddComponentMenu("UI/UIEffect/UIHsvModifier", 4)]
	public class UIHsvModifier : UIEffectBase
	{
		public const string shaderName = "UI/Hidden/UI-Effect-HSV";

		private static readonly ParameterTexture _ptex;

		[SerializeField]
		[Header("Adjustment")]
		[Tooltip("Hue shift [-0.5 ~ 0.5].")]
		[Range(0f, 1f)]
		private float m_Hue;

		[SerializeField]
		[Tooltip("Saturation shift [-0.5 ~ 0.5].")]
		[Range(0f, 1f)]
		private float m_Saturation;

		[SerializeField]
		[Tooltip("Value shift [-0.5 ~ 0.5].")]
		[Range(0f, 1f)]
		private float m_Value;

		public float saturation
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float value
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float hue
		{
			get
			{
				return default(float);
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
	}
}
