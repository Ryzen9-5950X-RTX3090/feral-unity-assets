using System;
using System.Collections.Generic;
using FMOD;
using FMOD.Studio;
using UnityEngine;

namespace FMODUnity
{
	public abstract class Platform : ScriptableObject, IComparable<Platform>
	{
		public class Property<T>
		{
			public T Value;

			public bool HasValue;
		}

		[Serializable]
		public class PropertyBool : Property<TriStateBool>
		{
		}

		[Serializable]
		public class PropertyInt : Property<int>
		{
		}

		[Serializable]
		public class PropertySpeakerMode : Property<SPEAKERMODE>
		{
		}

		[Serializable]
		public class PropertyString : Property<string>
		{
		}

		[Serializable]
		public class PropertyStringList : Property<List<string>>
		{
		}

		[Serializable]
		public class PropertyCallbackHandler : Property<PlatformCallbackHandler>
		{
		}

		public struct PropertyAccessor<T>
		{
			private readonly Func<PropertyStorage, Property<T>> Getter;

			private readonly T DefaultValue;

			public PropertyAccessor(Func<PropertyStorage, Property<T>> getter, T defaultValue)
			{
			}

			public bool HasValue(Platform platform)
			{
				return default(bool);
			}

			public T Get(Platform platform)
			{
				return (T)null;
			}

			public void Set(Platform platform, T value)
			{
			}

			public void Clear(Platform platform)
			{
			}
		}

		[Serializable]
		public class PropertyStorage
		{
			public PropertyBool LiveUpdate;

			public PropertyInt LiveUpdatePort;

			public PropertyBool Overlay;

			public PropertyBool Logging;

			public PropertyInt SampleRate;

			public PropertyString BuildDirectory;

			public PropertySpeakerMode SpeakerMode;

			public PropertyInt VirtualChannelCount;

			public PropertyInt RealChannelCount;

			public PropertyInt DSPBufferLength;

			public PropertyInt DSPBufferCount;

			public PropertyStringList Plugins;

			public PropertyStringList StaticPlugins;

			public PropertyCallbackHandler CallbackHandler;
		}

		public static class PropertyAccessors
		{
			public static readonly PropertyAccessor<TriStateBool> LiveUpdate;

			public static readonly PropertyAccessor<int> LiveUpdatePort;

			public static readonly PropertyAccessor<TriStateBool> Overlay;

			public static readonly PropertyAccessor<TriStateBool> Logging;

			public static readonly PropertyAccessor<int> SampleRate;

			public static readonly PropertyAccessor<string> BuildDirectory;

			public static readonly PropertyAccessor<SPEAKERMODE> SpeakerMode;

			public static readonly PropertyAccessor<int> VirtualChannelCount;

			public static readonly PropertyAccessor<int> RealChannelCount;

			public static readonly PropertyAccessor<int> DSPBufferLength;

			public static readonly PropertyAccessor<int> DSPBufferCount;

			public static readonly PropertyAccessor<List<string>> Plugins;

			public static readonly PropertyAccessor<List<string>> StaticPlugins;

			public static readonly PropertyAccessor<PlatformCallbackHandler> CallbackHandler;
		}

		[Serializable]
		public class PropertyThreadAffinityList : Property<List<ThreadAffinityGroup>>
		{
		}

		[SerializeField]
		private string identifier;

		public const float DefaultPriority = 0f;

		public const string RegisterStaticPluginsFunctionName = "FMOD_Unity_RegisterStaticPlugins";

		[SerializeField]
		private string parentIdentifier;

		[SerializeField]
		private float displaySortOrder;

		[SerializeField]
		private bool active;

		[SerializeField]
		protected PropertyStorage Properties;

		[NonSerialized]
		private Platform parent;

		[NonSerialized]
		private readonly List<Platform> children;

		[SerializeField]
		public string outputType;

		private static List<ThreadAffinityGroup> StaticThreadAffinities;

		[SerializeField]
		private PropertyThreadAffinityList threadAffinities;

