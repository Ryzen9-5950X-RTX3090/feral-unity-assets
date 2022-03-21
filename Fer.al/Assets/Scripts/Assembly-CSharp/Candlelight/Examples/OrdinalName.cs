using System;
using UnityEngine;

namespace Candlelight.Examples
{
	[Serializable]
	public struct OrdinalName : IPropertyBackingFieldCompatible<OrdinalName>, IPropertyBackingFieldCompatible, ICloneable, IEquatable<OrdinalName>
	{
		[SerializeField]
		private int m_Index;

		[SerializeField]
		private string m_Name;

		public int Index
		{
			get
			{
				return default(int);
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
		}

		public OrdinalName(int index, string name)
		{
		}

		object ICloneable.Clone()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public bool Equals(OrdinalName other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		int IPropertyBackingFieldCompatible.GetSerializedPropertiesHash()
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
