using UnityEngine;

namespace Candlelight.Examples
{
	public class BasicPropertySetterExample : MonoBehaviour
	{
		[SerializeField]
		[PropertyBackingField]
		private bool m_Bool;

		[SerializeField]
		[PropertyBackingField]
		private int m_Int;

		[SerializeField]
		[PropertyBackingField]
		private float m_Float;

		public bool Bool
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int SomeInt
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public float Float
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}
	}
}
