using System;
using System.Collections;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization.FullSerializer;
using ParadoxNotion.Services;
using UnityEngine;

namespace NodeCanvas.Framework
{
	[Serializable]
	[fsDeserializeOverwrite]
	[SpoofAOT]
	public abstract class Task : ISerializationCollectable, ISerializationCallbackReceiver
	{
		[AttributeUsage(AttributeTargets.Field)]
		protected class GetFromAgentAttribute : Attribute
		{
		}

		[fsSerializeAs]
		private bool _isUserDisabled;

		[fsSerializeAs]
		protected internal TaskAgentParameter _agentParameter;

		private ITaskSystem _ownerSystem;

		private Component _currentAgent;

		private string _taskName;

		private string _taskDescription;

		private string _obsoleteInfo;

		private bool _isRuntimeActive;

		private bool _isInitSuccess;

		private EventRouter _eventRouter;

		public ITaskSystem ownerSystem
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Component ownerSystemAgent
		{
			get
			{
				return null;
			}
		}

		public IBlackboard ownerSystemBlackboard
		{
			get
			{
				return null;
			}
		}

		public float ownerSystemElapsedTime
		{
			get
			{
				return default(float);
			}
		}

		public bool isUserEnabled
		{
			get
			{
				return default(bool);
			}
			internal set
			{
			}
		}

		public string obsolete
		{
			get
			{
				return null;
			}
		}

		public string name
		{
			get
			{
				return null;
			}
		}

		public string description
		{
			get
			{
				return null;
			}
		}

		public string summaryInfo
		{
			get
			{
				return null;
			}
		}

		protected virtual string info
		{
			get
			{
				return null;
			}
		}

		public virtual Type agentType
		{
			get
			{
				return null;
			}
		}

		public string agentInfo
		{
			get
			{
				return null;
			}
		}

		public string agentParameterName
		{
			get
			{
				return null;
			}
		}

		public bool agentIsOverride
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Component agent
		{
			get
			{
				return null;
			}
		}

		public IBlackboard blackboard
		{
			get
			{
				return null;
			}
		}

		public EventRouter router
		{
			get
			{
				return null;
			}
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		public Task()
		{
		}

		public static T Create<T>(ITaskSystem newOwnerSystem) where T : Task
		{
			return null;
		}

		public static Task Create(Type type, ITaskSystem newOwnerSystem)
		{
			return null;
		}

		public virtual Task Duplicate(ITaskSystem newOwnerSystem)
		{
			return null;
		}

		public void Validate(ITaskSystem ownerSystem)
		{
		}

		public void SetOwnerSystem(ITaskSystem newOwnerSystem)
		{
		}

		protected bool Set(Component newAgent, IBlackboard newBB)
		{
			return default(bool);
		}

		private bool Initialize(Component newAgent)
		{
			return default(bool);
		}

		private bool InitializeFieldAttributes(Component newAgent)
		{
			return default(bool);
		}

		protected bool Error(string error, string tag = "Execution")
		{
			return default(bool);
		}

		protected Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		protected void StopCoroutine(Coroutine routine)
		{
		}

		protected void SendEvent(string name)
		{
		}

		protected void SendEvent<T>(string name, T value)
		{
		}

		internal virtual string GetWarningOrError()
		{
			return null;
		}

		private string GetHardError()
		{
			return null;
		}

		protected virtual string OnInit()
		{
			return null;
		}

		public virtual void OnCreate(ITaskSystem ownerSystem)
		{
		}

		public virtual void OnValidate(ITaskSystem ownerSystem)
		{
		}

		[Obsolete]
		public virtual void OnDrawGizmos()
		{
		}

		public virtual void OnDrawGizmosSelected()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
