using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_XPIndicator : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Setup>d__6 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_XPIndicator <>4__this;

		public string inUserUUID;

		private TaskAwaiter <>u__1;

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
	private struct <RefreshGraphics>d__8 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public UI_XPIndicator <>4__this;

		private TaskAwaiter<IPlayerLevel> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private WWTextMeshProUGUI _levelText;

	[SerializeField]
	private WWImage _levelProgressImage;

	[SerializeField]
	private UI_Tooltip _tooltip;

	[SerializeField]
	private bool _ignoreXPUpdates;

	private string _userUUID;

	private bool _isMe;

	[AsyncStateMachine(typeof(<Setup>d__6))]
	public void Setup(string inUserUUID)
	{
	}

	private void OnDestroy()
	{
	}

	[AsyncStateMachine(typeof(<RefreshGraphics>d__8))]
	private Task RefreshGraphics()
	{
		return null;
	}

	private void OnXPGained(XPUpdateMessage inMessage)
	{
	}
}
