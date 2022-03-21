using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using BestHTTP.Extensions;
using BestHTTP.Logger;

namespace BestHTTP.Cookies
{
	public sealed class Cookie : IComparable<Cookie>, IEquatable<Cookie>
	{
		private const int Version = 1;

		public string Name
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

		public string Value
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

		public DateTime Date
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public DateTime LastAccess
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public DateTime Expires
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public long MaxAge
		{
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsSession
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

		public string Domain
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

		public string Path
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

		public bool IsSecure
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

		public bool IsHttpOnly
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

		public string SameSite
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

		public Cookie(string name, string value)
		{
		}

		public Cookie(string name, string value, string path)
		{
		}

		public Cookie(string name, string value, string path, string domain)
		{
		}

		public Cookie(Uri uri, string name, string value, DateTime expires, bool isSession = true)
		{
		}

		public Cookie(Uri uri, string name, string value, long maxAge = -1L, bool isSession = true)
		{
		}

		internal Cookie()
		{
		}

		public bool WillExpireInTheFuture()
		{
			return default(bool);
		}

		public uint GuessSize()
		{
			return default(uint);
		}

		public static Cookie Parse(string header, Uri defaultDomain, LoggingContext context)
		{
			return null;
		}

		internal void SaveTo(BinaryWriter stream)
		{
		}

		internal void LoadFrom(BinaryReader stream)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public bool Equals(Cookie cookie)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		private static string ReadValue(string str, ref int pos)
		{
			return null;
		}

		private static List<HeaderValue> ParseCookieHeader(string str)
		{
			return null;
		}

		public int CompareTo(Cookie other)
		{
			return default(int);
		}
	}
}
