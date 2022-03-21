namespace VivoxUnity
{
	public struct Presence
	{
		public readonly PresenceStatus Status;

		public readonly string Message;

		public Presence(PresenceStatus status, string message)
		{
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		private bool Equals(Presence other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
