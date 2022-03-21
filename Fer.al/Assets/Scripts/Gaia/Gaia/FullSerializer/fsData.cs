using System.Collections.Generic;
using System.Diagnostics;

namespace Gaia.FullSerializer
{
	public sealed class fsData
	{
		private object _value;

		public static readonly fsData True;

		public static readonly fsData False;

		public static readonly fsData Null;

		public fsDataType Type
		{
			get
			{
				return default(fsDataType);
			}
		}

		public bool IsNull
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsDouble
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsInt64
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsUInt64
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsBool
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsString
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsDictionary
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsList
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public double AsDouble
		{
			get
			{
				return default(double);
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public long AsInt64
		{
			get
			{
				return default(long);
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ulong AsUInt64
		{
			get
			{
				return default(ulong);
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public bool AsBool
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string AsString
		{
			get
			{
				return null;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Dictionary<string, fsData> AsDictionary
		{
			get
			{
				return null;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public List<fsData> AsList
		{
			get
			{
				return null;
			}
		}

		public fsData()
		{
		}

		public fsData(bool boolean)
		{
		}

		public fsData(double f)
		{
		}

		public fsData(long i)
		{
		}

		public fsData(ulong i)
		{
		}

		public fsData(string str)
		{
		}

		public fsData(Dictionary<string, fsData> dict)
		{
		}

		public fsData(List<fsData> list)
		{
		}

		public static fsData CreateDictionary()
		{
			return null;
		}

		public static fsData CreateList()
		{
			return null;
		}

		public static fsData CreateList(int capacity)
		{
			return null;
		}

		internal void BecomeDictionary()
		{
		}

		internal fsData Clone()
		{
			return null;
		}

		private T Cast<T>()
		{
			return (T)null;
		}

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public bool Equals(fsData other)
		{
			return default(bool);
		}

		public static bool operator ==(fsData a, fsData b)
		{
			return default(bool);
		}

		public static bool operator !=(fsData a, fsData b)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
