using Rewired.Config;

namespace Rewired
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal class ButtonLoopSet : UpdateLoopDataSet<ButtonLoopSet.ButtonData>
	{
		[CustomClassObfuscation]
		[CustomObfuscation]
		public class ButtonData
		{
			public readonly UpdateLoopType updateLoop;

			public readonly bool[] values;

			public readonly bool[] wasTrueThisFrame;

			private bool[] cMhEJwVMfmVmCFDwoVYzoCYbEQTH;

			private int pJEKLHQNGkWDQQpFzlufkYmYkQp;

			public bool[] effectiveValue
			{
				get
				{
					return null;
				}
			}

			public ButtonData(int count, UpdateLoopType updateLoop)
			{
			}

			public void SetValue(int index, bool value)
			{
			}

			public void ClearWasTrueThisFrame()
			{
			}

			public void Clear()
			{
			}

			public void Import(ButtonData source)
			{
			}

			private void RaLVxJRaHFAmTEJyNEOQHPVXPJy()
			{
			}
		}

		public readonly int buttonCount;

		public ButtonLoopSet(UpdateLoopSetting updateLoops, int buttonCount)
		{
		}

		public void SetValue(int index, bool value, float timestamp)
		{
		}

		public void Clear()
		{
		}

		public void Import(ButtonLoopSet set)
		{
		}
	}
}
