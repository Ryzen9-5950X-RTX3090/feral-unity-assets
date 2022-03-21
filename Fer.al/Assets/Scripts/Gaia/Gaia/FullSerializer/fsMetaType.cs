using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer.Internal;

namespace Gaia.FullSerializer
{
	public class fsMetaType
	{
		private static Dictionary<Type, fsMetaType> _metaTypes;

		public Type ReflectedType;

		private bool _hasEmittedAotData;

		private bool? _hasDefaultConstructorCache;

		private bool _isDefaultConstructorPublic;

		public fsMetaProperty[] Properties
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

		public bool HasDefaultConstructor
		{
			get
			{
				return default(bool);
			}
		}

		public static fsMetaType Get(Type type)
		{
			return null;
		}

		public static void ClearCache()
		{
		}

		private fsMetaType(Type reflectedType)
		{
		}

		private static void CollectProperties(List<fsMetaProperty> properties, Type reflectedType)
		{
		}

		private static bool IsAutoProperty(PropertyInfo property, MemberInfo[] members)
		{
			return default(bool);
		}

		private static bool CanSerializeProperty(PropertyInfo property, MemberInfo[] members, bool annotationFreeValue)
		{
			return default(bool);
		}

		private static bool CanSerializeField(FieldInfo field, bool annotationFreeValue)
		{
			return default(bool);
		}

		public bool EmitAotData()
		{
			return default(bool);
		}

		public object CreateInstance()
		{
			return null;
		}
	}
}
