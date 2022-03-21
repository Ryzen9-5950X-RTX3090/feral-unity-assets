namespace UnityEngine.Rendering
{
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.render-pipelines.high-definition@10.3/manual/Volumes.html")]
	[AddComponentMenu("Miscellaneous/Volume")]
	public class Volume : MonoBehaviour
	{
		[Tooltip("When enabled, HDRP applies this Volume to the entire Scene.")]
		public bool isGlobal;

		[Tooltip("Sets the Volume priority in the stack. A higher value means higher priority. You can use negative values.")]
		public float priority;

		[Tooltip("Sets the outer distance to start blending from. A value of 0 means no blending and Unity applies the Volume overrides immediately upon entry.")]
		public float blendDistance;

		[Range(0f, 1f)]
		[Tooltip("Sets the total weight of this Volume in the Scene. 0 means no effect and 1 means full effect.")]
		public float weight;

		public VolumeProfile sharedProfile;

		private int m_PreviousLayer;

		private float m_PreviousPriority;

		private VolumeProfile m_InternalProfile;

		public VolumeProfile profile
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal VolumeProfile profileRef
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

		internal void UpdateLayer()
		{
		}
	}
}
