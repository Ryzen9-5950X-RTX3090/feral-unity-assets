using System.Collections.Generic;

[ChartComponent("Tag")]
public class TagDefComponent : DefComponent
{
	[ChartList]
	public List<string> localizedTagDefIds;

	private List<string> _tags;

	public List<string> Tags
	{
		get
		{
			return null;
		}
	}
}
