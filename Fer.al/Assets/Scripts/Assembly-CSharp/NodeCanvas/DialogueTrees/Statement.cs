using System;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees
{
	[Serializable]
	public class Statement : IStatement
	{
		[SerializeField]
		private string _text;

		[SerializeField]
		private AudioClip _audio;

		[SerializeField]
		private string _meta;

		[SerializeField]
		private bool _localize;

		[SerializeField]
		private string _defId;

		public string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AudioClip audio
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string meta
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool localize
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public string defId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Statement()
		{
		}

		public Statement(string text)
		{
		}

		public Statement(string text, AudioClip audio)
		{
		}

		public Statement(string text, AudioClip audio, string meta)
		{
		}

		public IStatement BlackboardReplace(IBlackboard bb)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
