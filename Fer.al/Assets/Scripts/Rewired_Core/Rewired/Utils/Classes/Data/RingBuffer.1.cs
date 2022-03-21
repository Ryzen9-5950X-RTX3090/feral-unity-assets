using System;
using System.Collections;
using System.Collections.Generic;

namespace Rewired.Utils.Classes.Data
{
	[Serializable]
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal sealed class RingBuffer<T> : IEnumerable, IEnumerable<T>, ICollection<T>
	{
		[Serializable]
		public struct xGVRUybGTbbONRCsFRNctcqMGbN : IDisposable, IEnumerator, IEnumerator<T>
		{
			private RingBuffer<T> buffer;

			private int index;

			private int version;

			private T current;

			public T iqRXBCFJzSXINtBNEmUcRPMPsKE
			{
				get
				{
					return (T)null;
				}
			}

			object IEnumerator.lEHmhZcDVBCvVkmanIeFkjDMVct
			{
				get
				{
					return null;
				}
			}

			internal xGVRUybGTbbONRCsFRNctcqMGbN(RingBuffer<T> buffer)
			{
			}

			public void Dispose()
			{
			}

			public bool MoveNext()
			{
				return default(bool);
			}

			private bool mGRuCjPDMbxAnMBLgXgjddgPkSL()
			{
				return default(bool);
			}

			void IEnumerator.Reset()
			{
			}
		}

		private readonly T[] SvFrJoHFoPAEpRGoybiMjILSeKAc;

		private readonly int LHcUXOytTkIjlqPoenVhkyCFGKR;

		private int NlWaJxeSXNEewltcjZzcJjBCzdQ;

		private int lQXhFEatgRugRtDTSluKswoNsmY;

		private int kswtyGmohuOlSPFexjaYYjNtnYw;

		private int IjqwTBwdrSirVKbWYwOPxLyUCyW;

		private int wNPCYmLfYxcqAQsDPfNrFaPUdXp;

		private IEqualityComparer<T> BpqgKwtwxiCJWBlAQLLFXpVLOJgD;

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public int Capacity
		{
			get
			{
				return default(int);
			}
		}

		public int OverrunCount
		{
			get
			{
				return default(int);
			}
		}

		public IEqualityComparer<T> EqualityComparer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public T this[int index]
		{
			get
			{
				return (T)null;
			}
			set
			{
			}
		}

		int ICollection<T>.Count
		{
			get
			{
				return default(int);
			}
		}

		bool ICollection<T>.IsReadOnly
		{
			get
			{
				return default(bool);
			}
		}

		public RingBuffer(int capacity)
		{
		}

		public void Enqueue(T item)
		{
		}

		public bool EnqueueIfUnique(T item)
		{
			return default(bool);
		}

		public T Dequeue()
		{
			return (T)null;
		}

		public T Peek()
		{
			return (T)null;
		}

		public bool Contains(T item)
		{
			return default(bool);
		}

		public bool Contains(T item, IEqualityComparer<T> comparer)
		{
			return default(bool);
		}

		public int IndexOf(T item)
		{
			return default(int);
		}

		public int IndexOf(T item, IEqualityComparer<T> comparer)
		{
			return default(int);
		}

		public bool Remove(T item)
		{
			return default(bool);
		}

		public bool Remove(T item, IEqualityComparer<T> comparer)
		{
			return default(bool);
		}

		public void RemoveAt(int index)
		{
		}

		public int RemoveAll(T item)
		{
			return default(int);
		}

		public int RemoveAll(T item, IEqualityComparer<T> comparer)
		{
			return default(int);
		}

		public void Clear()
		{
		}

		private int krhhhaALxgFpBwsYFvdYiuJUKqH(T P_0)
		{
			return default(int);
		}

		private int krhhhaALxgFpBwsYFvdYiuJUKqH(T P_0, IEqualityComparer<T> P_1)
		{
			return default(int);
		}

		private void EcPaTBhqvVCbAARRSpUqPrXBwLYb(int P_0)
		{
		}

		private bool WlHpcgiRtAxMgNHXMSeSFsPVxLS(int P_0)
		{
			return default(bool);
		}

		private int nNgyCpxLaUYDrbXaStDJcACPIFLa(int P_0)
		{
			return default(int);
		}

		private int mKWyrxHycmOFoPTqCJHdLyJPItb(int P_0)
		{
			return default(int);
		}

		void ICollection<T>.Add(T item)
		{
		}

		void ICollection<T>.Clear()
		{
		}

		bool ICollection<T>.Contains(T item)
		{
			return default(bool);
		}

		void ICollection<T>.CopyTo(T[] array, int arrayIndex)
		{
		}

		bool ICollection<T>.Remove(T item)
		{
			return default(bool);
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
