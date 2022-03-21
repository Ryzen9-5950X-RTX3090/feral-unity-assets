using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace UniRx.Async
{
	public static class UnityAsyncExtensions
	{
		private class JobHandleAwaiter : IAwaiter, ICriticalNotifyCompletion, INotifyCompletion, IPlayerLoopItem
		{
			private JobHandle jobHandle;

			private CancellationToken cancellationToken;

			private AwaiterStatus status;

			private Action continuation;

			public bool IsCompleted
			{
				get
				{
					return default(bool);
				}
			}

			public AwaiterStatus Status
			{
				get
				{
					return default(AwaiterStatus);
				}
			}

			public JobHandleAwaiter(JobHandle jobHandle, CancellationToken cancellationToken, int skipFrame = 2)
			{
			}

			public void GetResult()
			{
			}

			public bool MoveNext()
			{
				return default(bool);
			}

			private void InvokeContinuation(AwaiterStatus status)
			{
			}

			public void OnCompleted(Action continuation)
			{
			}

			public void UnsafeOnCompleted(Action continuation)
			{
			}
		}

		public struct AsyncOperationAwaiter : IAwaiter, ICriticalNotifyCompletion, INotifyCompletion
		{
			private AsyncOperation asyncOperation;

			private Action<AsyncOperation> continuationAction;

			private AwaiterStatus status;

			public bool IsCompleted
			{
				get
				{
					return default(bool);
				}
			}

			public AwaiterStatus Status
			{
				get
				{
					return default(AwaiterStatus);
				}
			}

			public AsyncOperationAwaiter(AsyncOperation asyncOperation)
			{
			}

			public void GetResult()
			{
			}

			public void OnCompleted(Action continuation)
			{
			}

			public void UnsafeOnCompleted(Action continuation)
			{
			}
		}

		private class AsyncOperationConfiguredAwaiter : IAwaiter, ICriticalNotifyCompletion, INotifyCompletion, IPlayerLoopItem
		{
			private AsyncOperation asyncOperation;

			private IProgress<float> progress;

			private CancellationToken cancellationToken;

			private AwaiterStatus status;

			private Action continuation;

			public bool IsCompleted
			{
				get
				{
					return default(bool);
				}
			}

			public AwaiterStatus Status
			{
				get
				{
					return default(AwaiterStatus);
				}
			}

			public AsyncOperationConfiguredAwaiter(AsyncOperation asyncOperation, IProgress<float> progress, CancellationToken cancellationToken)
			{
			}

			public void GetResult()
			{
			}

			public bool MoveNext()
			{
				return default(bool);
			}

			private void InvokeContinuation(AwaiterStatus status)
			{
			}

			public void OnCompleted(Action continuation)
			{
			}

			public void UnsafeOnCompleted(Action continuation)
			{
			}
		}

		public struct ResourceRequestAwaiter : IAwaiter<UnityEngine.Object>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion
		{
			private ResourceRequest asyncOperation;

			private Action<AsyncOperation> continuationAction;

			private AwaiterStatus status;

			private UnityEngine.Object result;

			public bool IsCompleted
			{
				get
				{
					return default(bool);
				}
			}

			public AwaiterStatus Status
			{
				get
				{
					return default(AwaiterStatus);
				}
			}

			public ResourceRequestAwaiter(ResourceRequest asyncOperation)
			{
			}

			public UnityEngine.Object GetResult()
			{
				return null;
			}

			void IAwaiter.GetResult()
			{
			}

			public void OnCompleted(Action continuation)
			{
			}

			public void UnsafeOnCompleted(Action continuation)
			{
			}
		}

		private class ResourceRequestConfiguredAwaiter : IAwaiter<UnityEngine.Object>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion, IPlayerLoopItem
		{
			private ResourceRequest asyncOperation;

			private IProgress<float> progress;

			private CancellationToken cancellationToken;

			private AwaiterStatus status;

			private Action continuation;

			private UnityEngine.Object result;

			public bool IsCompleted
			{
				get
				{
					return default(bool);
				}
			}

			public AwaiterStatus Status
			{
				get
				{
					return default(AwaiterStatus);
				}
			}

			public ResourceRequestConfiguredAwaiter(ResourceRequest asyncOperation, IProgress<float> progress, CancellationToken cancellationToken)
			{
			}

			void IAwaiter.GetResult()
			{
			}

			public UnityEngine.Object GetResult()
			{
				return null;
			}

			public bool MoveNext()
			{
				return default(bool);
			}

			private void InvokeContinuation(AwaiterStatus status)
			{
			}

			public void OnCompleted(Action continuation)
			{
			}

			public void UnsafeOnCompleted(Action continuation)
			{
			}
		}

		public struct AssetBundleRequestAwaiter : IAwaiter<UnityEngine.Object>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion
		{
			private AssetBundleRequest asyncOperation;

			private Action<AsyncOperation> continuationAction;

			private AwaiterStatus status;

			private UnityEngine.Object result;

			public bool IsCompleted
			{
				get
				{
					return default(bool);
				}
			}

			public AwaiterStatus Status
			{
				get
				{
					return default(AwaiterStatus);
				}
			}

			public AssetBundleRequestAwaiter(AssetBundleRequest asyncOperation)
			{
			}

			public UnityEngine.Object GetResult()
			{
				return null;
			}

			void IAwaiter.GetResult()
			{
			}

			public void OnCompleted(Action continuation)
			{
			}

			public void UnsafeOnCompleted(Action continuation)
			{
			}
		}

		private class AssetBundleRequestConfiguredAwaiter : IAwaiter<UnityEngine.Object>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion, IPlayerLoopItem
		{
			private AssetBundleRequest asyncOperation;

			private IProgress<float> progress;

			private CancellationToken cancellationToken;

			private AwaiterStatus status;

			private Action continuation;

			private UnityEngine.Object result;

			public bool IsCompleted
			{
				get
				{
					return default(bool);
				}
			}

			public AwaiterStatus Status
			{
				get
				{
					return default(AwaiterStatus);
				}
			}

			public AssetBundleRequestConfiguredAwaiter(AssetBundleRequest asyncOperation, IProgress<float> progress, CancellationToken cancellationToken)
			{
			}

			void IAwaiter.GetResult()
			{
			}

			public UnityEngine.Object GetResult()
			{
				return null;
			}

			public bool MoveNext()
			{
				return default(bool);
			}

			private void InvokeContinuation(AwaiterStatus status)
			{
			}

			public void OnCompleted(Action continuation)
			{
			}

			public void UnsafeOnCompleted(Action continuation)
			{
			}
		}

		private class WWWConfiguredAwaiter : IAwaiter, ICriticalNotifyCompletion, INotifyCompletion, IPlayerLoopItem
		{
			private WWW asyncOperation;

			private IProgress<float> progress;

			private CancellationToken cancellationToken;

			private AwaiterStatus status;

			private Action continuation;

			public bool IsCompleted
			{
				get
				{
					return default(bool);
				}
			}

			public AwaiterStatus Status
			{
				get
				{
					return default(AwaiterStatus);
				}
			}

			public WWWConfiguredAwaiter(WWW asyncOperation, IProgress<float> progress, CancellationToken cancellationToken)
			{
			}

			public void GetResult()
			{
			}

			public bool MoveNext()
			{
				return default(bool);
			}

			private void InvokeContinuation(AwaiterStatus status)
			{
			}

			public void OnCompleted(Action continuation)
			{
			}

			public void UnsafeOnCompleted(Action continuation)
			{
			}
		}

		public struct UnityWebRequestAsyncOperationAwaiter : IAwaiter<UnityWebRequest>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion
		{
			private UnityWebRequestAsyncOperation asyncOperation;

			private Action<AsyncOperation> continuationAction;

			private AwaiterStatus status;

			private UnityWebRequest result;

			public bool IsCompleted
			{
				get
				{
					return default(bool);
				}
			}

			public AwaiterStatus Status
			{
				get
				{
					return default(AwaiterStatus);
				}
			}

			public UnityWebRequestAsyncOperationAwaiter(UnityWebRequestAsyncOperation asyncOperation)
			{
			}

			public UnityWebRequest GetResult()
			{
				return null;
			}

			void IAwaiter.GetResult()
			{
			}

			public void OnCompleted(Action continuation)
			{
			}

			public void UnsafeOnCompleted(Action continuation)
			{
			}
		}

		private class UnityWebRequestAsyncOperationConfiguredAwaiter : IAwaiter<UnityWebRequest>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion, IPlayerLoopItem
		{
			private UnityWebRequestAsyncOperation asyncOperation;

			private IProgress<float> progress;

			private CancellationToken cancellationToken;

			private AwaiterStatus status;

			private Action continuation;

			private UnityWebRequest result;

			public bool IsCompleted
			{
				get
				{
					return default(bool);
				}
			}

			public AwaiterStatus Status
			{
				get
				{
					return default(AwaiterStatus);
				}
			}

			public UnityWebRequestAsyncOperationConfiguredAwaiter(UnityWebRequestAsyncOperation asyncOperation, IProgress<float> progress, CancellationToken cancellationToken)
			{
			}

			void IAwaiter.GetResult()
			{
			}

			public UnityWebRequest GetResult()
			{
				return null;
			}

			public bool MoveNext()
			{
				return default(bool);
			}

			private void InvokeContinuation(AwaiterStatus status)
			{
			}

			public void OnCompleted(Action continuation)
			{
			}

			public void UnsafeOnCompleted(Action continuation)
			{
			}
		}

		public static IAwaiter GetAwaiter(this JobHandle jobHandle)
		{
			return null;
		}

		public static UniTask ToUniTask(this JobHandle jobHandle, [Optional] CancellationToken cancellation)
		{
			return default(UniTask);
		}

		public static UniTask ConfigureAwait(this JobHandle jobHandle, PlayerLoopTiming waitTiming, [Optional] CancellationToken cancellation)
		{
			return default(UniTask);
		}

		public static AsyncOperationAwaiter GetAwaiter(this AsyncOperation asyncOperation)
		{
			return default(AsyncOperationAwaiter);
		}

		public static UniTask ToUniTask(this AsyncOperation asyncOperation)
		{
			return default(UniTask);
		}

		public static UniTask ConfigureAwait(this AsyncOperation asyncOperation, [Optional] IProgress<float> progress, PlayerLoopTiming timing = PlayerLoopTiming.Update, [Optional] CancellationToken cancellation)
		{
			return default(UniTask);
		}

		public static ResourceRequestAwaiter GetAwaiter(this ResourceRequest resourceRequest)
		{
			return default(ResourceRequestAwaiter);
		}

		public static UniTask<UnityEngine.Object> ToUniTask(this ResourceRequest resourceRequest)
		{
			return default(UniTask<UnityEngine.Object>);
		}

		public static UniTask<UnityEngine.Object> ConfigureAwait(this ResourceRequest resourceRequest, [Optional] IProgress<float> progress, PlayerLoopTiming timing = PlayerLoopTiming.Update, [Optional] CancellationToken cancellation)
		{
			return default(UniTask<UnityEngine.Object>);
		}

		public static AssetBundleRequestAwaiter GetAwaiter(this AssetBundleRequest resourceRequest)
		{
			return default(AssetBundleRequestAwaiter);
		}

		public static UniTask<UnityEngine.Object> ToUniTask(this AssetBundleRequest resourceRequest)
		{
			return default(UniTask<UnityEngine.Object>);
		}

		public static UniTask<UnityEngine.Object> ConfigureAwait(this AssetBundleRequest resourceRequest, [Optional] IProgress<float> progress, PlayerLoopTiming timing = PlayerLoopTiming.Update, [Optional] CancellationToken cancellation)
		{
			return default(UniTask<UnityEngine.Object>);
		}

		public static IAwaiter GetAwaiter(this WWW www)
		{
			return null;
		}

		public static UniTask ToUniTask(this WWW www)
		{
			return default(UniTask);
		}

		public static UniTask ConfigureAwait(this WWW www, [Optional] IProgress<float> progress, PlayerLoopTiming timing = PlayerLoopTiming.Update, [Optional] CancellationToken cancellation)
		{
			return default(UniTask);
		}

		public static UnityWebRequestAsyncOperationAwaiter GetAwaiter(this UnityWebRequestAsyncOperation asyncOperation)
		{
			return default(UnityWebRequestAsyncOperationAwaiter);
		}

		public static UniTask<UnityWebRequest> ToUniTask(this UnityWebRequestAsyncOperation asyncOperation)
		{
			return default(UniTask<UnityWebRequest>);
		}

		public static UniTask<UnityWebRequest> ConfigureAwait(this UnityWebRequestAsyncOperation asyncOperation, [Optional] IProgress<float> progress, PlayerLoopTiming timing = PlayerLoopTiming.Update, [Optional] CancellationToken cancellation)
		{
			return default(UniTask<UnityWebRequest>);
		}

		public static AsyncUnityEventHandler GetAsyncEventHandler(this UnityEvent unityEvent, CancellationToken cancellationToken)
		{
			return null;
		}

		public static UniTask OnInvokeAsync(this UnityEvent unityEvent, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public static IAsyncClickEventHandler GetAsyncClickEventHandler(this Button button)
		{
			return null;
		}

		public static IAsyncClickEventHandler GetAsyncClickEventHandler(this Button button, CancellationToken cancellationToken)
		{
			return null;
		}

		public static UniTask OnClickAsync(this Button button)
		{
			return default(UniTask);
		}

		public static UniTask OnClickAsync(this Button button, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public static IAsyncValueChangedEventHandler<bool> GetAsyncValueChangedEventHandler(this Toggle toggle)
		{
			return null;
		}

		public static IAsyncValueChangedEventHandler<bool> GetAsyncValueChangedEventHandler(this Toggle toggle, CancellationToken cancellationToken)
		{
			return null;
		}

		public static UniTask<bool> OnValueChangedAsync(this Toggle toggle)
		{
			return default(UniTask<bool>);
		}

		public static UniTask<bool> OnValueChangedAsync(this Toggle toggle, CancellationToken cancellationToken)
		{
			return default(UniTask<bool>);
		}

		public static IAsyncValueChangedEventHandler<float> GetAsyncValueChangedEventHandler(this Scrollbar scrollbar)
		{
			return null;
		}

		public static IAsyncValueChangedEventHandler<float> GetAsyncValueChangedEventHandler(this Scrollbar scrollbar, CancellationToken cancellationToken)
		{
			return null;
		}

		public static UniTask<float> OnValueChangedAsync(this Scrollbar scrollbar)
		{
			return default(UniTask<float>);
		}

		public static UniTask<float> OnValueChangedAsync(this Scrollbar scrollbar, CancellationToken cancellationToken)
		{
			return default(UniTask<float>);
		}

		public static IAsyncValueChangedEventHandler<Vector2> GetAsyncValueChangedEventHandler(this ScrollRect scrollRect)
		{
			return null;
		}

		public static IAsyncValueChangedEventHandler<Vector2> GetAsyncValueChangedEventHandler(this ScrollRect scrollRect, CancellationToken cancellationToken)
		{
			return null;
		}

		public static UniTask<Vector2> OnValueChangedAsync(this ScrollRect scrollRect)
		{
			return default(UniTask<Vector2>);
		}

		public static UniTask<Vector2> OnValueChangedAsync(this ScrollRect scrollRect, CancellationToken cancellationToken)
		{
			return default(UniTask<Vector2>);
		}

		public static IAsyncValueChangedEventHandler<float> GetAsyncValueChangedEventHandler(this Slider slider)
		{
			return null;
		}

		public static IAsyncValueChangedEventHandler<float> GetAsyncValueChangedEventHandler(this Slider slider, CancellationToken cancellationToken)
		{
			return null;
		}

		public static UniTask<float> OnValueChangedAsync(this Slider slider)
		{
			return default(UniTask<float>);
		}

		public static UniTask<float> OnValueChangedAsync(this Slider slider, CancellationToken cancellationToken)
		{
			return default(UniTask<float>);
		}

		public static IAsyncEndEditEventHandler<string> GetAsyncEndEditEventHandler(this InputField inputField)
		{
			return null;
		}

		public static IAsyncEndEditEventHandler<string> GetAsyncEndEditEventHandler(this InputField inputField, CancellationToken cancellationToken)
		{
			return null;
		}

		public static UniTask<string> OnEndEditAsync(this InputField inputField)
		{
			return default(UniTask<string>);
		}

		public static UniTask<string> OnEndEditAsync(this InputField inputField, CancellationToken cancellationToken)
		{
			return default(UniTask<string>);
		}

		public static IAsyncValueChangedEventHandler<int> GetAsyncValueChangedEventHandler(this Dropdown dropdown)
		{
			return null;
		}

		public static IAsyncValueChangedEventHandler<int> GetAsyncValueChangedEventHandler(this Dropdown dropdown, CancellationToken cancellationToken)
		{
			return null;
		}

		public static UniTask<int> OnValueChanged(this Dropdown dropdown)
		{
			return default(UniTask<int>);
		}

		public static UniTask<int> OnValueChanged(this Dropdown dropdown, CancellationToken cancellationToken)
		{
			return default(UniTask<int>);
		}
	}
}
