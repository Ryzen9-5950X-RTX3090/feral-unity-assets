using UnityEngine;

public abstract class VA_Shape : MonoBehaviour
{
	public bool OuterPointSet;

	public Vector3 OuterPoint;

	public float OuterPointDistance;

	public virtual bool FinalPointSet
	{
		get
		{
			return default(bool);
		}
	}

	public virtual Vector3 FinalPoint
	{
		get
		{
			return default(Vector3);
		}
	}

	public virtual float FinalPointDistance
	{
		get
		{
			return default(float);
		}
	}

	public void SetOuterPoint(Vector3 newOuterPoint)
	{
	}

	protected virtual void LateUpdate()
	{
	}
}
