using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	public class ErrorContext
	{
		[CompilerGenerated]
		private readonly Exception <Error>k__BackingField;

		[CompilerGenerated]
		private bool <Handled>k__BackingField;

		internal bool Traced
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Exception Error
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public bool Handled
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		internal ErrorContext(object originalObject, object member, string path, Exception error)
		{
		}
	}
}
