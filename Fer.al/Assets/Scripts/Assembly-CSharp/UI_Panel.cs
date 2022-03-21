using UnityEngine;

public class UI_Panel : ManagedBehaviour
{
	[SerializeField]
	protected GameObject _selectOnFocus;

	protected GameObject _previouslySelectedObject;

	public bool IsFocused
	{
		get
		{
			return default(bool);
		}
	}

	public virtual void OnReceiveFocus()
	{
	}

	public virtual void OnLoseFocus()
	{
	}

	public override void MOnDestroy()
	{
	}
}
