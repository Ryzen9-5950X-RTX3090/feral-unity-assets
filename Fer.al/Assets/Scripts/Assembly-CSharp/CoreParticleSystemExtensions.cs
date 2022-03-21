using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class CoreParticleSystemExtensions
{
	[IteratorStateMachine(typeof(<SetEmissionByRange>d__0))]
	public static IEnumerator SetEmissionByRange(this ParticleSystem ps, Transform inPlayerTransform, float inRangeForEnable = 50f, float inCheckTimeSeconds = 1f)
	{
		return null;
	}

	public static void SetEmissionEnabled(this ParticleSystem ps, bool inEnabled)
	{
	}

	public static float GetEmissionRate(this ParticleSystem ps)
	{
		return default(float);
	}

	public static void SetEmissionRate(this ParticleSystem ps, float inRate)
	{
	}

	[IteratorStateMachine(typeof(<EmitBurstCycle>d__4))]
	public static IEnumerator EmitBurstCycle(this ParticleSystem ps)
	{
		return null;
	}

	public static void EmitBursts(this ParticleSystem ps, MonoBehaviour inCoroutineObject)
	{
	}

	[IteratorStateMachine(typeof(<DoBurstEmit>d__6))]
	private static IEnumerator DoBurstEmit(ParticleSystem ps, ParticleSystem.Burst inBurst)
	{
		return null;
	}

	public static void SetStartColor(this ParticleSystem ps, Color inColor)
	{
	}

	public static Color GetStartColor(this ParticleSystem ps)
	{
		return default(Color);
	}

	public static void SetDuration(this ParticleSystem ps, float inDuration)
	{
	}

	public static void SetStartSpeed(this ParticleSystem ps, float inSpeed)
	{
	}

	public static void SetStartSize(this ParticleSystem ps, float inSize)
	{
	}
}
