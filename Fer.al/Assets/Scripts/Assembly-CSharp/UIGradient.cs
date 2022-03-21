using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/Effects/Gradient")]
public class UIGradient : BaseMeshEffect
{
	[SerializeField]
	private Color m_color1;

	[SerializeField]
	private Color m_color2;

	[SerializeField]
	[Range(-180f, 180f)]
	private float m_angle;

	public bool m_ignoreRatio;

	public Color Color1
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public Color Color2
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public float Angle
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public override void ModifyMesh(VertexHelper vh)
	{
	}
}
