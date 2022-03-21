using System;
using System.Collections.Generic;
using Rewired.Utils.Attributes;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired.Data
{
	[Serializable]
	[Preserve]
	[CustomClassObfuscation]
	public sealed class ControllerMapLayoutManager_Rule_Editor : IDeepCloneable
	{
		[Serialize]
		[SerializeField]
		private string _tag;

		[Serialize]
		[SerializeField]
		private List<int> _categoryIds;

		[Serialize]
		[SerializeField]
		private int _layoutId;

		[Serialize]
		[SerializeField]
		private ControllerSetSelector_Editor _controllerSetSelector;

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

		public List<int> categoryIds
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int layoutId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public ControllerSetSelector_Editor controllerSetSelector
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ControllerMapLayoutManager_Rule_Editor()
		{
		}

		public ControllerMapLayoutManager_Rule_Editor(ControllerMapLayoutManager_Rule_Editor source)
		{
		}

		internal ControllerMapLayoutManager.Rule ToRuntime()
		{
			return null;
		}

		object IDeepCloneable.DeepClone()
		{
			return null;
		}
	}
}
