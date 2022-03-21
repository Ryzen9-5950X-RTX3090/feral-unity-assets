using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

namespace DG.Tweening.Plugins
{
	public class UlongPlugin : ABSTweenPlugin<ulong, ulong, NoOptions>
	{
		public override void Reset(TweenerCore<ulong, ulong, NoOptions> t)
		{
		}

		public override void SetFrom(TweenerCore<ulong, ulong, NoOptions> t, bool isRelative)
		{
		}

		public override void SetFrom(TweenerCore<ulong, ulong, NoOptions> t, ulong fromValue, bool setImmediately)
		{
		}

		public override ulong ConvertToStartValue(TweenerCore<ulong, ulong, NoOptions> t, ulong value)
		{
			return default(ulong);
		}

		public override void SetRelativeEndValue(TweenerCore<ulong, ulong, NoOptions> t)
		{
		}

		public override void SetChangeValue(TweenerCore<ulong, ulong, NoOptions> t)
		{
		}

		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, ulong changeValue)
		{
			return default(float);
		}

		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<ulong> getter, DOSetter<ulong> setter, float elapsed, ulong startValue, ulong changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}
	}
}
