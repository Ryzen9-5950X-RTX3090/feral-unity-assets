using System;
using System.Collections.Generic;
using UnityEngine;

namespace FIMSpace.Basics
{
	public class FBasic_SphericDuplicateOn : MonoBehaviour
	{
		public int RowCount;

		public float Radius;

		public LayerMask LayerMask;

		public Vector2 fromRange;

		public Vector2 toRange;

		[Range(0f, 1f)]
		public float Randomize;

		public int Seed;

		private System.Random randomSeed;

		public GameObject ToDuplicate;

		public Vector3 RotationOffset;

		public Vector3 RandomRotationLocalAxis;

		public Vector2 RandomRotationRange;

		public Transform AttachTo;

		public Transform AttachToNearestTransformOf;

		public List<GameObject> Generated;

		private void OnDrawGizmos()
		{
		}

		private Vector3 RandomVectorSeed(float rangeA, float rangeB)
		{
			return default(Vector3);
		}

		private float GetRandomRange(float rangeA, float rangeB)
		{
			return default(float);
		}

		public void Duplicate()
		{
		}

		private void PurgeGenerated()
		{
		}
	}
}
