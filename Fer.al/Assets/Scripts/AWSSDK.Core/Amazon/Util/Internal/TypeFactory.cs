using System;
using System.Collections.Generic;
using System.Reflection;

namespace Amazon.Util.Internal
{
	public static class TypeFactory
	{
		private abstract class AbstractTypeInfo : ITypeInfo
		{
			protected Type _type;

			public Type Type
			{
				get
				{
					return null;
				}
			}

			public abstract Type BaseType { get; }

			public abstract Assembly Assembly { get; }

			public abstract bool IsClass { get; }

			public abstract bool IsInterface { get; }

			public abstract bool IsAbstract { get; }

			public abstract bool IsSealed { get; }

			public abstract bool IsEnum { get; }

			public abstract bool IsValueType { get; }

			public abstract bool ContainsGenericParameters { get; }

			public abstract bool IsGenericTypeDefinition { get; }

			public abstract bool IsGenericType { get; }

			public bool IsArray
			{
				get
				{
					return default(bool);
				}
			}

			public string FullName
			{
				get
				{
					return null;
				}
			}

			public string Name
			{
				get
				{
					return null;
				}
			}

			internal AbstractTypeInfo(Type type)
			{
			}

			public override int GetHashCode()
			{
				return default(int);
			}

			public override bool Equals(object obj)
			{
				return default(bool);
			}

			public bool IsType(Type type)
			{
				return default(bool);
			}

			public abstract Type GetInterface(string name);

			public abstract Type[] GetInterfaces();

			public abstract IEnumerable<PropertyInfo> GetProperties();

			public abstract IEnumerable<FieldInfo> GetFields();

			public abstract FieldInfo GetField(string name);

			public abstract MethodInfo GetMethod(string name);

			public abstract MethodInfo GetMethod(string name, ITypeInfo[] paramTypes);

			public abstract MemberInfo[] GetMembers();

			public abstract PropertyInfo GetProperty(string name);

			public abstract bool IsAssignableFrom(ITypeInfo typeInfo);

			public abstract ConstructorInfo GetConstructor(ITypeInfo[] paramTypes);

			public abstract object[] GetCustomAttributes(bool inherit);

			public abstract object[] GetCustomAttributes(ITypeInfo attributeType, bool inherit);

			public abstract Type GetGenericTypeDefinition();

			public abstract Type[] GetGenericArguments();

			public object EnumToObject(object value)
			{
				return null;
			}

			public ITypeInfo EnumGetUnderlyingType()
			{
				return null;
			}

			public object CreateInstance()
			{
				return null;
			}

			public Array ArrayCreateInstance(int length)
			{
				return null;
			}

			public ITypeInfo GetElementType()
			{
				return null;
			}
		}

		private class TypeInfoWrapper : AbstractTypeInfo
		{
			public override Type BaseType
			{
				get
				{
					return null;
				}
			}

			public override bool IsClass
			{
				get
				{
					return default(bool);
				}
			}

			public override bool IsValueType
			{
				get
				{
					return default(bool);
				}
			}

			public override bool IsInterface
			{
				get
				{
					return default(bool);
				}
			}

			public override bool IsAbstract
			{
				get
				{
					return default(bool);
				}
			}

			public override bool IsSealed
			{
				get
				{
					return default(bool);
				}
			}

			public override bool IsEnum
			{
				get
				{
					return default(bool);
				}
			}

			public override bool ContainsGenericParameters
			{
				get
				{
					return default(bool);
				}
			}

			public override bool IsGenericTypeDefinition
			{
				get
				{
					return default(bool);
				}
			}

			public override bool IsGenericType
			{
				get
				{
					return default(bool);
				}
			}

			public override Assembly Assembly
			{
				get
				{
					return null;
				}
			}

			internal TypeInfoWrapper(Type type)
			{
			}

			public override FieldInfo GetField(string name)
			{
				return null;
			}

			public override Type GetInterface(string name)
			{
				return null;
			}

			public override Type[] GetInterfaces()
			{
				return null;
			}

			public override IEnumerable<PropertyInfo> GetProperties()
			{
				return null;
			}

			public override IEnumerable<FieldInfo> GetFields()
			{
				return null;
			}

			public override MemberInfo[] GetMembers()
			{
				return null;
			}

			public override MethodInfo GetMethod(string name)
			{
				return null;
			}

			public override MethodInfo GetMethod(string name, ITypeInfo[] paramTypes)
			{
				return null;
			}

			public override ConstructorInfo GetConstructor(ITypeInfo[] paramTypes)
			{
				return null;
			}

			public override PropertyInfo GetProperty(string name)
			{
				return null;
			}

			public override bool IsAssignableFrom(ITypeInfo typeInfo)
			{
				return default(bool);
			}

			public override Type GetGenericTypeDefinition()
			{
				return null;
			}

			public override Type[] GetGenericArguments()
			{
				return null;
			}

			public override object[] GetCustomAttributes(bool inherit)
			{
				return null;
			}

			public override object[] GetCustomAttributes(ITypeInfo attributeType, bool inherit)
			{
				return null;
			}
		}

		public static readonly ITypeInfo[] EmptyTypes;

		public static ITypeInfo GetTypeInfo(Type type)
		{
			return null;
		}
	}
}
