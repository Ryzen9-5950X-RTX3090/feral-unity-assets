using DG.DeInspektor.Attributes;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class SmoothLayoutTestElement : MonoBehaviour
{
	private WWSmoothLayout _smoothLayout;

	public void Setup(WWSmoothLayout inSmoothLayout)
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	public void DestroyElement()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	public void MoveUp()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	public void MoveDown()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	public void SetActiveFalse()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	public void SetActiveTrue()
	{
	}
}
