using System;

namespace Rewired.Utils.Classes.Utility
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal struct SetAndRestoreVar<T> : IDisposable
	{
		private readonly Action<T> ZQjINDOgbIHAIdHFjBVXkNjagCLR;

		private readonly T PewPHQRLoLUCouPbqVNooCsBpZx;

		public SetAndRestoreVar(T oldValue, T newValue, Action<T> setValueDelegate)
		{
		}

		public void Dispose()
		{
		}
	}
}
