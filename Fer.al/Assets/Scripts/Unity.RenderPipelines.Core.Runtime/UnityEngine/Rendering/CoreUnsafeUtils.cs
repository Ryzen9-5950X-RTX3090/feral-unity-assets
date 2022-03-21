using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine.Rendering
{
	public static class CoreUnsafeUtils
	{
		public struct FixedBufferStringQueue
		{
			private unsafe byte* m_ReadCursor;

			private unsafe byte* m_WriteCursor;

			private unsafe readonly byte* m_BufferEnd;

			private unsafe readonly byte* m_BufferStart;

			private readonly int m_BufferLength;

			public int Count
			{
				[IsReadOnly]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public unsafe FixedBufferStringQueue(byte* ptr, int length)
			{
			}

			public bool TryPush(string v)
			{
				return default(bool);
			}

			public bool TryPop(out string v)
			{
				return default(bool);
			}

			public void Clear()
			{
			}
		}

		public interface IKeyGetter<TValue, TKey>
		{
			TKey Get(ref TValue v);
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		internal struct DefaultKeyGetter<T> : IKeyGetter<T, T>
		{
			public T Get(ref T v)
			{
				return (T)null;
			}
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		internal struct UintKeyGetter : IKeyGetter<uint, uint>
		{
			public uint Get(ref uint v)
			{
				return default(uint);
			}
		}

		public unsafe static void CopyTo<T>(this List<T> list, void* dest, int count) where T : struct
		{
		}

		public unsafe static void CopyTo<T>(this T[] list, void* dest, int count) where T : struct
		{
		}

		public static void QuickSort(uint[] arr, int left, int right)
		{
		}

		public unsafe static void QuickSort<T, T>(int count, void* data) where T : struct, IComparable<T> where T : struct, IComparable<T>
		{
		}

		public unsafe static void QuickSort<TValue, TKey, TKey, TGetter, TValue>(int count, void* data) where TValue : struct where TKey : struct, IComparable<TKey> where TKey : struct, IComparable<TKey> where TGetter : struct, IKeyGetter<TValue, TKey> where TValue : struct
		{
		}

		public unsafe static void QuickSort<TValue, TKey, TKey, TGetter, TValue>(void* data, int left, int right) where TValue : struct where TKey : struct, IComparable<TKey> where TKey : struct, IComparable<TKey> where TGetter : struct, IKeyGetter<TValue, TKey> where TValue : struct
		{
		}

		public unsafe static int IndexOf<T>(void* data, int count, T v) where T : struct, IEquatable<T>
		{
			return default(int);
		}

		public unsafe static int CompareHashes<TOldValue, TOldGetter, TOldValue, TNewValue, TNewGetter, TNewValue>(int oldHashCount, void* oldHashes, int newHashCount, void* newHashes, int* addIndices, int* removeIndices, out int addCount, out int remCount) where TOldValue : struct where TOldGetter : struct, IKeyGetter<TOldValue, Hash128> where TOldValue : struct where TNewValue : struct where TNewGetter : struct, IKeyGetter<TNewValue, Hash128> where TNewValue : struct
		{
			return default(int);
		}

		public unsafe static int CompareHashes(int oldHashCount, Hash128* oldHashes, int newHashCount, Hash128* newHashes, int* addIndices, int* removeIndices, out int addCount, out int remCount)
		{
			return default(int);
		}

		public unsafe static void CombineHashes<TValue, TGetter, TValue>(int count, void* hashes, Hash128* outHash) where TValue : struct where TGetter : struct, IKeyGetter<TValue, Hash128> where TValue : struct
		{
		}

		public unsafe static void CombineHashes(int count, Hash128* hashes, Hash128* outHash)
		{
		}

		private unsafe static int Partition<TValue, TKey, TKey, TGetter, TValue>(void* data, int left, int right) where TValue : struct where TKey : struct, IComparable<TKey> where TKey : struct, IComparable<TKey> where TGetter : struct, IKeyGetter<TValue, TKey> where TValue : struct
		{
			return default(int);
		}

		public static bool HaveDuplicates(int[] arr)
		{
			return default(bool);
		}
	}
}
