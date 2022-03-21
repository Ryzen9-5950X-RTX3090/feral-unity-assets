using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees
{
	[GraphInfo]
	[CreateAssetMenu]
	public class DialogueTree : Graph
	{
		[Serializable]
		private class DerivedSerializationData
		{
			public List<ActorParameter> actorParameters;
		}

		[Serializable]
		public class ActorParameter
		{
			[SerializeField]
			private string _keyName;

			[SerializeField]
			private string _id;

			[SerializeField]
			private UnityEngine.Object _actorObject;

			[NonSerialized]
			private IDialogueActor _actor;

			public string name
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public string ID
			{
				get
				{
					return null;
				}
			}

			public IDialogueActor actor
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public ActorParameter()
			{
			}

			public ActorParameter(string name)
			{
			}

			public ActorParameter(string name, IDialogueActor actor)
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		public const string INSTIGATOR_NAME = "INSTIGATOR";

		[SerializeField]
		public List<ActorParameter> actorParameters;

		public static DialogueTree currentDialogue
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static DialogueTree previousDialogue
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DTNode currentNode
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public override Type baseNodeType
		{
			get
			{
				return null;
			}
		}

		public override bool requiresAgent
		{
			get
			{
				return default(bool);
			}
		}

		public override bool requiresPrimeNode
		{
			get
			{
				return default(bool);
			}
		}

		public override bool isTree
		{
			get
			{
				return default(bool);
			}
		}

		public override bool allowBlackboardOverrides
		{
			get
			{
				return default(bool);
			}
		}

		public sealed override bool canAcceptVariableDrops
		{
			get
			{
				return default(bool);
			}
		}

		public List<string> definedActorParameterNames
		{
			get
			{
				return null;
			}
		}

		public static event Action<DialogueTree> OnDialogueStarted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<DialogueTree> OnDialoguePaused
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<DialogueTree> OnDialogueFinished
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<SubtitlesRequestInfo> OnSubtitlesRequest
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<MultipleChoiceRequestInfo> OnMultipleChoiceRequest
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public override object OnDerivedDataSerialization()
		{
			return null;
		}

		public override void OnDerivedDataDeserialization(object data)
		{
		}

		public ActorParameter GetParameterByID(string id)
		{
			return null;
		}

		public ActorParameter GetParameterByName(string paramName)
		{
			return null;
		}

		public IDialogueActor GetActorReferenceByID(string id)
		{
			return null;
		}

		public IDialogueActor GetActorReferenceByName(string paramName)
		{
			return null;
		}

		public void SetActorReference(string paramName, IDialogueActor actor)
		{
		}

		public void SetActorReferences(Dictionary<string, IDialogueActor> actors)
		{
		}

		public void Continue(int index = 0)
		{
		}

		public void EnterNode(DTNode node)
		{
		}

		public static void RequestSubtitles(SubtitlesRequestInfo info)
		{
		}

		public static void RequestMultipleChoices(MultipleChoiceRequestInfo info)
		{
		}

		protected override void OnGraphStarted()
		{
		}

		protected override void OnGraphUpdate()
		{
		}

		protected override void OnGraphStoped()
		{
		}

		protected override void OnGraphPaused()
		{
		}

		protected override void OnGraphUnpaused()
		{
		}

		[CoreResetTarget]
		[RuntimeInitializeOnLoadMethod]
		public static void ResetStaticVariables()
		{
		}
	}
}
