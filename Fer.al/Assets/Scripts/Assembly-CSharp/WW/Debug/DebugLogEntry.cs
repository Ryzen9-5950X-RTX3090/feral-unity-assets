using System;
using UnityEngine;

namespace WW.Debug
{
	public class DebugLogEntry : IEquatable<DebugLogEntry>
	{
		private const int HASH_NOT_CALCULATED = -623218;

		public string logString;

		public string stackTrace;

		private string completeLog;

		public Sprite logTypeSpriteRepresentation;

		public int count;

		private int hashValue;

		public DebugLogEntry(string logString, string stackTrace, Sprite sprite)
		{
		}

		public bool Equals(DebugLogEntry other)
		{
			return default(bool);
		}

		public bool Search(string inSearchString)
		{
			return default(bool);
		}

		public override string ToString()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
