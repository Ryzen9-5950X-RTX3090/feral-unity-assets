using ThisOtherThing.UI.Shapes;
using UnityEngine;

[ExecuteAlways]
[RequireComponent(typeof(Rectangle))]
public class UI_SkewedRect_MatchParent : MonoBehaviour
{
	[SerializeField]
	private Rectangle _selfRectangle;

	[SerializeField]
	private Rectangle _parentRectangle;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void Refresh()
	{
	}

	private void Reset()
	{
	}
}
