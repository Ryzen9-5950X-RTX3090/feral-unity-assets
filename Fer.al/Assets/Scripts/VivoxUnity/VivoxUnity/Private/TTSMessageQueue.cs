using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace VivoxUnity.Private
{
	internal sealed class TTSMessageQueue : ITTSMessageQueue, IEnumerable<TTSMessage>, IEnumerable
	{
		private readonly List<TTSMessage> _messages;

		private TextToSpeech _parentTTS;

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public event EventHandler<ITTSMessageQueueEventArgs> AfterMessageAdded
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

		public event EventHandler<ITTSMessageQueueEventArgs> BeforeMessageRemoved
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

		public event EventHandler<ITTSMessageQueueEventArgs> AfterMessageUpdated
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

		internal TTSMessageQueue(TextToSpeech tts)
		{
		}

		internal void Cleanup([Optional] TTSMessage message)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(TTSMessage message)
		{
			return default(bool);
		}

		public TTSMessage Dequeue()
		{
			return null;
		}

		public void Enqueue(TTSMessage message)
		{
		}

		private void OnMessage_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
		}

		public TTSMessage Peek()
		{
			return null;
		}

		public bool Remove(TTSMessage message)
		{
			return default(bool);
		}

		public IEnumerator<TTSMessage> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
