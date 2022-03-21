using System;
using System.Collections.Generic;
using Rewired.Utils.Attributes;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired.Data
{
	[Serializable]
	[Preserve]
	[CustomClassObfuscation]
	public sealed class ControllerMapLayoutManager_RuleSet_Editor
	{
		[SerializeField]
		[Serialize]
		private int _id;

		[SerializeField]
		[Serialize]
		private string _name;

		[SerializeField]
		[Serialize]
		private string _tag;

		[SerializeField]
		[Serialize]
		private List<ControllerMapLayoutManager_Rule_Editor> _rules;

		public int id
		{
			get
			{
				return default(int);
			}
			set
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

		public List<ControllerMapLayoutManager_Rule_Editor> rules
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ControllerMapLayoutManager_RuleSet_Editor()
		{
		}

		public ControllerMapLayoutManager_RuleSet_Editor(ControllerMapLayoutManager_RuleSet_Editor source)
		{
		}

		internal ControllerMapLayoutManager_RuleSet_Editor Clone()
		{
			return null;
		}

		internal ControllerMapLayoutManager.RuleSet ToRuntime()
		{
			return null;
		}
	}
}
