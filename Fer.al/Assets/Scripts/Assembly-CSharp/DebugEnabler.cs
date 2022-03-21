using System;
using UnityEngine;

public class DebugEnabler : ManagedBehaviour
{
	[Serializable]
	public class Reference
	{
		public bool activeOnStart;

		public GameObject gameObject;

		private bool _active;

		public bool Active
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}
	}

	[SerializeField]
	private Reference[] _references;
}
