using System;

[Serializable]
public class LazyLayoutInfo
{
	public bool ignoreLayout;

	public float minWidth;

	public float minHeight;

	public float preferredWidth;

	public float preferredHeight;

	public float flexibleWidth;

	public float flexibleHeight;

	public int layoutPriority;
}
