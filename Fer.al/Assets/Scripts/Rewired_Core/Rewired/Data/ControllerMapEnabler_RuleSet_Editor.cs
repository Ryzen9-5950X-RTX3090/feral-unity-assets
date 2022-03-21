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
	public sealed class ControllerMapEnabler_RuleSet_Editor
	{
		[SerializeField]
		[Serialize]
		private int _id;

		[Serialize]
		[SerializeField]
		private string _name;

		[SerializeField]
		[Serialize]
		private string _tag;

		[Serialize]
		[SerializeField]
		private List<ControllerMapEnabler_Rule_Editor> _rules;

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

		public List<ControllerMapEnabler_Rule_Editor> rules
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ControllerMapEnabler_RuleSet_Editor()
		{
		}

		public ControllerMapEnabler_RuleSet_Editor(ControllerMapEnabler_RuleSet_Editor source)
		{
		}

		internal ControllerMapEnabler_RuleSet_Editor Clone()
		{
			return null;
		}

		internal ControllerMapEnabler.RuleSet ToRuntime()
		{
			return null;
		}
	}
}
