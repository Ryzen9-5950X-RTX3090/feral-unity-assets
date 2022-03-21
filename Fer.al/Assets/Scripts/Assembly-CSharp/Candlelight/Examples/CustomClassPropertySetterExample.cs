using UnityEngine;

namespace Candlelight.Examples
{
	public class CustomClassPropertySetterExample : MonoBehaviour
	{
		public class TwoLineReorderableListElement : PropertyAttribute
		{
		}

		[SerializeField]
		[PropertyBackingField]
		[Header("Custom Struct")]
		private OrdinalName m_OrdinalName;

		[SerializeField]
		[PropertyBackingField]
		private OrdinalName[] m_OrdinalNames;

		[SerializeField]
		[PropertyBackingField]
		[Header("Custom Class")]
		private Character m_Character;

		[SerializeField]
		[PropertyBackingField]
		private Character[] m_Characters;

		public OrdinalName OrdinalName
		{
			get
			{
				return default(OrdinalName);
			}
			set
			{
			}
		}

		public Character Character
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public OrdinalName[] GetOrdinalNames()
		{
			return null;
		}

		public void SetOrdinalNames(OrdinalName[] value)
		{
		}

		public Character[] GetCharacters()
		{
			return null;
		}

		public void SetCharacters(Character[] value)
		{
		}
	}
}
