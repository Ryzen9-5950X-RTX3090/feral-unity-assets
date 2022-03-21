using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Gaia.FullSerializer.Internal
{
	public class fsMetaProperty
	{
		private MemberInfo _memberInfo;

		public Type StorageType
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

		public bool CanRead
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

		public bool CanWrite
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

		public string JsonName
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

		public string MemberName
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

		public bool IsPublic
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

		internal fsMetaProperty(FieldInfo field)
		{
		}

		internal fsMetaProperty(PropertyInfo property)
		{
		}

		public void Write(object context, object value)
		{
		}

		public object Read(object context)
		{
			return null;
		}

		private static string GetJsonName(MemberInfo member)
		{
			return null;
		}
	}
}
