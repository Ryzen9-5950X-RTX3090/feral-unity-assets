using System;

namespace Rewired
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal class ControllerDisconnectedEventArgs : EventArgs
	{
		public readonly int rewiredId;

		public ControllerDisconnectedEventArgs(int rewiredId)
		{
		}
	}
}
