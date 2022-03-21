using System.Collections.Generic;

namespace UnityEngine.Rendering.PostProcessing
{
	[ExecuteAlways]
	[AddComponentMenu("Rendering/Post-process Volume", 1001)]
	public sealed class PostProcessVolume : MonoBehaviour
	{
		public PostProcessProfile sharedProfile;

		[Tooltip("Check this box to mark this volume as global. This volume's Profile will be applied to the whole Scene.")]
		public bool isGlobal;

		[Min(0f)]
		[Tooltip("The distance (from the attached Collider) to start blending from. A value of 0 means there will be no blending and the Volume overrides will be applied immediatly upon entry to the attached Collider.")]
		public float blendDistance;

		[Range(0f, 1f)]
		[Tooltip("The total weight of this Volume in the Scene. A value of 0 signifies that it will have no effect, 1 signifies full effect.")]
		public float weight;

		[Tooltip("The volume priority in the stack. A higher value means higher priority. Negative values are supported.")]
		public float priority;

		private int m_PreviousLayer;

		private float m_PreviousPriority;

		private List<Collider> m_TempColliders;

		private PostProcessProfile m_InternalProfile;

		public PostProcessProfile profile
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal PostProcessProfile profileRef
		{
			get
			{
				return null;
			}
		}

		public bool HasInstantiatedProfile()
		{
			return default(bool);
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
