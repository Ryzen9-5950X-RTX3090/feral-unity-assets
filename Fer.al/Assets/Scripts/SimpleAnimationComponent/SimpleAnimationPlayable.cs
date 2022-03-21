using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

public class SimpleAnimationPlayable : PlayableBehaviour
{
	private class StateEnumerable : IEnumerable<IState>, IEnumerable
	{
		private class StateEnumerator : IEnumerator<IState>, IEnumerator, IDisposable
		{
			private int m_Index;

			private int m_Version;

			private SimpleAnimationPlayable m_Owner;

			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			IState IEnumerator<IState>.Current
			{
				get
				{
					return null;
				}
			}

			public StateEnumerator(SimpleAnimationPlayable owner)
			{
			}

			private bool IsValid()
			{
				return default(bool);
			}

			private IState GetCurrentHandle(int index)
			{
				return null;
			}

			public void Dispose()
			{
			}

			public bool MoveNext()
			{
				return default(bool);
			}

			public void Reset()
			{
			}
		}

		private SimpleAnimationPlayable m_Owner;

		public StateEnumerable(SimpleAnimationPlayable owner)
		{
		}

		public IEnumerator<IState> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	public interface IState
	{
		bool enabled { get; set; }

		float time { get; set; }

		float normalizedTime { get; set; }

		float speed { get; set; }

		string name { get; set; }

		float weight { get; set; }

		float length { get; }

		AnimationClip clip { get; }

		WrapMode wrapMode { get; }

		bool IsValid();
	}

	public class StateHandle : IState
	{
		private SimpleAnimationPlayable m_Parent;

		private int m_Index;

		private Playable m_Target;

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

