public static class FEasing
{
	public enum EFease
	{
		EaseInCubic,
		EaseOutCubic,
		EaseInOutCubic,
		EaseInOutElastic,
		EaseInElastic,
		EaseOutElastic,
		EaseInExpo,
		EaseOutExpo,
		EaseInOutExpo,
		Linear
	}

	public delegate float Function(float s, float e, float v, float extraParameter = 1f);

	public static float EaseInCubic(float start, float end, float value, float ignore = 1f)
	{
		return default(float);
	}

	public static float EaseOutCubic(float start, float end, float value, float ignore = 1f)
	{
		return default(float);
	}

	public static float EaseInOutCubic(float start, float end, float value, float ignore = 1f)
	{
		return default(float);
	}

	public static float EaseOutElastic(float start, float end, float value, float rangeMul = 1f)
	{
		return default(float);
	}

	public static float EaseInElastic(float start, float end, float value, float rangeMul = 1f)
	{
		return default(float);
	}

	public static float EaseInOutElastic(float start, float end, float value, float rangeMul = 1f)
	{
		return default(float);
	}

	public static float EaseInExpo(float start, float end, float value, float ignore = 1f)
	{
		return default(float);
	}

	public static float EaseOutExpo(float start, float end, float value, float ignore = 1f)
	{
		return default(float);
	}

	public static float EaseInOutExpo(float start, float end, float value, float ignore = 1f)
	{
		return default(float);
	}

	public static float Linear(float start, float end, float value, float ignore = 1f)
	{
		return default(float);
	}

	public static Function GetEasingFunction(EFease easingFunction)
	{
		return null;
	}
}
