using System.Collections;

public class ChartListAttribute : ChartDrawableFieldAttribute
{
	public bool horizontalLayout;

	public ChartDrawableAttribute drawAttribute;

	private IList _listInstance;

	public IList ListInstance
	{
		get
		{
			return null;
		}
	}

	public ChartListAttribute()
	{
	}

	public ChartListAttribute(bool inHorizontalLayout)
	{
	}
}
