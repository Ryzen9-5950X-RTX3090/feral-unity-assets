using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Candlelight
{
	public class PropertyBackingFieldAttribute : PropertyAttribute
	{
		public PropertyAttribute OverrideAttribute
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

		public string PropertyName
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

		public PropertyBackingFieldAttribute()
		{
		}

		public PropertyBackingFieldAttribute(string propertyName)
		{
		}

		public PropertyBackingFieldAttribute(Type propertyAttributeType, object[] constructorArguments)
		{
		}

		public PropertyBackingFieldAttribute(string propertyName, Type propertyAttributeType, object[] constructorArguments)
		{
		}
	}
}
