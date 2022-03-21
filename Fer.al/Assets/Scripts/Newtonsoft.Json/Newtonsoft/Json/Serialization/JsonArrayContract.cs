using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	public class JsonArrayContract : JsonContainerContract
	{
		[CompilerGenerated]
		private readonly Type <CollectionItemType>k__BackingField;

		[CompilerGenerated]
		private readonly bool <IsMultidimensionalArray>k__BackingField;

		private readonly Type _genericCollectionDefinitionType;

		private Type _genericWrapperType;

		private ObjectConstructor<object> _genericWrapperCreator;

		private Func<object> _genericTemporaryCollectionCreator;

		[CompilerGenerated]
		private readonly bool <IsArray>k__BackingField;

		[CompilerGenerated]
		private readonly bool <ShouldCreateWrapper>k__BackingField;

		private readonly ConstructorInfo _parameterizedConstructor;

		private ObjectConstructor<object> _parameterizedCreator;

		private ObjectConstructor<object> _overrideCreator;

		public Type CollectionItemType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public bool IsMultidimensionalArray
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		internal bool IsArray
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
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

		internal bool CanDeserialize
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

		public JsonArrayContract(Type underlyingType)
		{
		}

		internal IWrappedCollection CreateWrapper(object list)
		{
			return null;
		}

		internal IList CreateTemporaryCollection()
		{
			return null;
		}

		private void StoreFSharpListCreatorIfNecessary(Type underlyingType)
		{
		}
	}
}
