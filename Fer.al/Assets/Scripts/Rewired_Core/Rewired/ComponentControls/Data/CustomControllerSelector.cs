using System;
using Rewired.Utils.Attributes;
using UnityEngine;

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	[CustomClassObfuscation]
	public sealed class CustomControllerSelector
	{
		[SerializeField]
		[CustomObfuscation]
		[Tooltip("If true, the Custom Controller will be searched for by its source controller id. This can be used with Find in Player and/or Find Using Tag to further refine the search parameters.")]
		private bool _findUsingSourceId;

		[CustomObfuscation]
		[SerializeField]
		[FieldRange(0, int.MaxValue)]
		[Tooltip("The source id of the Custom Controller. This is used to find the Custom Controller if Find Using Source Id is True.")]
		private int _sourceId;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("If true, the Custom Controller will be found using the tag specified here. This can be used with Find in Player and/or Find Using Source Id to further refine the search parameters.")]
		private bool _findUsingTag;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The tag on the Custom Controller you wish to use. This is used to find the Custom Controller.")]
		private string _tag;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("If true, the Custom Controller will be searched for in the Player specified in the Player Id field. This can be used with Find Using Source Id and/or Find Using Tag to further refine the search parameters.")]
		private bool _findInPlayer;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("The Player Id of the Player that owns the Custom Controller.")]
		private int _playerId;

		public bool findUsingSourceId
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int sourceId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool findUsingTag
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public string tag
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool findInPlayer
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int playerId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		internal Rewired.CustomController GetCustomController()
		{
			return null;
		}

		private void cmtbuFqVYbwoFNiprYsdGZCxOJZ()
		{
		}
	}
}
