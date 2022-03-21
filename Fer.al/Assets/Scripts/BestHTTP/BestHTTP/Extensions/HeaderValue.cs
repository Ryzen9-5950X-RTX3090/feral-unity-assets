using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BestHTTP.Extensions
{
	public sealed class HeaderValue
	{
		public string Key
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
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
			set
			{
			}
		}

		public List<HeaderValue> Options
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool HasValue
		{
			get
			{
				return default(bool);
			}
		}

		public HeaderValue()
		{
		}

		public HeaderValue(string key)
		{
		}

		public void Parse(string headerStr, ref int pos)
		{
		}

		public bool TryGetOption(string key, out HeaderValue option)
		{
			return default(bool);
		}

		private void ParseImplementation(string headerStr, ref int pos, bool isOptionIsAnOption)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
