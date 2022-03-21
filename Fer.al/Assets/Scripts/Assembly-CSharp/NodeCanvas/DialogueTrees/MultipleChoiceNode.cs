using System;
using System.Collections.Generic;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.DialogueTrees
{
	[Icon("List", false, "")]
	[Name("Multiple Choice", 0)]
	[Category("Branch")]
	[Description("Prompt a Dialogue Multiple Choice. A choice will be available if the choice condition(s) are true or there is no choice conditions. The Actor selected is used for the condition checks and will also Say the selection if the option is checked.")]
	[Color("b3ff7f")]
	public class MultipleChoiceNode : DTNode
	{
		[Serializable]
		public class Choice
		{
			public bool isUnfolded;

			public Statement statement;

			public ConditionTask condition;

			public Choice()
			{
			}

			public Choice(Statement statement)
			{
			}
		}

		public Statement statement;

		[SliderField(0f, 10f)]
		public float availableTime;

		public bool saySelection;

		[SerializeField]
		[AutoSortWithChildrenConnections]
		private List<Choice> availableChoices;

		public bool allowNextButton;

		public List<Choice> AvailableChoices
		{
			get
			{
				return null;
			}
		}

		public override int maxOutConnections
		{
			get
			{
				return default(int);
			}
		}

		public override bool requireActorSelection
		{
			get
			{
				return default(bool);
			}
		}

		public Task[] GetSubTasks()
		{
			return null;
		}

		protected override Status OnExecute(Component agent, IBlackboard bb)
		{
			return default(Status);
		}

		private void OnOptionSelected(int index)
		{
		}
	}
}
