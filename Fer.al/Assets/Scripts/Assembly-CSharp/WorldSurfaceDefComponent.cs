using System;

[Serializable]
[ChartComponent("World Surface")]
public class WorldSurfaceDefComponent : DefComponent
{
	[ChartEnum]
	public WorldSurfaceType surfaceType;

	[ChartFloat]
	public float moveSpeedMultiplier;

	[ChartFloat]
	public float animationSpeedMultiplier;

	[ChartBundle]
	public ChartBundle bundle;
}
