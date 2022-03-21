using System;
using UnityEngine;

namespace NodeCanvas.DialogueTrees
{
	[Serializable]
	public class ProxyDialogueActor : IDialogueActor
	{
		private string _name;

		private Transform _transform;

		public string name
		{
			get
			{
				return null;
			}
		}

		public Texture2D portrait
		{
			get
			{
				return null;
			}
		}

		public Sprite portraitSprite
		{
			get
			{
				return null;
			}
		}

		public Color dialogueColor
		{
			get
			{
				return default(Color);
			}
		}

		public Vector3 dialoguePosition
		{
			get
			{
				return default(Vector3);
			}
		}

		public Transform transform
		{
			get
			{
				return null;
			}
		}

		public ProxyDialogueActor(string name, Transform transform)
		{
		}
	}
}
