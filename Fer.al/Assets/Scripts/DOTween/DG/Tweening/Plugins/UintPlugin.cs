using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

namespace DG.Tweening.Plugins
{
	public class UintPlugin : ABSTweenPlugin<uint, uint, UintOptions>
	{
		public override void Reset(TweenerCore<uint, uint, UintOptions> t)
		{
		}

		public override void SetFrom(TweenerCore<uint, uint, UintOptions> t, bool isRelative)
		{
		}

		public override void SetFrom(TweenerCore<uint, uint, UintOptions> t, uint fromValue, bool setImmediately)
		{
		}

		public override uint ConvertToStartValue(TweenerCore<uint, uint, UintOptions> t, uint value)
		{
			return default(uint);
		}

		public override void SetRelativeEndValue(TweenerCore<uint, uint, UintOptions> t)
		{
		}

		public override void SetChangeValue(TweenerCore<uint, uint, UintOptions> t)
		{
		}

		public override float GetSpeedBasedDuration(UintOptions options, float unitsXSecond, uint changeValue)
		{
			return default(float);
		}

		public override void EvaluateAndApply(UintOptions options, Tween t, bool isRelative, DOGetter<uint> getter, DOSetter<uint> setter, float elapsed, uint startValue, uint changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}
	}
}
