using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace NodeCanvas.Framework.Internal
{
	[Serializable]
	public class BBObjectParameter : BBParameter<object>, ISerializationCallbackReceiver
	{
		[SerializeField]
		private string _type;

		private Type type
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

		public override Type varType
		{
			get
			{
				return null;
			}
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		public BBObjectParameter()
		{
		}

		public BBObjectParameter(Type t)
		{
		}

		public BBObjectParameter(BBParameter source)
		{
		}

		public void SetType(Type t)
		{
		}
	}
}
