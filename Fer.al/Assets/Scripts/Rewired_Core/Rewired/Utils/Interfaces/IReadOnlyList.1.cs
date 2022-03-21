namespace Rewired.Utils.Interfaces
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal interface IReadOnlyList<T> : IReadOnlyList
	{
		new T this[int index] { get; }

		int IndexOf(T value);

		bool Contains(T value);
	}
}
