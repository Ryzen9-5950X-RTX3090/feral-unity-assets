using System;

namespace Gaia.FullSerializer
{
	public static class fsConfig
	{
		public static Type[] SerializeAttributes;

		public static Type[] IgnoreSerializeAttributes;

		private static fsMemberSerialization _defaultMemberSerialization;

		public static bool SerializeNonAutoProperties;

		public static bool SerializeNonPublicSetProperties;

		public static bool IsCaseSensitive;

		public static string CustomDateTimeFormatString;

		public static bool Serialize64BitIntegerAsString;

		public static bool SerializeEnumsAsInteger;

		public static fsMemberSerialization DefaultMemberSerialization
		{
			get
			{
				return default(fsMemberSerialization);
			}
			set
			{
			}
		}
	}
}
