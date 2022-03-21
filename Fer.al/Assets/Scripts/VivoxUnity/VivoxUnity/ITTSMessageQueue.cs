using System;
using System.Collections;
using System.Collections.Generic;

namespace VivoxUnity
{
	public interface ITTSMessageQueue : IEnumerable<TTSMessage>, IEnumerable
	{
		int Count { get; }

		event EventHandler<ITTSMessageQueueEventArgs> AfterMessageAdded;

		event EventHandler<ITTSMessageQueueEventArgs> BeforeMessageRemoved;

		event EventHandler<ITTSMessageQueueEventArgs> AfterMessageUpdated;

		void Clear();

		bool Contains(TTSMessage message);

		TTSMessage Dequeue();

		void Enqueue(TTSMessage message);

		TTSMessage Peek();

		bool Remove(TTSMessage message);
	}
}
