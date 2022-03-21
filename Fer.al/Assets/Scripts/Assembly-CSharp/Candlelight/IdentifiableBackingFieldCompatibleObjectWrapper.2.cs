using System;
using UnityEngine;

namespace Candlelight
{
	[Serializable]
	public abstract class IdentifiableBackingFieldCompatibleObjectWrapper<TId, T> : IdentifiableBackingFieldCompatibleObjectWrapper, IIdentifiable<TId>
	{
		[SerializeField]
		private TId m_Identifier;

		[SerializeField]
		private T m_Data;

		public T Data
		{
			get
			{
				return (T)null;
			}
			protected set
			{
			}
		}

		public TId Identifier
		{
			get
			{
				return (TId)null;
			}
			protected set
			{
			}
		}

		public override object Clone()
		{
			return null;
		}

		public override int GetSerializedPropertiesHash()
		{
			return default(int);
		}

		protected IdentifiableBackingFieldCompatibleObjectWrapper(TId id, T data)
		{
		}

		protected virtual bool SetData(T data)
		{
			return default(bool);
		}

		protected virtual bool SetIdentifier(TId identifier)
		{
			return default(bool);
		}
	}
}
