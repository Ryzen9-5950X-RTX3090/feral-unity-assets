using System.Collections.Generic;
using UnityEngine;

namespace Candlelight.Examples
{
	public abstract class GenericBaseClassPropertySetterExample<T> : MonoBehaviour
	{
		[SerializeField]
		[PropertyBackingField]
		private T m_Single;

		[SerializeField]
		[PropertyBackingField]
		private List<T> m_Array;

		public T Single
		{
			get
			{
				return (T)null;
			}
			set
			{
			}
		}

		public T[] GetArray()
		{
			return null;
		}

		public void SetArray(T[] value)
		{
		}
	}
}
