using UnityEngine;
using UnityEngine.UI;

public class PooledLayoutElement_Colored : PooledGridLayoutElement
{
	public PooledGridLayoutGroup _poolGroup;

	public Image image;

	public Text text;

	public override void Setup(int inElementIndex)
	{
	}

	public static Color Rainbow(float progress)
	{
		return default(Color);
	}
}
