namespace Rewired
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal struct RewiredVersion
	{
		public int version1;

		public int version2;

		public int version3;

		public int version4;

		public string unityVersion;

		public RewiredVersion(int version1, int version2, int version3, int version4, string unityVersion)
		{
		}

		public RewiredVersion(string versionString)
		{
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}

		public static bool operator ==(RewiredVersion a, RewiredVersion b)
		{
			return default(bool);
		}

		public static bool operator !=(RewiredVersion a, RewiredVersion b)
		{
			return default(bool);
		}

		public static bool operator >(RewiredVersion a, RewiredVersion b)
		{
			return default(bool);
		}

		public static bool operator <(RewiredVersion a, RewiredVersion b)
		{
			return default(bool);
		}
	}
}
