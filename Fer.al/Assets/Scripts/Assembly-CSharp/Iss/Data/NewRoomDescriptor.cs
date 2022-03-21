using System.Collections;

namespace Iss.Data
{
	public class NewRoomDescriptor
	{
		public class ExtensionDescriptor
		{
			private string name;

			private string script;

			public string Name
			{
				get
				{
					return null;
				}
			}

			public string Script
			{
				get
				{
					return null;
				}
			}

			public ExtensionDescriptor(string name, string script)
			{
			}
		}

		private string name;

		private string password;

		private int maxUsers;

		private int maxSpectators;

		private bool isGame;

		private bool exitCurrentRoom;

		private bool receiveUCount;

		private ArrayList variables;

		private ExtensionDescriptor extension;

		public string Name
		{
			get
			{
				return null;
			}
		}

		public string Password
		{
			get
			{
				return null;
			}
		}

		public int MaxUsers
		{
			get
			{
				return default(int);
			}
		}

		public int MaxSpectators
		{
			get
			{
				return default(int);
			}
		}

		public bool IsGame
		{
			get
			{
				return default(bool);
			}
		}

		public bool ExitCurrentRoom
		{
			get
			{
				return default(bool);
			}
		}

		public bool ReceiveUCount
		{
			get
			{
				return default(bool);
			}
		}

		public ArrayList Variables
		{
			get
			{
				return null;
			}
		}

		public ExtensionDescriptor Extension
		{
			get
			{
				return null;
			}
		}

		public NewRoomDescriptor(string name, int maxUsers)
		{
		}

		public NewRoomDescriptor(string name, int maxUsers, bool isGame)
		{
		}

		public NewRoomDescriptor(string name, int maxUsers, bool isGame, int maxSpectators, ArrayList variables, ExtensionDescriptor extension)
		{
		}

		public NewRoomDescriptor(string name, int maxUsers, bool isGame, int maxSpectators, ArrayList variables, ExtensionDescriptor extension, string password, bool exitCurrentRoom, bool receiveUCount)
		{
		}
	}
}
