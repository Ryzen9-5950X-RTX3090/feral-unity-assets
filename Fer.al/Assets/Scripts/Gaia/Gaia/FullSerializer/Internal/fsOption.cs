namespace Gaia.FullSerializer.Internal
{
	public static class fsOption
	{
		public static fsOption<T> Just<T>(T value)
		{
			return default(fsOption<T>);
		}
	}
}