		public string Identifier
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public abstract string DisplayName { get; }

		public virtual float Priority
		{
			get
			{
				return default(float);
			}
		}

		public virtual bool MatchesCurrentEnvironment
		{
			get
			{
				return default(bool);
			}
		}

		public virtual bool IsIntrinsic
		{
			get
			{
				return default(bool);
			}
		}

		public string ParentIdentifier
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float DisplaySortOrder
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool IsLiveUpdateEnabled
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsOverlayEnabled
		{
			get
			{
				return default(bool);
			}
		}

		public bool Active
		{
			get
			{
				return default(bool);
			}
		}

		public bool HasAnyOverriddenProperties
		{
			get
			{
				return default(bool);
			}
		}

		public TriStateBool LiveUpdate
		{
			get
			{
				return default(TriStateBool);
			}
		}

		public int LiveUpdatePort
		{
			get
			{
				return default(int);
			}
		}

		public TriStateBool Overlay
		{
			get
			{
				return default(TriStateBool);
			}
		}

		public TriStateBool Logging
		{
			get
			{
				return default(TriStateBool);
			}
		}

		public int SampleRate
		{
			get
			{
				return default(int);
			}
		}

		public string BuildDirectory
		{
			get
			{
				return null;
			}
		}

		public SPEAKERMODE SpeakerMode
		{
			get
			{
				return default(SPEAKERMODE);
			}
		}

		public int VirtualChannelCount
		{
			get
			{
				return default(int);
			}
		}

		public int RealChannelCount
		{
			get
			{
				return default(int);
			}
		}

		public int DSPBufferLength
		{
			get
			{
				return default(int);
			}
		}

		public int DSPBufferCount
		{
			get
			{
				return default(int);
			}
		}

		public List<string> Plugins
		{
			get
			{
				return null;
			}
		}

		public List<string> StaticPlugins
		{
			get
			{
				return null;
			}
		}

		public PlatformCallbackHandler CallbackHandler
		{
			get
			{
				return null;
			}
		}

		public Platform Parent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<Platform> Children
		{
			get
			{
				return null;
			}
		}

		public virtual List<ThreadAffinityGroup> DefaultThreadAffinities
		{
			get
			{
				return null;
			}
		}

		public IEnumerable<ThreadAffinityGroup> ThreadAffinities
		{
			get
			{
				return null;
			}
		}

		public PropertyThreadAffinityList ThreadAffinitiesProperty
		{
			get
			{
				return null;
			}
		}

		public abstract void DeclareUnityMappings(Settings settings);

		public virtual void PreSystemCreate(Action<RESULT, string> reportResult)
		{
		}

		public virtual void PreInitialize(FMOD.Studio.System studioSystem)
		{
		}

		public virtual string GetBankFolder()
		{
			return null;
		}

		protected virtual string GetPluginBasePath()
		{
			return null;
		}

		protected virtual string GetEditorPluginBasePath()
		{
			return null;
		}

		public virtual string GetPluginPath(string pluginName)
		{
			return null;
		}

		public virtual void LoadPlugins(FMOD.System coreSystem, Action<RESULT, string> reportResult)
		{
		}

		public virtual void LoadDynamicPlugins(FMOD.System coreSystem, Action<RESULT, string> reportResult)
		{
		}

		public virtual void LoadStaticPlugins(FMOD.System coreSystem, Action<RESULT, string> reportResult)
		{
		}

		private static extern RESULT FMOD_Unity_RegisterStaticPlugins(string coreLibraryName, IntPtr system);

		public void AffirmProperties()
		{
		}

		public void ClearProperties()
		{
		}

		public virtual void InitializeProperties()
		{
		}

		public virtual void EnsurePropertiesAreValid()
		{
		}

		public int CompareTo(Platform other)
		{
			return default(int);
		}

		public bool InheritsFrom(Platform platform)
		{
			return default(bool);
		}

		public OUTPUTTYPE GetOutputType()
		{
			return default(OUTPUTTYPE);
		}
	}
}
