using System;
using UnityEngine;

namespace Candlelight.Examples
{
	[Serializable]
	public class Character : BackingFieldCompatibleObject
	{
		[SerializeField]
		[PropertyBackingField]
		private string m_Name;

		[SerializeField]
		[PropertyBackingField]
		private float m_MaxHealth;

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float MaxHealth
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		private Character()
		{
		}

		public Character(string name, float maxHealth = 1f)
		{
		}

		public override object Clone()
		{
			return null;
		}

		public override int GetSerializedPropertiesHash()
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