		public float time
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float normalizedTime
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float speed
		{
			get
			{
				return default(float);
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

		public float weight
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float length
		{
			get
			{
				return default(float);
			}
		}

		public AnimationClip clip
		{
			get
			{
				return null;
			}
		}

		public WrapMode wrapMode
		{
			get
			{
				return default(WrapMode);
			}
		}

		public int index
		{
			get
			{
				return default(int);
			}
		}

		public StateHandle(SimpleAnimationPlayable s, int index, Playable target)
		{
		}

		public bool IsValid()
		{
			return default(bool);
		}
	}

	private class StateInfo
	{
		private bool m_Enabled;

		private int m_Index;

		private string m_StateName;

		private bool m_Fading;

		private float m_Time;

		private float m_TargetWeight;

		private float m_Weight;

		private float m_FadeSpeed;

		private AnimationClip m_Clip;

		private Playable m_Playable;

		private WrapMode m_WrapMode;

		private bool m_IsClone;

		private bool m_ReadyForCleanup;

		public StateHandle m_ParentState;

		private bool m_WeightDirty;

		private bool m_EnabledDirty;

		private bool m_TimeIsUpToDate;

		public bool enabled
		{
			get
			{
				return default(bool);
			}
		}

		public int index
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public string stateName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool fading
		{
			get
			{
				return default(bool);
			}
		}

		public float targetWeight
		{
			get
			{
				return default(float);
			}
		}

		public float weight
		{
			get
			{
				return default(float);
			}
		}

		public float fadeSpeed
		{
			get
			{
				return default(float);
			}
		}

		public float speed
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float playableDuration
		{
			get
			{
				return default(float);
			}
		}

		public AnimationClip clip
		{
			get
			{
				return null;
			}
		}

		public bool isDone
		{
			get
			{
				return default(bool);
			}
		}

		public Playable playable
		{
			get
			{
				return default(Playable);
			}
		}

		public WrapMode wrapMode
		{
			get
			{
				return default(WrapMode);
			}
		}

		public bool isClone
		{
			get
			{
				return default(bool);
			}
		}

		public bool isReadyForCleanup
		{
			get
			{
				return default(bool);
			}
		}

		public StateHandle parentState
		{
			get
			{
				return null;
			}
		}

		public bool enabledDirty
		{
			get
			{
				return default(bool);
			}
		}

		public bool weightDirty
		{
			get
			{
				return default(bool);
			}
		}

		public void Initialize(string name, AnimationClip clip, WrapMode wrapMode)
		{
		}

		public float GetTime()
		{
			return default(float);
		}

		public void SetTime(float newTime)
		{
		}

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		public void Pause()
		{
		}

		public void Play()
		{
		}

		public void Stop()
		{
		}

		public void ForceWeight(float weight)
		{
		}

		public void SetWeight(float weight)
		{
		}

		public void FadeTo(float weight, float speed)
		{
		}

		public void DestroyPlayable()
		{
		}

		public void SetAsCloneOf(StateHandle handle)
		{
		}

		public void SetPlayable(Playable playable)
		{
		}

		public void ResetDirtyFlags()
		{
		}

		public void InvalidateTime()
		{
		}
	}

	private class StateManagement
	{
		private List<StateInfo> m_States;

		private int m_Count;

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public StateInfo this[int i]
		{
			get
			{
				return null;
			}
		}

		public StateInfo InsertState()
		{
			return null;
		}

		public bool AnyStatePlaying()
		{
			return default(bool);
		}

		public void RemoveState(int index)
		{
		}

		public bool RemoveClip(AnimationClip clip)
		{
			return default(bool);
		}

		public StateInfo FindState(string name)
		{
			return null;
		}

		public void EnableState(int index)
		{
		}

		public void DisableState(int index)
		{
		}

		public void SetInputWeight(int index, float weight)
		{
		}

		public void SetStateTime(int index, float time)
		{
		}

		public float GetStateTime(int index)
		{
			return default(float);
		}

		public bool IsCloneOf(int potentialCloneIndex, int originalIndex)
		{
			return default(bool);
		}

		public float GetStateSpeed(int index)
		{
			return default(float);
		}

		public void SetStateSpeed(int index, float value)
		{
		}

		public float GetInputWeight(int index)
		{
			return default(float);
		}

		public float GetStateLength(int index)
		{
			return default(float);
		}

		public float GetClipLength(int index)
		{
			return default(float);
		}

		public float GetStatePlayableDuration(int index)
		{
			return default(float);
		}

		public AnimationClip GetStateClip(int index)
		{
			return null;
		}

		public WrapMode GetStateWrapMode(int index)
		{
			return default(WrapMode);
		}

		public string GetStateName(int index)
		{
			return null;
		}

		public void SetStateName(int index, string name)
		{
		}

		public void StopState(int index, bool cleanup)
		{
		}
	}

	private struct QueuedState
	{
		public StateHandle state;

		public float fadeTime;

		public QueuedState(StateHandle s, float t)
		{
		}
	}

	private LinkedList<QueuedState> m_StateQueue;

	private StateManagement m_States;

	private bool m_Initialized;

	private bool m_KeepStoppedPlayablesConnected;

	protected Playable m_ActualPlayable;

	private AnimationMixerPlayable m_Mixer;

	public Action onDone;

	private int m_StatesVersion;

	public bool keepStoppedPlayablesConnected
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	protected Playable self
	{
		get
		{
			return default(Playable);
		}
	}

	public Playable playable
	{
		get
		{
			return default(Playable);
		}
	}

	protected PlayableGraph graph
	{
		get
		{
			return default(PlayableGraph);
		}
	}

	private void UpdateStoppedPlayablesConnections()
	{
	}

	public Playable GetInput(int index)
	{
		return default(Playable);
	}

	public override void OnPlayableCreate(Playable playable)
	{
	}

	public IEnumerable<IState> GetStates()
	{
		return null;
	}

	public IState GetState(string name)
	{
		return null;
	}

	private StateInfo DoAddClip(string name, AnimationClip clip)
	{
		return null;
	}

	public bool AddClip(AnimationClip clip, string name)
	{
		return default(bool);
	}

	public bool RemoveClip(string name)
	{
		return default(bool);
	}

	public bool RemoveClip(AnimationClip clip)
	{
		return default(bool);
	}

	public bool Play(string name)
	{
		return default(bool);
	}

	private bool Play(int index)
	{
		return default(bool);
	}

	public bool PlayQueued(string name, QueueMode queueMode)
	{
		return default(bool);
	}

	private bool PlayQueued(int index, QueueMode queueMode)
	{
		return default(bool);
	}

	public void Rewind(string name)
	{
	}

	private void Rewind(int index)
	{
	}

	public void Rewind()
	{
	}

	private void RemoveClones(StateInfo state)
	{
	}

	public bool Stop(string name)
	{
		return default(bool);
	}

	private void DoStop(int index)
	{
	}

	public bool StopAll()
	{
		return default(bool);
	}

	public bool IsPlaying()
	{
		return default(bool);
	}

	public bool IsPlaying(string stateName)
	{
		return default(bool);
	}

	private bool IsClonePlaying(StateInfo state)
	{
		return default(bool);
	}

	public int GetClipCount()
	{
		return default(int);
	}

	private void SetupLerp(StateInfo state, float targetWeight, float time)
	{
	}

	private bool Crossfade(int index, float time)
	{
		return default(bool);
	}

	private StateInfo CloneState(int index)
	{
		return null;
	}

	public bool Crossfade(string name, float time)
	{
		return default(bool);
	}

	public bool CrossfadeQueued(string name, float time, QueueMode queueMode)
	{
		return default(bool);
	}

	private bool CrossfadeQueued(int index, float time, QueueMode queueMode)
	{
		return default(bool);
	}

	private bool Blend(int index, float targetWeight, float time)
	{
		return default(bool);
	}

	public bool Blend(string name, float targetWeight, float time)
	{
		return default(bool);
	}

	public override void OnGraphStop(Playable playable)
	{
	}

	private void UpdateDoneStatus()
	{
	}

	private void CleanClonedStates()
	{
	}

	private void DisconnectInput(int index)
	{
	}

	private void ConnectInput(int index)
	{
	}

	private void UpdateStates(float deltaTime)
	{
	}

	private float CalculateQueueTimes()
	{
		return default(float);
	}

	private void ClearQueuedStates()
	{
	}

	private void UpdateQueuedStates()
	{
	}

	private void InvalidateStateTimes()
	{
	}

	public override void PrepareFrame(Playable owner, FrameData data)
	{
	}

	public bool ValidateInput(int index, Playable input)
	{
		return default(bool);
	}

	public bool ValidateIndex(int index)
	{
		return default(bool);
	}

	private void InvalidateStates()
	{
	}

	private StateHandle StateInfoToHandle(StateInfo info)
	{
		return null;
	}
}
