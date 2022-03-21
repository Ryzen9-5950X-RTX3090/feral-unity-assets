using System.Collections.Generic;

public interface IFilterable
{
	List<string> SupportedFilters { get; }

	void AddFilter(string inFilter);

	void RemoveFilter(string inFilter);
}
