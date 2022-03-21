using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ParadoxNotion.Serialization.FullSerializer
{
	public class fsMetaType
	{
		private delegate object ObjectGenerator();

		private static Dictionary<Type, fsMetaType> _metaTypes;

		private static Dictionary<Type, object> _defaultInstances;

		private ObjectGenerator generator;

		public Type reflectedType
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

		public bool DeserializeOverwriteRequest
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

		public static fsMetaType Get(Type type)
		{
			return null;
		}

		public static void FlushMem()
		{
		}

		private fsMetaType(Type reflectedType)
		{
		}

		private static void CollectProperties(List<fsMetaProperty> properties, Type reflectedType)
		{
		}

		public static bool CanSerializeField(FieldInfo field)
		{
			return default(bool);
		}

		private static ObjectGenerator GetGenerator(Type reflectedType)
		{
			return null;
		}

		private static bool HasDefaultConstructor(Type reflectedType)
		{
			return default(bool);
		}

		public object GetDefaultInstance()
		{
			return null;
		}

		public object CreateInstance()
		{
			return null;
		}
	}
}
