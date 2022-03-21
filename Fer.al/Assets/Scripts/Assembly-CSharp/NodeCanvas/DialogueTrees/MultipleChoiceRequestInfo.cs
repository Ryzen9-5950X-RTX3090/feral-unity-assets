using System;
using System.Collections.Generic;

namespace NodeCanvas.DialogueTrees
{
	public class MultipleChoiceRequestInfo
	{
		public IDialogueActor actor;

		public Dictionary<IStatement, int> options;

		public float availableTime;

		public bool showLastStatement;

		public Action<int> SelectOption;

		public IStatement statement;

		public bool allowNextButton;

		public MultipleChoiceRequestInfo(IDialogueActor actor, IStatement statement, Dictionary<IStatement, int> options, float availableTime, bool showLastStatement, Action<int> callback, bool allowNextButton)
		{
		}

		public MultipleChoiceRequestInfo(IDialogueActor actor, IStatement statement, Dictionary<IStatement, int> options, float availableTime, Action<int> callback, bool allowNextButton)
		{
		}
	}
}
