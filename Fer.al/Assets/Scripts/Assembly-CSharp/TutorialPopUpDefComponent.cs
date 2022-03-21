using System.Collections.Generic;

[ChartComponent("Tutorial Pop-Up")]
public class TutorialPopUpDefComponent : DefComponent
{
	[ChartList]
	public List<TutorialPageInfo> pages;

	[ChartList]
	public List<TutorialPageInfo> mobileOverridePages;
}
