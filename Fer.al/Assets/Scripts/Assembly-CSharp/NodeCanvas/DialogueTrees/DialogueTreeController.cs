using System;
using System.Collections.Generic;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees
{
	[AddComponentMenu("NodeCanvas/Dialogue Tree Controller")]
	public class DialogueTreeController : GraphOwner<DialogueTree>, IDialogueActor
	{
		string IDialogueActor.name
		{
			get
			{
				return null;
			}
		}

		Texture2D IDialogueActor.portrait
		{
			get
			{
				return null;
			}
		}

		Sprite IDialogueActor.portraitSprite
		{
			get
			{
				return null;
			}
		}

		Color IDialogueActor.dialogueColor
		{
			get
			{
				return default(Color);
			}
		}

		Vector3 IDialogueActor.dialoguePosition
		{
			get
			{
				return default(Vector3);
			}
		}

		Transform IDialogueActor.transform
		{
			get
			{
				return null;
			}
		}

		public void StartDialogue()
		{
		}

		public void StartDialogue(Action<bool> callback)
		{
		}

		public void StartDialogue(IDialogueActor instigator)
		{
		}

		public void StartDialogue(DialogueTree newTree, IDialogueActor instigator, Action<bool> callback)
		{
		}

		public void StartDialogue(IDialogueActor instigator, Action<bool> callback)
		{
		}

		public void PauseDialogue()
		{
		}

		public void StopDialogue()
		{
		}

		public void SetActorReference(string paramName, IDialogueActor actor)
		{
		}

		public void SetActorReferences(Dictionary<string, IDialogueActor> actors)
		{
		}

		public IDialogueActor GetActorReferenceByName(string paramName)
		{
			return null;
		}
	}
}
