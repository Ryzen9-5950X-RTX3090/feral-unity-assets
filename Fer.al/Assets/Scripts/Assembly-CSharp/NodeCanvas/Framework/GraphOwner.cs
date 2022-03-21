using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Serialization;
using UnityEngine;
using UnityEngine.Serialization;

namespace NodeCanvas.Framework
{
	public abstract class GraphOwner : ManagedBehaviour, ISerializationCallbackReceiver
	{
		public enum EnableAction
		{
			EnableBehaviour,
			DoNothing
		}

		public enum DisableAction
		{
			DisableBehaviour,
			PauseBehaviour,
			DoNothing
		}

		public enum FirstActivation
		{
			OnEnable,
			OnStart,
			Async
		}

		[SerializeField]
		private SerializationPair[] _serializedExposedParameters;

		[SerializeField]
		[FormerlySerializedAs("boundGraphSerialization")]
		private string _boundGraphSerialization;

		[SerializeField]
		[FormerlySerializedAs("boundGraphObjectReferences")]
		private List<UnityEngine.Object> _boundGraphObjectReferences;

		[SerializeField]
		private GraphSource _boundGraphSource;

		[SerializeField]
		[FormerlySerializedAs("firstActivation")]
		[Tooltip("When the graph will first activate. Async mode will load the graph on a separate thread (thus no spikes), but the graph will activate a few frames later.")]
		private FirstActivation _firstActivation;

		[SerializeField]
		[FormerlySerializedAs("enableAction")]
		[Tooltip("What will happen when the GraphOwner is enabled")]
		private EnableAction _enableAction;

		[SerializeField]
		[FormerlySerializedAs("disableAction")]
		[Tooltip("What will happen when the GraphOwner is disabled")]
		private DisableAction _disableAction;

		[SerializeField]
		[Tooltip("If enabled, bound graph prefab overrides in instances will not be possible")]
		private bool _lockBoundGraphPrefabOverrides;

		[SerializeField]
		[Tooltip("If enabled, all subgraphs will be pre-initialized in Awake along with the root graph, but this may have a loading performance cost")]
		private bool _preInitializeSubGraphs;

		[SerializeField]
		[Tooltip("Specify when (if) the behaviour is updated. Changes to this only work when the behaviour starts, or re-starts")]
		private Graph.UpdateMode _updateMode;

		private Dictionary<Graph, Graph> instances;

		public List<ExposedParameter> exposedParameters
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public abstract Graph graph { get; set; }

		public abstract IBlackboard blackboard { get; set; }

		public abstract Type graphType { get; }

		public bool initialized
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool enableCalled
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool startCalled
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public GraphSource boundGraphSource
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public string boundGraphSerialization
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public List<UnityEngine.Object> boundGraphObjectReferences
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public bool lockBoundGraphPrefabOverrides
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool preInitializeSubGraphs
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public FirstActivation firstActivation
		{
			get
			{
				return default(FirstActivation);
			}
			set
			{
			}
		}

		public EnableAction enableAction
		{
			get
			{
				return default(EnableAction);
			}
			set
			{
			}
		}

		public DisableAction disableAction
		{
			get
			{
				return default(DisableAction);
			}
			set
			{
			}
		}

		public Graph.UpdateMode updateMode
		{
			get
			{
				return default(Graph.UpdateMode);
			}
			set
			{
			}
		}

		public bool graphIsBound
		{
			get
			{
				return default(bool);
			}
		}

		public bool isRunning
		{
			get
			{
				return default(bool);
			}
		}

		public bool isPaused
		{
			get
			{
				return default(bool);
			}
		}

		public float elapsedTime
		{
			get
			{
				return default(float);
			}
		}

		public static event Action<GraphOwner> onOwnerBehaviourStateChange
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action onMonoBehaviourStart
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		protected Graph GetInstance(Graph originalGraph)
		{
			return null;
		}

		public void StartBehaviour()
		{
		}

		public void StartBehaviour(Action<bool> callback)
		{
		}

		public void StartBehaviour(Graph.UpdateMode updateMode, [Optional] Action<bool> callback)
		{
		}

		public void PauseBehaviour()
		{
		}

		public void StopBehaviour(bool success = true)
		{
		}

		public void UpdateBehaviour()
		{
		}

		public void RestartBehaviour()
		{
		}

		public void SendEvent(string eventName)
		{
		}

		public void SendEvent(string eventName, object value, object sender)
		{
		}

		public void SendEvent<T>(string eventName, T eventValue, object sender)
		{
		}

		public void SetExposedParameterValue<T>(string name, T value)
		{
		}

		public T GetExposedParameterValue<T>(string name)
		{
			return (T)null;
		}

		public override void MAwake()
		{
		}

		public void Initialize()
		{
		}

		public void BindExposedParameters()
		{
		}

		public override void MOnEnable()
		{
		}

		public override void MStart()
		{
		}

		private void InvokeStartEvent()
		{
		}

		public override void MOnDisable()
		{
		}

		public override void MOnDestroy()
		{
		}
	}
}
