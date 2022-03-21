using System.Runtime.CompilerServices;
using UnityEngine;

namespace ParadoxNotion
{
	public struct EventData : IEventData
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

		public object value
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

		public object valueBoxed
		{
			get
			{
				return null;
			}
		}

		public EventData(object value, GameObject receiver, object sender)
		{
		}

		public EventData(GameObject receiver, object sender)
		{
		}
	}
}
