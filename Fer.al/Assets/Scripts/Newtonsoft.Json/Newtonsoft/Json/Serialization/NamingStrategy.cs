using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	public abstract class NamingStrategy
	{
		[CompilerGenerated]
		private bool <ProcessDictionaryKeys>k__BackingField;

		[CompilerGenerated]
		private bool <ProcessExtensionDataNames>k__BackingField;

		[CompilerGenerated]
		private bool <OverrideSpecifiedNames>k__BackingField;

		public bool ProcessDictionaryKeys
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		public bool ProcessExtensionDataNames
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		public bool OverrideSpecifiedNames
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		public virtual string GetPropertyName(string name, bool hasSpecifiedName)
		{
			return null;
		}

		public virtual string GetExtensionDataName(string name)
		{
			return null;
		}

		public virtual string GetDictionaryKey(string key)
		{
			return null;
		}

		protected abstract string ResolvePropertyName(string name);

		public override int GetHashCode()
		{
			return default(int);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		protected bool Equals(NamingStrategy other)
		{
			return default(bool);
		}
	}
}
