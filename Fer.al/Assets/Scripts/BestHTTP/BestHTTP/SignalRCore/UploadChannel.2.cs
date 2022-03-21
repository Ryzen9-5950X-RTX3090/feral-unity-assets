using System;
using System.Runtime.CompilerServices;

namespace BestHTTP.SignalRCore
{
	public sealed class UploadChannel<TResult, T> : IDisposable
	{
		public IUPloadItemController<TResult> Controller
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

		public int ParamIdx
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

		public bool IsFinished
		{
			get
			{
				return default(bool);
			}
			private set
			{
			}
		}

		public string StreamingId
		{
			get
			{
				return null;
			}
		}

		internal UploadChannel(IUPloadItemController<TResult> ctrl, int paramIdx)
		{
		}

		public void Upload(T item)
		{
		}

		public void Cancel()
		{
		}

		public void Finish()
		{
		}

		void IDisposable.Dispose()
		{
		}
	}
}
