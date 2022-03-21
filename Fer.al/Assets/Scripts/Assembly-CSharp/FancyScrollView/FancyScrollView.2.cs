using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace FancyScrollView
{
	public abstract class FancyScrollView<TData, TContext> : MonoBehaviour where TContext : class
	{
		[SerializeField]
		[Range(float.Epsilon, 1f)]
		private float cellInterval;

		[SerializeField]
		[Range(0f, 1f)]
		private float cellOffset;

		[SerializeField]
		protected bool loop;

		[SerializeField]
		private GameObject cellBase;

		[SerializeField]
		private Transform cellContainer;

		protected readonly List<FancyScrollViewCell<TData, TContext>> cells;

		private float currentPosition;

		protected List<TData> cellData;

		public bool Loop
		{
			get
			{
				return default(bool);
			}
		}

		public List<TData> CellData
		{
			get
			{
				return null;
			}
		}

		protected TContext Context
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool HasContext
		{
			get
			{
				return default(bool);
			}
		}

		protected void SetContext(TContext context)
		{
		}

		protected void UpdateContents()
		{
		}

		protected void UpdatePosition(float position, bool forceUpdateContents = false)
		{
		}

		private void UpdateCell(FancyScrollViewCell<TData, TContext> cell, int dataIndex, bool forceUpdateContents = false)
		{
		}

		private FancyScrollViewCell<TData, TContext> CreateCell()
		{
			return null;
		}

		private int GetCircularIndex(int index, int maxSize)
		{
			return default(int);
		}
	}
}
