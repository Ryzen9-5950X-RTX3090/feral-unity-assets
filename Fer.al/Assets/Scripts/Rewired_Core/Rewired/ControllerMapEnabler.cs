using System;
using System.Collections;
using System.Collections.Generic;
using Rewired.Utils.Attributes;
using Rewired.Utils.Classes.Data;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired
{
	public sealed class ControllerMapEnabler
	{
		[Serializable]
		[CustomClassObfuscation]
		[Preserve]
		public sealed class Rule : IDeepCloneable
		{
			[Serialize]
			[SerializeField]
			private string _tag;

			[SerializeField]
			[Serialize]
			private bool _enable;

			[Serialize]
			[SerializeField]
			private int[] _categoryIds;

			[SerializeField]
			[Serialize]
			private int[] _layoutIds;

			[Serialize]
			[SerializeField]
			private ControllerSetSelector _controllerSetSelector;

			[NonSerialized]
			private string[] _preInitCategoryNames;

			[NonSerialized]
			private string[] _preInitLayoutNames;

			internal bool appliesToAllLayouts
			{
				get
				{
					return default(bool);
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

			public bool enable
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public ControllerSetSelector controllerSetSelector
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public int[] categoryIds
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public int[] layoutIds
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public int categoryId
			{
				get
				{
					return default(int);
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

			public string[] categoryNames
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public string[] layoutNames
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public string categoryName
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public string layoutName
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			internal bool isValid
			{
				get
				{
					return default(bool);
				}
			}

			public Rule()
			{
			}

			public Rule(Rule source)
			{
			}

			internal Rule(string tag, bool enabled, int[] categoryIds, int[] layoutIds, ControllerSetSelector controllerSetSelector)
			{
			}

			internal bool Matches(ControllerMap map)
			{
				return default(bool);
			}

			private void Initialize()
			{
			}

			private void CheckNoControllerTypeError()
			{
			}

			object IDeepCloneable.DeepClone()
			{
				return null;
			}
		}

		[Serializable]
		[CustomClassObfuscation]
		[Preserve]
		[SerializationType(SerializationTypeAttribute.SerializationType.Object)]
		public sealed class RuleSet : IDeepCloneable, IEnumerable, IList<Rule>, ICollection<Rule>, IEnumerable<Rule>
		{
			private const string className = "ControllerMapEnabler.RuleSet";

			[SerializeField]
			[Serialize]
			private bool _enabled;

			[SerializeField]
			[Serialize]
			private string _tag;

			[SerializeField]
			[Serialize]
			private List<Rule> _rules;

			public bool enabled
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

			public List<Rule> rules
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public Rule this[int index]
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public int Count
			{
				get
				{
					return default(int);
				}
			}

			bool ICollection<Rule>.IsReadOnly
			{
				get
				{
					return default(bool);
				}
			}

			internal RuleSet(bool enabled, string tag, List<Rule> rules)
			{
			}

			public RuleSet()
			{
			}

			public RuleSet(RuleSet source)
			{
			}

			public Rule Find(Predicate<Rule> predicate)
			{
				return null;
			}

			public Rule FindLast(Predicate<Rule> predicate)
			{
				return null;
			}

			public int FindIndex(Predicate<Rule> predicate)
			{
				return default(int);
			}

			public int FindLastIndex(Predicate<Rule> predicate)
			{
				return default(int);
			}

			public int IndexOf(Rule item)
			{
				return default(int);
			}

			public void Insert(int index, Rule item)
			{
			}

			public void RemoveAt(int index)
			{
			}

			public void Add(Rule item)
			{
			}

			public void Clear()
			{
			}

			public bool Contains(Rule item)
			{
				return default(bool);
			}

			public void CopyTo(Rule[] array, int arrayIndex)
			{
			}

			public bool Remove(Rule item)
			{
				return default(bool);
			}

			public IEnumerator<Rule> GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			object IDeepCloneable.DeepClone()
			{
				return null;
			}

			private void CheckList()
			{
			}
		}

		internal class ZgESyvoCZDaaWJMTaxFmFrlTHlVN
		{
			public bool XCmLqGiIjecniTtyESDfezXWsFX;

			public MoWpPnIELFeSQuddbxIWcvZmvTK[] PRilaMdORVIUTsbFhylqHYDEvLm;

			public ZgESyvoCZDaaWJMTaxFmFrlTHlVN(bool enabled, MoWpPnIELFeSQuddbxIWcvZmvTK[] startingRuleSets)
			{
			}
		}

		private bool RYgMGyqWnNNUOzFUBDIFjvchsBxb;

		private Player ynTKxtAzNzOSGMpUVXFSwhkyvv;

		private ZgESyvoCZDaaWJMTaxFmFrlTHlVN miqBKqhkUThElnqKkeIwpdnWqLmc;

		private readonly int vSShldFHkaZKEuThltrSgFmPfc;

		private List<RuleSet> nMpueEaWTJqSZWcblEgxDXnPgpDS;

		public bool enabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public List<RuleSet> ruleSets
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal ControllerMapEnabler(Player player, ZgESyvoCZDaaWJMTaxFmFrlTHlVN startingSettings)
		{
		}

		public void Apply()
		{
		}

		public void LoadDefaults()
		{
		}

		public string ToXmlString()
		{
			return null;
		}

		public string ToJsonString()
		{
			return null;
		}

		public bool ImportXml(string xmlString)
		{
			return default(bool);
		}

		public bool ImportJson(string jsonString)
		{
			return default(bool);
		}

		private SerializedObject uJZpqEBLkJUYeZxXRkMWiNxeekH()
		{
			return null;
		}

		private void RKMnWkLYIShhsCAJrbDGpkKewIS(SerializedObject P_0)
		{
		}

		private bool BxoFMvWmvalDyQMZPpCVmdbosOa(SerializedObject P_0)
		{
			return default(bool);
		}
	}
}
