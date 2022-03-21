using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal class ObjectPool<T> : IObjectPool<T>, IObjectPool where T : class
	{
		protected readonly Queue<T> _pool;

		protected readonly Func<T> _createInstanceDelegate;

		protected readonly Action<T> _processOnReturnDelegate;

		private ulong zmVTMZhvzUQzWQrGMGOGKzlVJbw;

		protected ulong InstanceCount
		{
			get
			{
				return default(ulong);
			}
		}

		public ObjectPool(int startingSize, Func<T> createInstanceDelegate, [Optional] Action<T> processOnReturnDelegate)
		{
		}

		public ObjectPool(Func<T> instancerDelegate)
		{
		}

		public void Clear(bool reduceSize = false)
		{
		}

		public T Get()
		{
			return null;
		}

		public bool Return(T item)
		{
			return default(bool);
		}

		object IObjectPool.Get()
		{
			return null;
		}

		bool IObjectPool.Return(object P_0)
		{
			return default(bool);
		}

		protected T CreateInstance()
		{
			return null;
		}

		protected ulong IncrementInstanceCount()
		{
			return default(ulong);
		}
	}
}
