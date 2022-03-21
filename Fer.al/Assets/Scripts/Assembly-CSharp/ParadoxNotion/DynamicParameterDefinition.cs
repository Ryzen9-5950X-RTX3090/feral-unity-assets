using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ParadoxNotion
{
	[Serializable]
	public sealed class DynamicParameterDefinition : ISerializationCallbackReceiver
	{
		[SerializeField]
		private string _ID;

		[SerializeField]
		private string _name;

		[SerializeField]
		private string _type;

		public string ID
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Type type
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		public DynamicParameterDefinition()
		{
		}

		public DynamicParameterDefinition(string name, Type type)
		{
		}
	}
}
