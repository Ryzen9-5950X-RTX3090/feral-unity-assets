using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	public sealed class JsonPropertyAttribute : Attribute
	{
		internal NullValueHandling? _nullValueHandling;

		internal DefaultValueHandling? _defaultValueHandling;

		internal ReferenceLoopHandling? _referenceLoopHandling;

		internal ObjectCreationHandling? _objectCreationHandling;

		internal TypeNameHandling? _typeNameHandling;

		internal bool? _isReference;

		internal int? _order;

		internal Required? _required;

		internal bool? _itemIsReference;

		internal ReferenceLoopHandling? _itemReferenceLoopHandling;

		internal TypeNameHandling? _itemTypeNameHandling;

		[CompilerGenerated]
		private Type <ItemConverterType>k__BackingField;

		[CompilerGenerated]
		private object[] <ItemConverterParameters>k__BackingField;

		[CompilerGenerated]
		private Type <NamingStrategyType>k__BackingField;

		[CompilerGenerated]
		private object[] <NamingStrategyParameters>k__BackingField;

		[CompilerGenerated]
		private string <PropertyName>k__BackingField;

		public Type ItemConverterType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public object[] ItemConverterParameters
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Type NamingStrategyType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public object[] NamingStrategyParameters
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string PropertyName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
}
