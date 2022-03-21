using System.ComponentModel;
using UnityEngine;

namespace Rewired
{
	[CustomClassObfuscation]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class Initializer : MonoBehaviour
	{
		[SerializeField]
		private GameObject _inputManagerPrefab;

		[SerializeField]
		private bool _destroySelf;

		public GameObject inputManagerPrefab
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool destroySelf
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		public bool Initialize()
		{
			return default(bool);
		}
	}
}
