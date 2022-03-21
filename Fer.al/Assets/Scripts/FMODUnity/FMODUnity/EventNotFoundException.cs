using System;

namespace FMODUnity
{
	public class EventNotFoundException : Exception
	{
		public Guid Guid;

		public string Path;

		public EventNotFoundException(string path)
		{
		}

		public EventNotFoundException(Guid guid)
		{
		}
	}
}
