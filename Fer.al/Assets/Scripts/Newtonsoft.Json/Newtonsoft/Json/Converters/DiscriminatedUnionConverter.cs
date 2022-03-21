using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	public class DiscriminatedUnionConverter : JsonConverter
	{
		internal class Union
		{
			public List<UnionCase> Cases;

			public FSharpFunction TagReader
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
		}

		internal class UnionCase
		{
			public int Tag;

			public string Name;

			public PropertyInfo[] Fields;

			public FSharpFunction FieldReader;

			public FSharpFunction Constructor;
		}

		private static readonly ThreadSafeStore<Type, Union> UnionCache;

		private static readonly ThreadSafeStore<Type, Type> UnionTypeLookupCache;

		private static Type CreateUnionTypeLookup(Type t)
		{
			return null;
		}

		private static Union CreateUnion(Type t)
		{
			return null;
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}
	}
}
