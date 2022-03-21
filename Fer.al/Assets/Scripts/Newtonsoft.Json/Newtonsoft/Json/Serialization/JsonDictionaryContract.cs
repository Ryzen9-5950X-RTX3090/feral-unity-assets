using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	public class JsonDictionaryContract : JsonContainerContract
	{
		[CompilerGenerated]
		private readonly Type <DictionaryKeyType>k__BackingField;

		[CompilerGenerated]
		private readonly Type <DictionaryValueType>k__BackingField;

		private readonly Type _genericCollectionDefinitionType;

		private Type _genericWrapperType;

		private ObjectConstructor<object> _genericWrapperCreator;

		private Func<object> _genericTemporaryDictionaryCreator;

		[CompilerGenerated]
		private readonly bool <ShouldCreateWrapper>k__BackingField;

		private readonly ConstructorInfo _parameterizedConstructor;

		private ObjectConstructor<object> _overrideCreator;

		private ObjectConstructor<object> _parameterizedCreator;

		public Func<string, string> DictionaryKeyResolver
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

		public Type DictionaryKeyType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Type DictionaryValueType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal JsonContract KeyContract
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

		internal bool ShouldCreateWrapper
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		internal ObjectConstructor<object> ParameterizedCreator
		{
			get
			{
				return null;
			}
		}

		public ObjectConstructor<object> OverrideCreator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool HasParameterizedCreator
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

		internal bool HasParameterizedCreatorInternal
		{
			get
			{
				return default(bool);
			}
		}

		public JsonDictionaryContract(Type underlyingType)
		{
		}

		internal IWrappedDictionary CreateWrapper(object dictionary)
		{
			return null;
		}

		internal IDictionary CreateTemporaryDictionary()
		{
			return null;
		}
	}
}
