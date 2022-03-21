using System;
using System.Runtime.CompilerServices;

namespace VivoxUnity
{
	public sealed class QueueItemAddedEventArgs<T> : EventArgs
	{
		[CompilerGenerated]
		private readonly T <Value>k__BackingField;

		public T Value
		{
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
		}

		public QueueItemAddedEventArgs(T item)
		{
		}
	}
}
