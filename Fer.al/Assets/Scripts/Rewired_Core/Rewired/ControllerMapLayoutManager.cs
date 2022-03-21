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
	public sealed class ControllerMapLayoutManager
	{
		internal class StartingSettings
		{
			public bool enabled;

			public bool loadFromUserDataStore;

			public MoWpPnIELFeSQuddbxIWcvZmvTK[] startingRuleSets;

			public StartingSettings(bool enabled, bool loadFromUserDataStore, MoWpPnIELFeSQuddbxIWcvZmvTK[] startingRuleSets)
			{
			}
		}

		[Serializable]
		[CustomClassObfuscation]
		[Preserve]
		public sealed class Rule : IDeepCloneable
		{
			[Serialize]
			[SerializeField]
			private string _tag;

			[Serialize]
			[SerializeField]
			private int[] _categoryIds;

			[Serialize]
			[SerializeField]
			private int _layoutId;

			[Serialize]
			[SerializeField]
			private ControllerSetSelector _controllerSetSelector;

			[NonSerialized]
			private string[] _preInitCategoryNames;

			[NonSerialized]
			private string _preInitLayoutName;

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

			internal Rule(string tag, int[] categoryIds, int layoutId, ControllerSetSelector controllerSetSelector)
			{
			}

			private void Initialize()
			{
			}

			object IDeepCloneable.DeepClone()
			{
				return null;
			}
		}

		[Serializable]
		[Preserve]
		[CustomClassObfuscation]
		[SerializationType(SerializationTypeAttribute.SerializationType.Object)]
		public sealed class RuleSet : IDeepCloneable, IEnumerable, IList<Rule>, ICollection<Rule>, IEnumerable<Rule>
		{
			private const string className = "ControllerMapLayoutManager.RuleSet";

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

		private bool _enabled;

		private bool _loadFromUserDataStore;

		private Player _player;

		private StartingSettings _startingSettings;

		private readonly int _reInputId;

		private List<RuleSet> _ruleSets;

		private Action _ApplyCalledEvent;

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

		public bool loadFromUserDataStore
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

		internal event Action ApplyCalledEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal ControllerMapLayoutManager(Player player, StartingSettings startingSettings)
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

		private SerializedObject Export()
		{
			return null;
		}

		private void ExportDataToSerializedObject(SerializedObject serializedObject)
		{
		}

		private bool Import(SerializedObject serializedObject)
		{
			return default(bool);
		}
	}
}
