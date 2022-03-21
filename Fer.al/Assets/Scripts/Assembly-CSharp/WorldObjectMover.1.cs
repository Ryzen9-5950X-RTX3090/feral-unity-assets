using System.Collections.Generic;

public class WorldObjectMover<T> : WorldObject<T> where T : WorldObjectInfo
{
	protected List<WorldObjectMoverNode> _moverNodeQueue;

	private float _navCurrentTraveledDist;

	private float _navCurrentSegmentTraveledDist;

	private const float _navRotateSmoothTime = 0.25f;

	private float _navRotateSmoothVelocity;

	private float NavStartTimer;

	public void DummyMoveMessage(WorldObjectMoveMessage inMessage)
	{
	}

	protected override void OnMoveMessage(WorldObjectMoveMessage inMessage)
	{
	}

	private void ResetNavStartTimer()
	{
	}

	private void UpdateNavStartTimer()
	{
	}

	protected virtual void MUpdateMoverNodeQueue()
	{
	}

	protected virtual void HandleNodeType(WorldObjectMoverNode node)
	{
	}
}
