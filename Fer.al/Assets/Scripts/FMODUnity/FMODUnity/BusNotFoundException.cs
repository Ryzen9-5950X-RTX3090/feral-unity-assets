using System;

namespace FMODUnity
{
	public class BusNotFoundException : Exception
	{
		public string Path;

		public BusNotFoundException(string path)
		{
		}
	}
}
