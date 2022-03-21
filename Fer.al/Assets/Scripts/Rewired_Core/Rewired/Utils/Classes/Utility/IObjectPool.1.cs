namespace Rewired.Utils.Classes.Utility
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal interface IObjectPool<T>
	{
		void Clear(bool reduceSize = false);

		T Get();

		bool Return(T item);
	}
}
