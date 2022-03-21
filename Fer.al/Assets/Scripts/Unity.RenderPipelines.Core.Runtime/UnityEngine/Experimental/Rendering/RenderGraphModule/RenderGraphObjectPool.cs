using System;
using System.Collections.Generic;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	public sealed class RenderGraphObjectPool
	{
		private class SharedObjectPool<T> where T : new()
		{
			private Stack<T> m_Pool;

			private static readonly Lazy<SharedObjectPool<T>> s_Instance;

			public static SharedObjectPool<T> sharedPool
			{
				get
				{
					return null;
				}
			}

			public T Get()
			{
				return (T)null;
			}

			public void Release(T value)
			{
			}
		}

		private Dictionary<ValueTuple<Type, int>, Stack<object>> m_ArrayPool;

		private List<ValueTuple<object, ValueTuple<Type, int>>> m_AllocatedArrays;

		private List<MaterialPropertyBlock> m_AllocatedMaterialPropertyBlocks;

		internal RenderGraphObjectPool()
		{
		}

		public T[] GetTempArray<T>(int size)
		{
			return null;
		}

		public MaterialPropertyBlock GetTempMaterialPropertyBlock()
		{
			return null;
		}

		internal void ReleaseAllTempAlloc()
		{
		}

		internal T Get<T>() where T : new()
		{
			return (T)null;
		}

		internal void Release<T>(T value) where T : new()
		{
		}
	}
}
