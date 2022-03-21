using System.Runtime.CompilerServices;

namespace Iss
{
	public class OnConnectionMessage : Message
	{
		public bool Success
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string Error
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

		public OnConnectionMessage(string inEventID, bool inSuccess, string inError)
		{
		}
	}
}
