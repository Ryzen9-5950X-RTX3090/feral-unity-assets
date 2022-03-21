using System.Collections.Generic;
using UnityEngine;

namespace Candlelight.Examples
{
	public class ArrayPropertySetterExample : MonoBehaviour
	{
		[SerializeField]
		[PropertyBackingField]
		private int[] m_ArrayProperty;

		[SerializeField]
		[PropertyBackingField]
		private List<int> m_ListProperty;

		[SerializeField]
		[PropertyBackingField]
		private List<int> m_AnotherListProperty;

		public int[] GetArrayProperty()
		{
			return null;
		}

		public void SetArrayProperty(int[] value)
		{
		}

		public int[] GetListProperty()
		{
			return null;
		}

		public void SetListProperty(int[] value)
		{
		}

		public int[] GetAnotherListProperty()
		{
			return null;
		}

		private void SetAnotherListProperty(int[] value)
		{
		}

		public void SetAnotherListProperty(IEnumerable<int> value)
		{
		}
	}
}
