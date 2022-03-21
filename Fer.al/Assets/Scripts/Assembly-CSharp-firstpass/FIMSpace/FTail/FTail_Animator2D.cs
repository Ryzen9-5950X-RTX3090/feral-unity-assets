using System.Runtime.InteropServices;
using UnityEngine;

namespace FIMSpace.FTail
{
	public class FTail_Animator2D : FTail_AnimatorUI
	{
		protected override void Init()
		{
		}

		protected override void Reset()
		{
		}

		protected override Quaternion CalculateTargetRotation(Vector3 startLookPos, Vector3 currentPos, [Optional] FTail_Point previousTailPoint, [Optional] FTail_Point currentTailPoint, int lookDirectionFixIndex = 0)
		{
			return default(Quaternion);
		}
	}
}
