using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Framework
{
	[Serializable]
	public abstract class Graph : ScriptableObject, ITaskSystem, ISerializationCallbackReceiver
	{
		public enum UpdateMode
		{
			NormalUpdate,
			LateUpdate,
			FixedUpdate,
			Manual
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <LoadOverwriteAsync>d__155 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncVoidMethodBuilder <>t__builder;

			public Graph <>4__this;

			public GraphLoadData data;

			public Action callback;

			private TaskAwaiter <>u__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[SerializeField]
		private string _serializedGraph;

		[SerializeField]
		private List<UnityEngine.Object> _objectReferences;

		[SerializeField]
		private GraphSource _graphSource;

		[SerializeField]
		private bool _haltSerialization;

		[NonSerialized]
		private bool haltForUndo;

		private static List<Graph> _runningGraphs;

		private bool hasInitialized
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private HierarchyTree.Element flatMetaGraph
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

		private HierarchyTree.Element fullMetaGraph
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

		private HierarchyTree.Element nestedMetaGraph
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

		public abstract Type baseNodeType { get; }

		public abstract bool requiresAgent { get; }

		public abstract bool requiresPrimeNode { get; }

		public abstract bool isTree { get; }

		public abstract bool allowBlackboardOverrides { get; }

		public abstract bool canAcceptVariableDrops { get; }

		private GraphSource graphSource
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string category
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string comments
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector2 translation
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float zoomFactor
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public List<Node> allNodes
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<CanvasGroup> canvasGroups
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private BlackboardSource localBlackboard
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private List<Task> allTasks
		{
			get
			{
				return null;
			}
		}

		private List<BBParameter> allParameters
		{
			get
			{
				return null;
			}
		}

		private List<Connection> allConnections
		{
			get
			{
				return null;
			}
		}

		public Graph rootGraph
		{
			get
			{
				return null;
			}
		}

		public bool serializationHalted
		{
			get
			{
				return default(bool);
			}
		}

		public static IEnumerable<Graph> runningGraphs
		{
			get
			{
				return null;
			}
		}

		public Graph parentGraph
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float elapsedTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float deltaTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int lastUpdateFrame
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool didUpdateLastFrame
		{
			get
			{
				return default(bool);
			}
		}

		public bool isRunning
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

		public bool isPaused
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

		public UpdateMode updateMode
		{
			[CompilerGenerated]
			get
			{
				return default(UpdateMode);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Node primeNode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Component agent
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public IBlackboard blackboard
		{
			get
			{
				return null;
			}
		}

		public IBlackboard parentBlackboard
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		UnityEngine.Object ITaskSystem.contextObject
		{
			get
			{
				return null;
			}
		}

		public static event Action<Graph> onGraphSerialized
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

		public static event Action<Graph> onGraphDeserialized
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

		public event Action<bool> onFinish
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

		private event Action delayedInitCalls
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

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		protected void OnDestroy()
		{
		}

		protected void OnValidate()
		{
		}

		protected void Reset()
		{
		}

		public bool SelfSerialize()
		{
			return default(bool);
		}

		public bool SelfDeserialize()
		{
			return default(bool);
		}

		public string Serialize(List<UnityEngine.Object> references)
		{
			return null;
		}

		public bool Deserialize(string serializedGraph, List<UnityEngine.Object> references, bool validate)
		{
			return default(bool);
		}

		public GraphSource GetGraphSource()
		{
			return null;
		}

		public string GetSerializedJsonData()
		{
			return null;
		}

		internal List<UnityEngine.Object> GetSerializedReferencesData()
		{
			return null;
		}

		internal GraphSource GetGraphSourceMetaDataCopy()
		{
			return null;
		}

		internal void SetGraphSourceMetaData(GraphSource source)
		{
		}

		public string SerializeLocalBlackboard(ref List<UnityEngine.Object> references)
		{
			return null;
		}

		public bool DeserializeLocalBlackboard(string json, List<UnityEngine.Object> references)
		{
			return default(bool);
		}

		public static T Clone<T>(T graph, Graph parentGraph) where T : Graph
		{
			return null;
		}

		public void Validate()
		{
		}

		public void UpdateReferencesFromOwner(GraphOwner owner, bool force = false)
		{
		}

		public void UpdateReferences(Component newAgent, IBlackboard newParentBlackboard, bool force = false)
		{
		}

		private void UpdateNodeBBFields()
		{
		}

		void ITaskSystem.UpdateTasksOwner()
		{
		}

		public void UpdateNodeIDs(bool alsoReorderList)
		{
		}

		private int AssignNodeID(Node node, int lastID, ref Node[] parsed)
		{
			return default(int);
		}

		protected void ThreadSafeInitCall(Action call)
		{
		}

		[AsyncStateMachine(typeof(<LoadOverwriteAsync>d__155))]
		public void LoadOverwriteAsync(GraphLoadData data, Action callback)
		{
		}

		public void LoadOverwrite(GraphLoadData data)
		{
		}

		public void Initialize(Component newAgent, IBlackboard newParentBlackboard, bool preInitializeSubGraphs)
		{
		}

		private void PreInitializeSubGraphs()
		{
		}

		public void StartGraph(Component newAgent, IBlackboard newParentBlackboard, UpdateMode newUpdateMode, [Optional] Action<bool> callback)
		{
		}

		public void Stop(bool success = true)
		{
		}

		public void Pause()
		{
		}

		public void Resume()
		{
		}

		public void Restart()
		{
		}

		public void UpdateGraph()
		{
		}

		public void UpdateGraph(float deltaTime)
		{
		}

		public virtual object OnDerivedDataSerialization()
		{
			return null;
		}

		public virtual void OnDerivedDataDeserialization(object data)
		{
		}

		protected virtual void OnGraphInitialize()
		{
		}

		protected virtual void OnGraphStarted()
		{
		}

		protected virtual void OnGraphUpdate()
		{
		}

		protected virtual void OnGraphStoped()
		{
		}

		protected virtual void OnGraphPaused()
		{
		}

		protected virtual void OnGraphUnpaused()
		{
		}

		protected virtual void OnGraphObjectEnable()
		{
		}

		protected virtual void OnGraphObjectDisable()
		{
		}

		protected virtual void OnGraphObjectDestroy()
		{
		}

		protected virtual void OnGraphValidate()
		{
		}

		public void SendEvent(string name, object value, object sender)
		{
		}

		public void SendEvent<T>(string name, T value, object sender)
		{
		}

		public static void SendGlobalEvent(string name, object value, object sender)
		{
		}

		public static void SendGlobalEvent<T>(string name, T value, object sender)
		{
		}

		public IEnumerable<BBParameter> GetAllParameters()
		{
			return null;
		}

		public IEnumerable<Connection> GetAllConnections()
		{
			return null;
		}

		public IEnumerable<T> GetAllTasksOfType<T>() where T : Task
		{
			return null;
		}

		public Node GetNodeWithID(int searchID)
		{
			return null;
		}

		public IEnumerable<T> GetAllNodesOfType<T>() where T : Node
		{
			return null;
		}

		public T GetNodeWithTag<T>(string tagName) where T : Node
		{
			return null;
		}

		public IEnumerable<T> GetNodesWithTag<T>(string tagName) where T : Node
		{
			return null;
		}

		public List<T> GetAllTagedNodes<T>() where T : Node
		{
			return null;
		}

		public IEnumerable<Node> GetRootNodes()
		{
			return null;
		}

		public IEnumerable<Node> GetLeafNodes()
		{
			return null;
		}

		public IEnumerable<T> GetAllNestedGraphs<T>(bool recursive) where T : Graph
		{
			return null;
		}

		public IEnumerable<Graph> GetAllInstancedNestedGraphs()
		{
			return null;
		}

		public IEnumerable<BBParameter> GetDefinedParameters()
		{
			return null;
		}

		public void PromoteMissingParametersToVariables(IBlackboard bb)
		{
		}

		public static Graph GetElementGraph(object obj)
		{
			return null;
		}

		public HierarchyTree.Element GetFlatMetaGraph()
		{
			return null;
		}

		public HierarchyTree.Element GetFullMetaGraph()
		{
			return null;
		}

		public HierarchyTree.Element GetNestedMetaGraph()
		{
			return null;
		}

		private static void DigNestedGraphs(Graph currentGraph, HierarchyTree.Element currentElement)
		{
		}

		private static HierarchyTree.Element GetTreeNodeElement(Node node, bool recurse, ref int lastID)
		{
			return null;
		}

		private static HierarchyTree.Element CollectSubElements(IGraphElement obj)
		{
			return null;
		}

		public IGraphElement GetTaskParentElement(Task targetTask)
		{
			return null;
		}

		public IGraphElement GetParameterParentElement(BBParameter targetParameter)
		{
			return null;
		}

		public static IEnumerable<Task> GetTasksInElement(IGraphElement target)
		{
			return null;
		}

		public static IEnumerable<BBParameter> GetParametersInElement(IGraphElement target)
		{
			return null;
		}

		public T AddNode<T>() where T : Node
		{
			return null;
		}

		public T AddNode<T>(Vector2 pos) where T : Node
		{
			return null;
		}

		public Node AddNode(Type nodeType)
		{
			return null;
		}

		public Node AddNode(Type nodeType, Vector2 pos)
		{
			return null;
		}

		public void RemoveNode(Node node, bool recordUndo = true, bool force = false)
		{
		}

		public Connection ConnectNodes(Node sourceNode, Node targetNode, int sourceIndex = -1, int targetIndex = -1)
		{
			return null;
		}

		public void RemoveConnection(Connection connection, bool recordUndo = true)
		{
		}

		public static List<Node> CloneNodes(List<Node> originalNodes, [Optional] Graph targetGraph, [Optional] Vector2 originPosition)
		{
			return null;
		}

		public void ClearGraph()
		{
		}

		[Obsolete]
		public void StartGraph(Component newAgent, IBlackboard newBlackboard, bool autoUpdate, [Optional] Action<bool> callback)
		{
		}
	}
}
