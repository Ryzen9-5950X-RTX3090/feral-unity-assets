using System.Runtime.CompilerServices;

namespace FancyScrollView
{
	public abstract class FancyScrollViewCell<TData, TContext> : MonoBehaviour where TContext : class
	{
		public int DataIndex
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual bool IsVisible
		{
			get
			{
				return default(bool);
			}
		}

		public virtual bool IsSelectable
		{
			get
			{
				return default(bool);
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

		public virtual void SetContext(TContext context)
		{
		}

		public virtual void SetVisible(bool visible)
		{
		}

		public virtual void UpdateContent(TData itemData)
		{
		}

		public virtual void UpdatePosition(float position)
		{
		}
	}
}
