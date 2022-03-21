using System.Runtime.CompilerServices;
using UnityEngine;

namespace ParadoxNotion
{
	public struct EventData<T> : IEventData
	{
		public GameObject receiver
		{
			[IsReadOnly]
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

		public object sender
		{
			[IsReadOnly]
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

		public T value
		{
			[IsReadOnly]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public object valueBoxed
		{
			get
			{
				return null;
			}
		}

		public EventData(T value, GameObject receiver, object sender)
		{
		}
	}
}
