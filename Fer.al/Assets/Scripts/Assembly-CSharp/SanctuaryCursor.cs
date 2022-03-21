using UnityEngine;

[ManagedBehaviourManager("SanctuaryManager")]
public class SanctuaryCursor : ManagedBehaviour
{
	private CursorManager.MouseCursorType _cursorType;

	public static GameObject Create(CursorManager.MouseCursorType inCursor)
	{
		return null;
	}

	public void SetCursorType(CursorManager.MouseCursorType inCursor)
	{
	}

	public override void MOnDestroy()
	{
	}

	public override void MOnEnable()
	{
	}

	public override void MOnDisable()
	{
	}
}
