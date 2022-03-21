using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ParadoxNotion.Serialization.FullSerializer
{
	public class fsMetaProperty
	{
		public FieldInfo Field
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

		public Type StorageType
		{
			get
			{
				return null;
			}
		}

		public string MemberName
		{
			get
			{
				return null;
			}
		}

		public bool ReadOnly
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

		public bool WriteOnly
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

		public bool AutoInstance
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

		public bool AsReference
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

		public object Read(object context)
		{
			return null;
		}

		public void Write(object context, object value)
		{
		}
	}
}
