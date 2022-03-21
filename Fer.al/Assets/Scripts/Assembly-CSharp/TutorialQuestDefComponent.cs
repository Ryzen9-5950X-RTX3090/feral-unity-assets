using System;
using System.Collections.Generic;

[Serializable]
[ChartComponent("TutorialQuest")]
public class TutorialQuestDefComponent : DefComponent
{
	[ChartList]
	public List<QuestDefObjective> primaryObjectives;
}
