namespace Candlelight
{
	public abstract class Singleton<T> where T : Singleton<T>, new()
	{
		private static T s_Instance;

		public static T Instance
		{
			get
			{
				return null;
			}
		}
	}
}
