using ThisOtherThing.UI.Shapes;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class UI_RectangleFillPointer : MonoBehaviour
{
	[SerializeField]
	public Rectangle _rectangle;

	[SerializeField]
	public Image _fillImage;

	[Header("Position")]
	public Vector3 minPos;

	public Vector3 maxPos;

	[Header("Corners")]
	public Vector2 cornerMin0;

	public Vector2 cornerMax0;

	[Space]
	public Vector2 cornerMin1;

	public Vector2 cornerMax1;

	[Space]
	public Vector2 cornerMin2;

	public Vector2 cornerMax2;

	[Space]
	public Vector2 cornerMin3;

	public Vector2 cornerMax3;

	private void Update()
	{
	}
}
