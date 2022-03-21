using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
	public abstract class JsonContainerAttribute : Attribute
	{
		[CompilerGenerated]
		private Type <ItemConverterType>k__BackingField;

		[CompilerGenerated]
		private object[] <ItemConverterParameters>k__BackingField;

		internal bool? _isReference;

		internal bool? _itemIsReference;

		internal ReferenceLoopHandling? _itemReferenceLoopHandling;

		internal TypeNameHandling? _itemTypeNameHandling;

		private Type _namingStrategyType;

		private object[] _namingStrategyParameters;

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
			get
			{
				return null;
			}
		}

		public object[] NamingStrategyParameters
		{
			get
			{
				return null;
			}
		}

		internal NamingStrategy NamingStrategyInstance
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
}
