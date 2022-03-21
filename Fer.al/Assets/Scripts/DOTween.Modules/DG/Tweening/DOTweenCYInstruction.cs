using UnityEngine;

namespace DG.Tweening
{
	public static class DOTweenCYInstruction
	{
		public class WaitForCompletion : CustomYieldInstruction
		{
			private readonly Tween t;

			public override bool keepWaiting
			{
				get
				{
					return default(bool);
				}
			}

			public WaitForCompletion(Tween tween)
			{
			}
		}

		public class WaitForRewind : CustomYieldInstruction
		{
			private readonly Tween t;

			public override bool keepWaiting
			{
				get
				{
					return default(bool);
				}
			}

			public WaitForRewind(Tween tween)
			{
			}
		}

		public class WaitForKill : CustomYieldInstruction
		{
			private readonly Tween t;

			public override bool keepWaiting
			{
				get
				{
					return default(bool);
				}
			}

			public WaitForKill(Tween tween)
			{
			}
		}

		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			private readonly Tween t;

			private readonly int elapsedLoops;

			public override bool keepWaiting
			{
				get
				{
					return default(bool);
				}
			}

			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		public class WaitForPosition : CustomYieldInstruction
		{
			private readonly Tween t;

			private readonly float position;

			public override bool keepWaiting
			{
				get
				{
					return default(bool);
				}
			}

			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		public class WaitForStart : CustomYieldInstruction
		{
			private readonly Tween t;

			public override bool keepWaiting
			{
				get
				{
					return default(bool);
				}
			}

			public WaitForStart(Tween tween)
			{
			}
		}
	}
}
