using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Options;

namespace DG.Tweening.Core
{
	internal static class TweenManager
	{
		internal enum CapacityIncreaseMode
		{
			TweenersAndSequences,
			TweenersOnly,
			SequencesOnly
		}

		private const int _DefaultMaxTweeners = 200;

		private const int _DefaultMaxSequences = 50;

		private const string _MaxTweensReached = "Max Tweens reached: capacity has automatically been increased from #0 to #1. Use DOTween.SetTweensCapacity to set it manually at startup";

		private const float _EpsilonVsTimeCheck = 1E-06f;

		internal static bool isUnityEditor;

		internal static bool isDebugBuild;

		internal static int maxActive;

		internal static int maxTweeners;

		internal static int maxSequences;

		internal static bool hasActiveTweens;

		internal static bool hasActiveDefaultTweens;

		internal static bool hasActiveLateTweens;

		internal static bool hasActiveFixedTweens;

		internal static bool hasActiveManualTweens;

		internal static int totActiveTweens;

		internal static int totActiveDefaultTweens;

		internal static int totActiveLateTweens;

		internal static int totActiveFixedTweens;

		internal static int totActiveManualTweens;

		internal static int totActiveTweeners;

		internal static int totActiveSequences;

		internal static int totPooledTweeners;

		internal static int totPooledSequences;

		internal static int totTweeners;

		internal static int totSequences;

		internal static bool isUpdateLoop;

		internal static Tween[] _activeTweens;

		private static Tween[] _pooledTweeners;

		private static readonly Stack<Tween> _PooledSequences;

		private static readonly List<Tween> _KillList;

		private static readonly Dictionary<Tween, TweenLink> _TweenLinks;

		private static int _totTweenLinks;

		private static int _maxActiveLookupId;

		private static bool _requiresActiveReorganization;

		private static int _reorganizeFromId;

		private static int _minPooledTweenerId;

		private static int _maxPooledTweenerId;

		private static bool _despawnAllCalledFromUpdateLoopCallback;

		static TweenManager()
		{
		}

		internal static TweenerCore<T1, T2, TPlugOptions> GetTweener<T1, T2, TPlugOptions>() where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}

		internal static Sequence GetSequence()
		{
			return null;
		}

		internal static void SetUpdateType(Tween t, UpdateType updateType, bool isIndependentUpdate)
		{
		}

		internal static void AddActiveTweenToSequence(Tween t)
		{
		}

		internal static int DespawnAll()
		{
			return default(int);
		}

		internal static void Despawn(Tween t, bool modifyActiveLists = true)
		{
		}

		internal static void PurgeAll()
		{
		}

		internal static void PurgePools()
		{
		}

		internal static void AddTweenLink(Tween t, TweenLink tweenLink)
		{
		}

		private static void RemoveTweenLink(Tween t)
		{
		}

		internal static void ResetCapacities()
		{
		}

		internal static void SetCapacities(int tweenersCapacity, int sequencesCapacity)
		{
		}

		internal static int Validate()
		{
			return default(int);
		}

		internal static void Update(UpdateType updateType, float deltaTime, float independentTime)
		{
		}

		internal static int FilteredOperation(OperationType operationType, FilterType filterType, object id, bool optionalBool, float optionalFloat, [Optional] object optionalObj, [Optional] object[] optionalArray)
		{
			return default(int);
		}

		internal static bool Complete(Tween t, bool modifyActiveLists = true, UpdateMode updateMode = UpdateMode.Goto)
		{
			return default(bool);
		}

		internal static bool Flip(Tween t)
		{
			return default(bool);
		}

		internal static void ForceInit(Tween t, bool isSequenced = false)
		{
		}

		internal static bool Goto(Tween t, float to, bool andPlay = false, UpdateMode updateMode = UpdateMode.Goto)
		{
			return default(bool);
		}

		internal static bool Pause(Tween t)
		{
			return default(bool);
		}

		internal static bool Play(Tween t)
		{
			return default(bool);
		}

		internal static bool PlayBackwards(Tween t)
		{
			return default(bool);
		}

		internal static bool PlayForward(Tween t)
		{
			return default(bool);
		}

		internal static bool Restart(Tween t, bool includeDelay = true, float changeDelayTo = -1f)
		{
			return default(bool);
		}

		internal static bool Rewind(Tween t, bool includeDelay = true)
		{
			return default(bool);
		}

		internal static bool SmoothRewind(Tween t)
		{
			return default(bool);
		}

		internal static bool TogglePause(Tween t)
		{
			return default(bool);
		}

		internal static int TotalPooledTweens()
		{
			return default(int);
		}

		internal static int TotalPlayingTweens()
		{
			return default(int);
		}

		internal static List<Tween> GetActiveTweens(bool playing, [Optional] List<Tween> fillableList)
		{
			return null;
		}

		internal static List<Tween> GetTweensById(object id, bool playingOnly, [Optional] List<Tween> fillableList)
		{
			return null;
		}

		internal static List<Tween> GetTweensByTarget(object target, bool playingOnly, [Optional] List<Tween> fillableList)
		{
			return null;
		}

		private static void MarkForKilling(Tween t)
		{
		}

		private static void EvaluateTweenLink(Tween t)
		{
		}

		private static void AddActiveTween(Tween t)
		{
		}

		private static void ReorganizeActiveTweens()
		{
		}

		private static void DespawnActiveTweens(List<Tween> tweens)
		{
		}

		private static void RemoveActiveTween(Tween t)
		{
		}

		private static void ClearTweenArray(Tween[] tweens)
		{
		}

		private static void IncreaseCapacities(CapacityIncreaseMode increaseMode)
		{
		}

		private static void ManageOnRewindCallbackWhenAlreadyRewinded(Tween t, bool isPlayBackwardsOrSmoothRewind)
		{
		}
	}
}
