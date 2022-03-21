using UnityEngine;

public abstract class VA_VolumetricShape : VA_Shape
{
	[Tooltip("If you set this, then sound will only emit from the thin shell around the shape, else it will emit from inside too")]
	public bool IsHollow;

	public bool InnerPointSet;

	public Vector3 InnerPoint;

	public float InnerPointDistance;

	public bool InnerPointInside;

	public override bool FinalPointSet
	{
		get
		{
			return default(bool);
		}
	}

	public override Vector3 FinalPoint
	{
		get
		{
			return default(Vector3);
		}
	}

	public override float FinalPointDistance
	{
		get
		{
			return default(float);
		}
	}

	public void SetInnerPoint(Vector3 newInnerPoint, bool inside)
	{
	}

	public void SetInnerOuterPoint(Vector3 newInnerOuterPoint, bool inside)
	{
	}

	protected override void LateUpdate()
	{
	}
}
