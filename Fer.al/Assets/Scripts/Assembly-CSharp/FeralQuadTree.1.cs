using System.Collections.Generic;
using UnityEngine;

public class FeralQuadTree<T> where T : MonoBehaviour
{
	public class QuadTreeCell
	{
		private FeralQuadTree<T> _parentTree;

		private int _maxBehaviours;

		private Rect _bounds;

		private List<T> _behavioursInCell;

		private QuadTreeCell[] _innerCells;

		public QuadTreeCell(FeralQuadTree<T> inParentTree, Rect inBounds)
		{
		}

		public QuadTreeCell Add(T inBehaviour, Vector2 inBehaviourPositionXZ)
		{
			return null;
		}

		private void Split()
		{
		}

		public void GetOverlappedCells(Rect inBounds, List<QuadTreeCell> inList)
		{
		}

		public void GetBehavioursWithinDistance(Vector2 inPos, float inDistance, List<T> inList)
		{
		}

		public void OnDrawGizmos()
		{
		}
	}

	private int _maxBehavioursPerCell;

	private QuadTreeCell _head;

	public FeralQuadTree(int inMaxBehavioursPerCell, Rect inOuterBounds)
	{
	}

	public QuadTreeCell Add(T inBehaviour)
	{
		return null;
	}

	public List<QuadTreeCell> GetCellsWithinDistance(Transform inTransform, float inDistance)
	{
		return null;
	}

	public List<T> GetBehavioursWithinDistance(Transform inTransform, float inDistance)
	{
		return null;
	}

	private static bool InRange(float inValue, float inMin, float inMax)
	{
		return default(bool);
	}

	private static bool RectsOverlap(Rect inRect1, Rect inRect2)
	{
		return default(bool);
	}

	public void OnDrawGizmos()
	{
	}
}
