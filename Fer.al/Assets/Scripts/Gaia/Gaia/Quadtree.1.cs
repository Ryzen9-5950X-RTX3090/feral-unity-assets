using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gaia
{
	public class Quadtree<T>
	{
		private class QuadtreeNode
		{
			public Vector2 Position
			{
				[CompilerGenerated]
				get
				{
					return default(Vector2);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public T Value
			{
				[CompilerGenerated]
				get
				{
					return (T)null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public QuadtreeNode(Vector2 position, T value)
			{
			}
		}

		private readonly int nodeCapacity;

		private readonly List<QuadtreeNode> nodes;

		private Quadtree<T>[] children;

		private Rect boundaries;

		public int Count
		{
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

		public Quadtree(Rect boundaries, int nodeCapacity = 32)
		{
		}

		public bool Insert(float x, float y, T value)
		{
			return default(bool);
		}

		public bool Insert(Vector2 position, T value)
		{
			return default(bool);
		}

		private bool Insert(QuadtreeNode node)
		{
			return default(bool);
		}

		[IteratorStateMachine(typeof(Quadtree<>.<Find>d__12))]
		public IEnumerable<T> Find(Rect range)
		{
			return null;
		}

		public bool Remove(float x, float z, T value)
		{
			return default(bool);
		}

		public bool Remove(Vector2 position, T value)
		{
			return default(bool);
		}

		private void Subdivide()
		{
		}

		private void Combine()
		{
		}
	}
}
