using System;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	public class InputCategory
	{
		[CustomObfuscation]
		[SerializeField]
		protected string _name;

		[CustomObfuscation]
		[SerializeField]
		protected string _descriptiveName;

		[SerializeField]
		[CustomObfuscation]
		protected string _tag;

		[SerializeField]
		[CustomObfuscation]
		protected int _id;

		[SerializeField]
		[CustomObfuscation]
		protected bool _userAssignable;

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

		public string tag
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

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

		public InputCategory()
		{
		}

		public InputCategory(InputCategory source)
		{
		}
	}
}
