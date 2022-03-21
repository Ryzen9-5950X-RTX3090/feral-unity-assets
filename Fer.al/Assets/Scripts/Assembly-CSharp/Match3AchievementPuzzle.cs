using System;
using System.Collections.Generic;

[Serializable]
public class Match3AchievementPuzzle
{
	[ChartDef("Image", new string[] { })]
	public string portraitImageRef;

	[ChartDef("Localization", new string[] { })]
	public string portraitNameRef;

	[ChartList]
	public List<Match3Achievement> achievements;

	public bool IsCompleted
	{
		get
		{
			return default(bool);
		}
	}
}
