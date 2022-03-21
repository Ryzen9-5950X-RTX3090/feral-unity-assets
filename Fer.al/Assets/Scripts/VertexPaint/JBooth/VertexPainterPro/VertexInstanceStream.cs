using System.Collections.Generic;
using UnityEngine;

namespace JBooth.VertexPainterPro
{
	[ExecuteInEditMode]
	public class VertexInstanceStream : MonoBehaviour
	{
		public bool keepRuntimeData;

		[HideInInspector]
		[SerializeField]
		private Color[] _colors;

		[HideInInspector]
		[SerializeField]
		private List<Vector4> _uv0;

		[HideInInspector]
		[SerializeField]
		private List<Vector4> _uv1;

		[HideInInspector]
		[SerializeField]
		private List<Vector4> _uv2;

		[HideInInspector]
		[SerializeField]
		private List<Vector4> _uv3;

		[HideInInspector]
		[SerializeField]
		private Vector3[] _positions;

		[HideInInspector]
		[SerializeField]
		private Vector3[] _normals;

		[HideInInspector]
		[SerializeField]
		private Vector4[] _tangents;

		private bool enforcedColorChannels;

		private Mesh meshStream;

		public Color[] colors
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<Vector4> uv0
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<Vector4> uv1
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<Vector4> uv2
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<Vector4> uv3
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3[] positions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3[] normals
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector4[] tangents
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void EnforceOriginalMeshHasColors(Mesh stream)
		{
		}

		public Mesh Apply(bool markNoLongerReadable = true)
		{
			return null;
		}
	}
}
