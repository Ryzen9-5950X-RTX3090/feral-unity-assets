using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	public class JsonDynamicContract : JsonContainerContract
	{
		[CompilerGenerated]
		private readonly JsonPropertyCollection <Properties>k__BackingField;

		private readonly ThreadSafeStore<string, CallSite<Func<CallSite, object, object>>> _callSiteGetters;

		private readonly ThreadSafeStore<string, CallSite<Func<CallSite, object, object, object>>> _callSiteSetters;

		public JsonPropertyCollection Properties
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Func<string, string> PropertyNameResolver
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

		private static CallSite<Func<CallSite, object, object>> CreateCallSiteGetter(string name)
		{
			return null;
		}

		private static CallSite<Func<CallSite, object, object, object>> CreateCallSiteSetter(string name)
		{
			return null;
		}

		public JsonDynamicContract(Type underlyingType)
		{
		}

		internal bool TryGetMember(IDynamicMetaObjectProvider dynamicProvider, string name, out object value)
		{
			return default(bool);
		}

		internal bool TrySetMember(IDynamicMetaObjectProvider dynamicProvider, string name, object value)
		{
			return default(bool);
		}
	}
}
