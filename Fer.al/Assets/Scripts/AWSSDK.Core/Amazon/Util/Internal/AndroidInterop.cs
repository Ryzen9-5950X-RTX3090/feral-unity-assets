namespace Amazon.Util.Internal
{
	public class AndroidInterop
	{
		public static T CallStaticJavaMethod<T>(string className, string methodName, object[] parameters)
		{
			return (T)null;
		}

		public static object GetJavaObjectStatically(string className, string methodName)
		{
			return null;
		}

		public static T CallMethod<T>(object androidJavaObject, string methodName, object[] parameters)
		{
			return (T)null;
		}

		public static object CallMethod(object androidJavaObject, string methodName, object[] parameters)
		{
			return null;
		}

		public static T GetStaticJavaField<T>(string className, string methodName)
		{
			return (T)null;
		}

		public static object GetStaticJavaField(string className, string methodName)
		{
			return null;
		}

		public static T GetJavaField<T>(object androidJavaObject, string methodName)
		{
			return (T)null;
		}

		public static object GetAndroidContext()
		{
			return null;
		}
	}
}
