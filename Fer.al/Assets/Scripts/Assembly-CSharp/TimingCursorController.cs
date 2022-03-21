using UnityEngine;

public class TimingCursorController : MonoBehaviour
{
	public float velocity;

	public int direction;

	public Rect movementBounds;

	public bool moving;

	private RectTransform rectTransform;

	private Vector3 posA;

	private Vector3 posB;

	private float width;

	private void Init()
	{
	}

	public void QuickGameUpdate()
	{
	}

	public void SetBounds(float x, float y, float width, float height)
	{
	}

	public void Stop()
	{
	}

	public bool IsStoppedInRegion(Rect region)
	{
		return default(bool);
	}
}
