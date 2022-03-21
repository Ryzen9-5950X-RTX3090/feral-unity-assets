using System.Runtime.CompilerServices;

namespace CodeStage.AntiCheat.Genuine.CodeHash
{
	internal abstract class BaseWorker
	{
		public HashGeneratorResult Result
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

		public bool IsBusy
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public virtual void Execute()
		{
		}

		protected virtual void Complete(HashGeneratorResult result)
		{
		}
	}
}
