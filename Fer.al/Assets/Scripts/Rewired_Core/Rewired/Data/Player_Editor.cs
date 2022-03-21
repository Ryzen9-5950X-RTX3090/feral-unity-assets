using System;
using System.Collections.Generic;
using System.ComponentModel;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Data
{
	[Serializable]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class Player_Editor
	{
		[Serializable]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public sealed class Mapping
		{
			[CustomObfuscation]
			[SerializeField]
			private bool _enabled;

			[SerializeField]
			[CustomObfuscation]
			private int _categoryId;

			[CustomObfuscation]
			[SerializeField]
			private int _layoutId;

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

			public int layoutId
			{
				get
				{
					return default(int);
				}
				internal set
				{
				}
			}

			public bool enabled
			{
				get
				{
					return default(bool);
				}
				internal set
				{
				}
			}

			public Mapping()
			{
			}

			public Mapping(bool enabled, int categoryId, int layoutId)
			{
			}

			public void Clear()
			{
			}

			public Mapping Clone()
			{
				return null;
			}

			internal VazWCJszjSvmMxSvRJnnBczpVoI EehxeDwcaGcprdQyuinMghJJemBp()
			{
				return null;
			}
		}

		[Serializable]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public sealed class ControllerMapLayoutManagerSettings : IDeepCloneable
		{
			[SerializeField]
			[CustomObfuscation]
			private bool _enabled;

			[CustomObfuscation]
			[SerializeField]
			private bool _loadFromUserDataStore;

			[CustomObfuscation]
			[SerializeField]
			private List<RuleSetMapping> _ruleSets;

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

			public List<RuleSetMapping> ruleSets
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public ControllerMapLayoutManagerSettings()
			{
			}

			public ControllerMapLayoutManagerSettings(ControllerMapLayoutManagerSettings source)
			{
			}

			internal ControllerMapLayoutManager.StartingSettings RvdvIxzowteyskgMeqDfHhJQQrH()
			{
				return null;
			}

			private MoWpPnIELFeSQuddbxIWcvZmvTK[] YIwTfelsdOSBRQKqbgCqZTPYzQn()
			{
				return null;
			}

			object IDeepCloneable.DeepClone()
			{
				return null;
			}
		}

		[Serializable]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public sealed class ControllerMapEnablerSettings : IDeepCloneable
		{
			[CustomObfuscation]
			[SerializeField]
			private bool _enabled;

			[CustomObfuscation]
			[SerializeField]
			private List<RuleSetMapping> _ruleSets;

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

			public List<RuleSetMapping> ruleSets
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public ControllerMapEnablerSettings()
			{
			}

			public ControllerMapEnablerSettings(ControllerMapEnablerSettings source)
			{
			}

			internal ControllerMapEnabler.ZgESyvoCZDaaWJMTaxFmFrlTHlVN RvdvIxzowteyskgMeqDfHhJQQrH()
			{
				return null;
			}

			private MoWpPnIELFeSQuddbxIWcvZmvTK[] YIwTfelsdOSBRQKqbgCqZTPYzQn()
			{
				return null;
			}

			object IDeepCloneable.DeepClone()
			{
				return null;
			}
		}

		[Serializable]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public sealed class RuleSetMapping : IDeepCloneable
		{
			[SerializeField]
			[CustomObfuscation]
			private bool _enabled;

			[SerializeField]
			[CustomObfuscation]
			private int _id;

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

			public bool enabled
			{
				get
				{
					return default(bool);
				}
				internal set
				{
				}
			}

			public RuleSetMapping()
			{
			}

			public RuleSetMapping(RuleSetMapping source)
			{
			}

			public RuleSetMapping(bool enabled, int id)
			{
			}

			public void Clear()
			{
			}

			public RuleSetMapping Clone()
			{
				return null;
			}

			internal MoWpPnIELFeSQuddbxIWcvZmvTK lGlqqLKpgWtHsjamVbzJIaKUfzy()
			{
				return null;
			}

			object IDeepCloneable.DeepClone()
			{
				return null;
			}
		}

		[Serializable]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public sealed class CreateControllerInfo
		{
			[SerializeField]
			[CustomObfuscation]
			private int _sourceId;

			[SerializeField]
			[CustomObfuscation]
			private string _tag;

			public int sourceId
			{
				get
				{
					return default(int);
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

			public CreateControllerInfo()
			{
			}

			public CreateControllerInfo(int sourceId, string tag)
			{
			}

			public CreateControllerInfo(CreateControllerInfo source)
			{
			}
		}

		[CustomObfuscation]
		[SerializeField]
		private int _id;

		[SerializeField]
		[CustomObfuscation]
		private string _name;

		[CustomObfuscation]
		[SerializeField]
		private string _descriptiveName;

		[CustomObfuscation]
		[SerializeField]
		private bool _startPlaying;

		[CustomObfuscation]
		[SerializeField]
		private List<Mapping> _defaultJoystickMaps;

		[SerializeField]
		[CustomObfuscation]
		private List<Mapping> _defaultMouseMaps;

		[SerializeField]
		[CustomObfuscation]
		private List<Mapping> _defaultKeyboardMaps;

		[CustomObfuscation]
		[SerializeField]
		private List<Mapping> _defaultCustomControllerMaps;

		[SerializeField]
		[CustomObfuscation]
		private List<CreateControllerInfo> _startingCustomControllers;

		[CustomObfuscation]
		[SerializeField]
		private bool _assignMouseOnStart;

		[CustomObfuscation]
		[SerializeField]
		private bool _assignKeyboardOnStart;

		[SerializeField]
		[CustomObfuscation]
		private bool _excludeFromControllerAutoAssignment;

		[CustomObfuscation]
		[SerializeField]
		private ControllerMapLayoutManagerSettings _controllerMapLayoutManagerSettings;

		[SerializeField]
		[CustomObfuscation]
		private ControllerMapEnablerSettings _controllerMapEnablerSettings;

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

		public bool startPlaying
		{
			get
			{
				return default(bool);
			}
			internal set
			{
			}
		}

		public List<Mapping> defaultJoystickMaps
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public List<Mapping> defaultMouseMaps
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public List<Mapping> defaultKeyboardMaps
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public List<Mapping> defaultCustomControllerMaps
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public List<CreateControllerInfo> startingCustomControllers
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public bool assignMouseOnStart
		{
			get
			{
				return default(bool);
			}
			internal set
			{
			}
		}

		public bool assignKeyboardOnStart
		{
			get
			{
				return default(bool);
			}
			internal set
			{
			}
		}

		public bool excludeFromControllerAutoAssignment
		{
			get
			{
				return default(bool);
			}
			internal set
			{
			}
		}

		public ControllerMapLayoutManagerSettings controllerMapLayoutManagerSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ControllerMapEnablerSettings controllerMapEnablerSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Player_Editor()
		{
		}

		public Player_Editor(Player_Editor source)
		{
		}

		public Player_Editor Clone()
		{
			return null;
		}

		internal VVLouGbEKulMPcFZiTUTqikUjEp EpfIttlsNHKfwEcDxUNaegzLSWO()
		{
			return null;
		}
	}
}
