using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using TMPro;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UI_SplashLogo : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Setup>d__6 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder <>t__builder;

		public UI_SplashLogo <>4__this;

		public string inLongDescription;

		public string inImageURL;

		private bool <hasSponsorImage>5__2;

		private bool <hasImage>5__3;

		private Sprite <sprite>5__4;

		private TaskAwaiter<Sprite> <>u__1;

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
	private struct <FetchIconAndSponsorId>d__7 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<Sprite> <>t__builder;

		public string inImageURL;

		private TaskAwaiter<Sprite> <>u__1;

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
	private struct <FetchSponsorImage>d__8 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<Sprite> <>t__builder;

		public string inImageURL;

		private TaskAwaiter<Sprite> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public static string sponsorId;

	[SerializeField]
	private WWImage _logoImage;

	[SerializeField]
	private WWImage _sponsorImage;

	[SerializeField]
	private WWTextMeshProUGUI _descriptionText;

	private void Start()
	{
	}

	public void Setup(string inLongDescription)
	{
	}

	[AsyncStateMachine(typeof(<Setup>d__6))]
	public UniTask Setup(string inImageURL, string inLongDescription)
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(<FetchIconAndSponsorId>d__7))]
	public static Task<Sprite> FetchIconAndSponsorId(string inImageURL)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<FetchSponsorImage>d__8))]
	public static Task<Sprite> FetchSponsorImage(string inImageURL)
	{
		return null;
	}
}
