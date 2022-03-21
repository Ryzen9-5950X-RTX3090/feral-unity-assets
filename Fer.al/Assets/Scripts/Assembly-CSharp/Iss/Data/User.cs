using System.Collections;

namespace Iss.Data
{
	public class User
	{
		private int id;

		private string name;

		private Hashtable variables;

		private bool isSpec;

		private bool isMod;

		private int pId;

		public User(int id, string name)
		{
		}

		public int GetId()
		{
			return default(int);
		}

		public string GetName()
		{
			return null;
		}

		public object GetVariable(string varName)
		{
			return null;
		}

		public Hashtable GetVariables()
		{
			return null;
		}

		public void SetVariables(Hashtable o)
		{
		}

		internal void ClearVariables()
		{
		}

		public void SetIsSpectator(bool b)
		{
		}

		public bool IsSpectator()
		{
			return default(bool);
		}

		public void SetModerator(bool b)
		{
		}

		public bool IsModerator()
		{
			return default(bool);
		}

		public int GetPlayerId()
		{
			return default(int);
		}

		public void SetPlayerId(int pid)
		{
		}
	}
}
