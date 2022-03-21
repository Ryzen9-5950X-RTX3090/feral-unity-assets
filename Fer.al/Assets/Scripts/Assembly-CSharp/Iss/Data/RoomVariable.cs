namespace Iss.Data
{
	public class RoomVariable
	{
		private string name;

		private object value;

		private bool isPrivate;

		private bool isPersistent;

		public RoomVariable(string name, object value)
		{
		}

		public RoomVariable(string name, object value, bool isPrivate)
		{
		}

		public RoomVariable(string name, object value, bool isPrivate, bool isPersistent)
		{
		}

		public string GetName()
		{
			return null;
		}

		public object GetValue()
		{
			return null;
		}

		public bool IsPrivate()
		{
			return default(bool);
		}

		public bool IsPersistent()
		{
			return default(bool);
		}
	}
}
