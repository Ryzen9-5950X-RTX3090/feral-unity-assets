using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.render-pipelines.high-definition@10.3/manual/Volume-Profile.html")]
	public sealed class VolumeProfile : ScriptableObject
	{
		public List<VolumeComponent> components;

		[NonSerialized]
		public bool isDirty;

		private void OnEnable()
		{
		}

		public void Reset()
		{
		}

		public T Add<T>(bool overrides = false) where T : VolumeComponent
		{
			return null;
		}

		public VolumeComponent Add(Type type, bool overrides = false)
		{
			return null;
		}

		public void Remove<T>() where T : VolumeComponent
		{
		}

		public void Remove(Type type)
		{
		}

		public bool Has<T>() where T : VolumeComponent
		{
			return default(bool);
		}

		public bool Has(Type type)
		{
			return default(bool);
		}

		public bool HasSubclassOf(Type type)
		{
			return default(bool);
		}

		public bool TryGet<T>(out T component) where T : VolumeComponent
		{
			return default(bool);
		}

		public bool TryGet<T>(Type type, out T component) where T : VolumeComponent
		{
			return default(bool);
		}

		public bool TryGetSubclassOf<T>(Type type, out T component) where T : VolumeComponent
		{
			return default(bool);
		}

		public bool TryGetAllSubclassOf<T>(Type type, List<T> result) where T : VolumeComponent
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		internal int GetComponentListHashCode()
		{
			return default(int);
		}
	}
}
