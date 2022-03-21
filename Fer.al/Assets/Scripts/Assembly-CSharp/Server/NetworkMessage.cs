using System.Runtime.CompilerServices;

namespace Server
{
	public abstract class NetworkMessage : IMessage
	{
		[CompilerGenerated]
		private readonly string <Cmd>k__BackingField;

		public virtual string Cmd
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string EventId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal MessageRouteInfo RouteInfo
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual void ReturnToPool()
		{
		}
	}
}
