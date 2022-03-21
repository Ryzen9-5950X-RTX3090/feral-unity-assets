using System.Runtime.InteropServices;
using UnityEngine;

namespace FIMSpace.FTail
{
	public class FTail_AnimatorUI : FTail_Animator
	{
		public bool Lock2D;

		protected override void Reset()
		{
		}

		protected override Quaternion CalculateTargetRotation(Vector3 startLookPos, Vector3 currentPos, [Optional] FTail_Point previousTailPoint, [Optional] FTail_Point currentTailPoint, int lookDirectionFixIndex = 0)
		{
			return default(Quaternion);
		}
	}
}
