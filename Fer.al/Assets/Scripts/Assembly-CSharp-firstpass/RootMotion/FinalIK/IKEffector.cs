using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKEffector
	{
		public Transform bone;

		public Transform target;

		[Range(0f, 1f)]
		public float positionWeight;

		[Range(0f, 1f)]
		public float rotationWeight;

		public Vector3 position;

		public Quaternion rotation;

		public Vector3 positionOffset;

		public bool effectChildNodes;

		[Range(0f, 1f)]
		public float maintainRelativePositionWeight;

		public Transform[] childBones;

		public Transform planeBone1;

		public Transform planeBone2;

		public Transform planeBone3;

		public Quaternion planeRotationOffset;

		private float posW;

		private float rotW;

		private Vector3[] localPositions;

		private bool usePlaneNodes;

		private Quaternion animatedPlaneRotation;

		private Vector3 animatedPosition;

		private bool firstUpdate;

		private int chainIndex;

		private int nodeIndex;

		private int plane1ChainIndex;

		private int plane1NodeIndex;

		private int plane2ChainIndex;

		private int plane2NodeIndex;

		private int plane3ChainIndex;

		private int plane3NodeIndex;

		private int[] childChainIndexes;

		private int[] childNodeIndexes;

		public bool isEndEffector
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		public IKEffector()
		{
		}

		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		public void Initiate(IKSolverFullBody solver)
		{
		}

		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		public void SetToTarget()
		{
		}

		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		public void OnPostWrite()
		{
		}

		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		public void Update(IKSolverFullBody solver)
		{
		}

		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
}
