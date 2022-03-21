using System.Collections;

namespace Iss.Data
{
	public class Room
	{
		private int id;

		private string name;

		private int maxUsers;

		private int maxSpectators;

		private bool temp;

		private bool game;

		private bool priv;

		private bool limbo;

		private int userCount;

		private int specCount;

		private int myPlayerIndex;

		private Hashtable userList;

		private Hashtable variables;

		public Room(int id, string name, int maxUsers, int maxSpectators, bool isTemp, bool isGame, bool isPrivate, bool isLimbo)
		{
		}

		public Room(int id, string name, int maxUsers, int maxSpectators, bool isTemp, bool isGame, bool isPrivate, bool isLimbo, int userCount)
		{
		}

		public Room(int id, string name, int maxUsers, int maxSpectators, bool isTemp, bool isGame, bool isPrivate, bool isLimbo, int userCount, int specCount)
		{
		}

		public void AddUser(User u, int id)
		{
		}

		public void RemoveUser(int id)
		{
		}

		public Hashtable GetUserList()
		{
			return null;
		}

		public void SetUserList(Hashtable userList)
		{
		}

		public User GetUser(object userId)
		{
			return null;
		}

		public void ClearUserList()
		{
		}

		public object GetVariable(string varName)
		{
			return null;
		}

		public Hashtable GetVariables()
		{
			return null;
		}

		public void SetVariables(Hashtable vars)
		{
		}

		public void ClearVariables()
		{
		}

		public string GetName()
		{
			return null;
		}

		public int GetId()
		{
			return default(int);
		}

		public bool IsTemp()
		{
			return default(bool);
		}

		public bool IsGame()
		{
			return default(bool);
		}

		public bool IsPrivate()
		{
			return default(bool);
		}

		public int GetUserCount()
		{
			return default(int);
		}

		public int GetSpectatorCount()
		{
			return default(int);
		}

		public int GetMaxUsers()
		{
			return default(int);
		}

		public int GetMaxSpectators()
		{
			return default(int);
		}

		public void SetMyPlayerIndex(int id)
		{
		}

		public int GetMyPlayerIndex()
		{
			return default(int);
		}

		public void SetIsLimbo(bool b)
		{
		}

		public bool IsLimbo()
		{
			return default(bool);
		}

		public void SetUserCount(int n)
		{
		}

		public void SetSpectatorCount(int n)
		{
		}
	}
}
