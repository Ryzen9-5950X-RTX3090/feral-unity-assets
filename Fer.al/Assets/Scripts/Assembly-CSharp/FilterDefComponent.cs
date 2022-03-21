using System.Collections.Generic;

[ChartComponent("Filter")]
public class FilterDefComponent : DefComponent
{
	[ChartList]
	public List<string> localizedFilterDefIds;

	private List<string> _filters;

	public List<string> Filters
	{
		get
		{
			return null;
		}
	}

	private void AddAutomaticFilters()
	{
	}

	private void AddAttachPointFilter()
	{
	}

	private void AddFurnitureCategoryFilter()
	{
	}

	private void AddInventoryCategoryFilter()
	{
	}

	private void AddColorFilter()
	{
	}

	private void AddRarityFilter()
	{
	}
}
