using UnityEngine;
using UnityEngine.UI;

public class UI_ColorizedIcon : BaseMeshEffect
{
	[SerializeField]
	private Color _color1;

	[SerializeField]
	private Color _color2;

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

	protected UI_ColorizedIcon()
	{
	}

	public override void ModifyMesh(VertexHelper vh)
	{
	}
}
