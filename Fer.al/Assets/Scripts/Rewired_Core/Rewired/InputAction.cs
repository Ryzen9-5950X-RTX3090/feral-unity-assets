using System;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	public sealed class InputAction
	{
		[SerializeField]
		[CustomObfuscation]
		private int _id;

		[CustomObfuscation]
		[SerializeField]
		private string _name;

		[CustomObfuscation]
		[SerializeField]
		private InputActionType _type;

		[SerializeField]
		[CustomObfuscation]
		private string _descriptiveName;

		[CustomObfuscation]
		[SerializeField]
		private string _positiveDescriptiveName;

		[SerializeField]
		[CustomObfuscation]
		private string _negativeDescriptiveName;

		[SerializeField]
		[CustomObfuscation]
		private int _behaviorId;

		[SerializeField]
		[CustomObfuscation]
		private bool _userAssignable;

		[SerializeField]
		[CustomObfuscation]
		private int _categoryId;

		[NonSerialized]
		private string BzSHOSBxHTsRNRpWFylLxwSXAwr;

		[NonSerialized]
		private string VdDfVbcczPozqcIQWsfZfUSQZbQ;

		public int id
		{
			get
			{
				return default(int);
			}
			internal set
			{
			}
		}

		public string name
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public InputActionType type
		{
			get
			{
				return default(InputActionType);
			}
			internal set
			{
			}
		}

		public string descriptiveName
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public string positiveDescriptiveName
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public string negativeDescriptiveName
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public int behaviorId
		{
			get
			{
				return default(int);
			}
			internal set
			{
			}
		}

		public int categoryId
		{
			get
			{
				return default(int);
			}
			internal set
			{
			}
		}

		public bool userAssignable
		{
			get
			{
				return default(bool);
			}
			internal set
			{
			}
		}

		public InputAction()
		{
		}

		public InputAction(InputAction source)
		{
		}

		public InputAction Clone()
		{
			return null;
		}
	}
}
