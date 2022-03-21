using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

public static class WebUtils
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <GetAsync>d__4<T> : IAsyncStateMachine where T : new()
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<T>> <>t__builder;

		public string inURL;

		private TaskAwaiter<WWWResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <GetAsync>d__5<T> : IAsyncStateMachine where T : new()
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<T>> <>t__builder;

		public string inURL;

		public bool inSendAuthorization;

		private TaskAwaiter<WWWResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <GetAsync>d__11 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse> <>t__builder;

		public bool inSendAuthorization;

		public string inURL;

		private TaskAwaiter<WWWResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <GetAsync>d__12 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse> <>t__builder;

		public string inURL;

		public Dictionary<string, string> inHeaders;

		private TaskAwaiter<WWWResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <PutAsync>d__13 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse> <>t__builder;

		public string inURL;

		public string inBodyData;

		private TaskAwaiter<WWWResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <PostAsync>d__14 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse> <>t__builder;

		public string inURL;

		public WWWForm inFormData;

		private TaskAwaiter<WWWResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <PostJsonAsync>d__15<T> : IAsyncStateMachine where T : new()
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<T>> <>t__builder;

		public object objectToSerialize;

		public bool sendAuthorization;

		public string customAuthBearer;

		public string inURL;

		private TaskAwaiter<WWWResponse<T>> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <PostJsonAsync>d__16 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse> <>t__builder;

		public object objectToSerialize;

		public bool sendAuthorization;

		public string customAuthBearer;

		public string inURL;

		private TaskAwaiter<WWWResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <PostAsync>d__17<T> : IAsyncStateMachine where T : new()
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<T>> <>t__builder;

		public bool inSendAuthorization;

		public string customAuthBearer;

		public string inURL;

		public byte[] inBodyData;

		private TaskAwaiter<WWWResponse<T>> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <PostAsync>d__18<T> : IAsyncStateMachine where T : new()
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<T>> <>t__builder;

		public string inURL;

		public byte[] inBodyData;

		public Dictionary<string, string> inHeaders;

		private TaskAwaiter<WWWResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <PostAsync>d__19 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse> <>t__builder;

		public string inURL;

		public byte[] inBodyData;

		public Dictionary<string, string> inHeaders;

		private TaskAwaiter<WWWResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <DeleteAsync>d__20<T> : IAsyncStateMachine where T : new()
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<T>> <>t__builder;

		public bool inSendAuthorization;

		public string inURL;

		public byte[] inBodyData;

		private TaskAwaiter<WWWResponse<T>> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <DeleteAsync>d__21<T> : IAsyncStateMachine where T : new()
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<T>> <>t__builder;

		public string inURL;

		public byte[] inBodyData;

		public Dictionary<string, string> inHeaders;

		private TaskAwaiter<WWWResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <DeleteAsync>d__22 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse> <>t__builder;

		public string inURL;

		public byte[] inBodyData;

		public Dictionary<string, string> inHeaders;

		private TaskAwaiter<WWWResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <_RequestAsync>d__23 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse> <>t__builder;

		public UnityWebRequest inRequest;

		private <>c__DisplayClass23_0 <>8__1;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public static Coroutine Post(string inURL, WWWForm inFormData, [Optional] Action<WWWResponse> inCallback)
	{
		return null;
	}

	public static Coroutine Post(string inURL, byte[] inBodyData, [Optional] Dictionary<string, string> inHeaders, [Optional] Action<WWWResponse> inCallback)
	{
		return null;
	}

	public static Coroutine Put(string inURL, string inBodyData, [Optional] Action<WWWResponse> inCallback)
	{
		return null;
	}

	public static Coroutine Get(string inURL, [Optional] Action<WWWResponse> inCallback)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<GetAsync>d__4<>))]
	public static Task<WWWResponse<T>> GetAsync<T>(string inURL, [Optional] Action<WWWResponse<T>> inCallback) where T : new()
	{
		return null;
	}

	[AsyncStateMachine(typeof(<GetAsync>d__5<>))]
	public static Task<WWWResponse<T>> GetAsync<T>(string inURL, bool inSendAuthorization) where T : new()
	{
		return null;
	}

	public static Coroutine Get<T>(string inURL, bool inSendAuthorization, [Optional] Action<WWWResponse<T>> inCallback) where T : new()
	{
		return null;
	}

	public static Coroutine Delete(string inURL, [Optional] Action<WWWResponse> inCallback)
	{
		return null;
	}

	private static UnityWebRequest setupGetRequest(string url, bool sendAuthorization)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<_Request>d__9))]
	private static IEnumerator _Request(UnityWebRequest inRequest, [Optional] Action<WWWResponse> inCallback)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<_RequestWithProxy>d__10))]
	private static IEnumerator _RequestWithProxy(HttpWebRequest httpWebRequest, [Optional] Action<WWWResponse> inCallback)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<GetAsync>d__11))]
	public static Task<WWWResponse> GetAsync(string inURL, bool inSendAuthorization)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<GetAsync>d__12))]
	public static Task<WWWResponse> GetAsync(string inURL, [Optional] Dictionary<string, string> inHeaders)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<PutAsync>d__13))]
	public static Task<WWWResponse> PutAsync(string inURL, string inBodyData)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<PostAsync>d__14))]
	public static Task<WWWResponse> PostAsync(string inURL, WWWForm inFormData)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<PostJsonAsync>d__15<>))]
	public static Task<WWWResponse<T>> PostJsonAsync<T>(string inURL, object objectToSerialize, bool sendAuthorization = true, [Optional] string customAuthBearer) where T : new()
	{
		return null;
	}

	[AsyncStateMachine(typeof(<PostJsonAsync>d__16))]
	public static Task<WWWResponse> PostJsonAsync(string inURL, object objectToSerialize, bool sendAuthorization = true, [Optional] string customAuthBearer)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<PostAsync>d__17<>))]
	public static Task<WWWResponse<T>> PostAsync<T>(string inURL, byte[] inBodyData, bool inSendAuthorization, [Optional] string customAuthBearer) where T : new()
	{
		return null;
	}

	[AsyncStateMachine(typeof(<PostAsync>d__18<>))]
	public static Task<WWWResponse<T>> PostAsync<T>(string inURL, byte[] inBodyData, [Optional] Dictionary<string, string> inHeaders) where T : new()
	{
		return null;
	}

	[AsyncStateMachine(typeof(<PostAsync>d__19))]
	public static Task<WWWResponse> PostAsync(string inURL, byte[] inBodyData, [Optional] Dictionary<string, string> inHeaders)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<DeleteAsync>d__20<>))]
	public static Task<WWWResponse<T>> DeleteAsync<T>(string inURL, byte[] inBodyData, bool inSendAuthorization) where T : new()
	{
		return null;
	}

	[AsyncStateMachine(typeof(<DeleteAsync>d__21<>))]
	public static Task<WWWResponse<T>> DeleteAsync<T>(string inURL, byte[] inBodyData, [Optional] Dictionary<string, string> inHeaders) where T : new()
	{
		return null;
	}

	[AsyncStateMachine(typeof(<DeleteAsync>d__22))]
	public static Task<WWWResponse> DeleteAsync(string inURL, byte[] inBodyData, [Optional] Dictionary<string, string> inHeaders)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<_RequestAsync>d__23))]
	private static Task<WWWResponse> _RequestAsync(UnityWebRequest inRequest)
	{
		return null;
	}
}
