namespace Rewired.Utils.Interfaces
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal interface IReadOnlyList
	{
		int Count { get; }

		object this[int index] { get; }

		int IndexOf(object value);

		bool Contains(object value);
	}
}
