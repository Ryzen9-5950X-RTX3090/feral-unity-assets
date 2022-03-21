using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Prototype
{
	public class ObjectivePath : ManagedBehaviour
	{
		[SerializeField]
		private Transform _objectiveTarget;

		[SerializeField]
		private Material _material;

		private Vector3[] _vertices;

		private int[] _triangles;

		private Vector2[] _uvs;

		private Vector3[] _normals;

		private NavMeshPath _navMeshPath;

		private List<Mesh> _meshes;

		public List<Vector3> linePoints;

		[SerializeField]
		private float _pathWidth;

		[SerializeField]
		private Color _pathColor;

		private int _minPoints;

		public override void MStart()
		{
		}

		public override void MUpdate()
		{
		}

		public void SetDestination()
		{
		}

		private void MakeMesh(int inIdx)
		{
		}

		private List<Vector3> MakeSmoothCurve(Vector3[] inVector3Array)
		{
			return null;
		}
	}
}
