using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering
{
	public sealed class VolumeManager
	{
		private static readonly Lazy<VolumeManager> s_Instance;

		private const int k_MaxLayerCount = 32;

		private readonly Dictionary<int, List<Volume>> m_SortedVolumes;

		private readonly List<Volume> m_Volumes;

		private readonly Dictionary<int, bool> m_SortNeeded;

		private readonly List<VolumeComponent> m_ComponentsDefaultState;

		private readonly List<Collider> m_TempColliders;

		public static VolumeManager instance
		{
			get
			{
				return null;
			}
		}

		public VolumeStack stack
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public IEnumerable<Type> baseComponentTypes
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private VolumeManager()
		{
		}

		public VolumeStack CreateStack()
		{
			return null;
		}

		public void DestroyStack(VolumeStack stack)
		{
		}

		private void ReloadBaseTypes()
		{
		}

		public void Register(Volume volume, int layer)
		{
		}

		public void Unregister(Volume volume, int layer)
		{
		}

		public bool IsComponentActiveInMask<T>(LayerMask layerMask) where T : VolumeComponent
		{
			return default(bool);
		}

		internal void SetLayerDirty(int layer)
		{
		}

		internal void UpdateVolumeLayer(Volume volume, int prevLayer, int newLayer)
		{
		}

		private void OverrideData(VolumeStack stack, List<VolumeComponent> components, float interpFactor)
		{
		}

		private void ReplaceData(VolumeStack stack, List<VolumeComponent> components)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public void CheckBaseTypes()
		{
		}

		[Conditional("UNITY_EDITOR")]
		public void CheckStack(VolumeStack stack)
		{
		}

		public void Update(Transform trigger, LayerMask layerMask)
		{
		}

		public void Update(VolumeStack stack, Transform trigger, LayerMask layerMask)
		{
		}

		public Volume[] GetVolumes(LayerMask layerMask)
		{
			return null;
		}

		private List<Volume> GrabVolumes(LayerMask mask)
		{
			return null;
		}

		private static void SortByPriority(List<Volume> volumes)
		{
		}

		private static bool IsVolumeRenderedByCamera(Volume volume, Camera camera)
		{
			return default(bool);
		}
	}
}
