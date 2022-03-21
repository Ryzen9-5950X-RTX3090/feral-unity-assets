using System;

namespace UnityEngine.Rendering
{
	public abstract class VolumeParameter
	{
		public const string k_DebuggerDisplay = "{m_Value} ({m_OverrideState})";

		[SerializeField]
		protected bool m_OverrideState;

		public virtual bool overrideState
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		internal abstract void Interp(VolumeParameter from, VolumeParameter to, float t);

		public T GetValue<T>()
		{
			return (T)null;
		}

		public abstract void SetValue(VolumeParameter parameter);

		protected internal virtual void OnEnable()
		{
		}

		protected internal virtual void OnDisable()
		{
		}

		public static bool IsObjectParameter(Type type)
		{
			return default(bool);
		}

		public virtual void Release()
		{
		}
	}
}
