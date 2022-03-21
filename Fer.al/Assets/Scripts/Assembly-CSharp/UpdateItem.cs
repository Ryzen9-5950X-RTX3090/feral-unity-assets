using UnityEngine;

public class UpdateItem : RemoveItem
{
	public Vector3 position;

	public Quaternion rotation;

	public int gridId;

	public string parentItemId;

	public int state;

	public UpdateItem(string denItemInvId, Vector3 position, Quaternion rotation, int gridId, string parentItemId, int state)
	{
	}

	public override void WriteData(XtWriter writer)
	{
	}
}
