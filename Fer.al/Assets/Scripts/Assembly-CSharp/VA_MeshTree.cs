using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class VA_MeshTree
{
	[Serializable]
	public class Node
	{
		public Bounds Bound;

		public int PositiveIndex;

		public int NegativeIndex;

		public int TriangleIndex;

		public int TriangleCount;
	}

	[Serializable]
	public class Triangle
	{
		public Vector3 A;

		public Vector3 B;

		public Vector3 C;

		public Vector3 Min
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 Max
		{
			get
			{
				return default(Vector3);
			}
		}

		public float MidX
		{
			get
			{
				return default(float);
			}
		}

		public float MidY
		{
			get
			{
				return default(float);
			}
		}

		public float MidZ
		{
			get
			{
				return default(float);
			}
		}
	}

	public List<Node> Nodes;

	public List<Triangle> Triangles;

	private static List<Triangle> closestTriangles;

	private static float closestSqrDistance;

	public void Clear()
	{
	}

	public void Bake(Mesh mesh)
	{
	}

	public Vector3 FindClosestPoint(Vector3 point)
	{
		return default(Vector3);
	}

	private void Search(Node node, Vector3 point)
	{
	}

	private float NearSqrDistance(Node node, Vector3 point)
	{
		return default(float);
	}

	private float FarSqrDistance(Node node, Vector3 point)
	{
		return default(float);
	}

	private void AddToResults(Node node)
	{
	}

	private List<Triangle> GetAllTriangles(Mesh mesh)
	{
		return null;
	}

	private void Pack(Node node, List<Triangle> tris)
	{
	}

	private void CalculateBound(Node node, List<Triangle> tris)
	{
	}

	private void CalculateAxisAndPivot(List<Triangle> tris, ref int axis, ref float pivot)
	{
	}
}
