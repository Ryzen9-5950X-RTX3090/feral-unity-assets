using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WW.Waiters;

public class UI_Window_Login : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <BtnClicked_Login>d__24 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_Login <>4__this;

		private <>c__DisplayClass24_0 <>8__1;

		private TaskAwaiter<LoginMessage> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public CanvasGroup inputGroup;

	[SerializeField]
	private WWTextMeshProUGUI _serverTierText;

	[SerializeField]
	private TMP_InputField _emailAddressInput;

	[SerializeField]
	private TMP_InputField _passwordInput;

	[SerializeField]
	private FeralButton _loginBtn;

	[SerializeField]
	private FeralButton _rememberMeToggle;

	private bool _isValidEmail;

	private bool _isValidPassword;

	private string _debugPrefsPrefix;

	private WW.Waiters.Waiter _loginWaiter;

	public string Email
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string Password
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool RememberMe
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	protected override void OnOpen()
	{
	}

	protected override void DoDelayedOpenAnimation()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public void InputFieldValueChanged_Email()
	{
	}

	public void InputFieldValueChanged_Password()
	{
	}

	[AsyncStateMachine(typeof(<BtnClicked_Login>d__24))]
	public void BtnClicked_Login()
	{
	}

	public void BtnClicked_NewAccount()
	{
	}

	public void BtnClicked_ForgotPassword()
	{
	}

	public void BtnClicked_Quit()
	{
	}

	public void BtnToggled_RememberMe(bool inIsOn)
	{
	}

	public void BtnClicked_Settings()
	{
	}

	private void OnEmailSubmit(string inEmail)
	{
	}

	private void OnPasswordSubmit(string inPassword)
	{
	}

	private void RefreshLoginButton()
	{
	}

	private void RefreshEmailStatus()
	{
	}

	private bool IsValidEmail()
	{
		return default(bool);
	}

	private void RefreshPasswordStatus()
	{
	}

	private bool IsValidPassword()
	{
		return default(bool);
	}

	private void OnSettingsWindowOpened(WindowOpenedMessage inMessage)
	{
	}

	private void OnSettingsWindowClosed(WindowClosedMessage inMessage)
	{
	}
}
