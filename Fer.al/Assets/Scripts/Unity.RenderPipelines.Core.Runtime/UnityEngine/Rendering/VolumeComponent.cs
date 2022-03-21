using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class VolumeComponent : ScriptableObject
	{
		public bool active;

		[SerializeField]
		private bool m_AdvancedMode;

		public string displayName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public ReadOnlyCollection<VolumeParameter> parameters
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

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public virtual void Override(VolumeComponent state, float interpFactor)
		{
		}

		public void SetAllOverridesTo(bool state)
		{
		}

		private void SetAllOverridesTo(IEnumerable<VolumeParameter> enumerable, bool state)
		{
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		protected virtual void OnDestroy()
		{
		}

		public void Release()
		{
		}
	}
}
