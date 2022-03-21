using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WW.Waiters;

public class UI_Window_AccountCreation : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <CheckUsername>d__99 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<string> <>t__builder;

		public UI_Window_AccountCreation <>4__this;

		private TaskAwaiter<string> <>u__1;

		private TaskAwaiter<WWWResponse<ValidateDisplayNameResponse>> <>u__2;

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
	private struct <CreateAccount>d__102 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_AccountCreation <>4__this;

		public string inUsername;

		public string inEmail;

		public string inPassword;

		private <>c__DisplayClass102_0 <>8__1;

		public string inEmailVerificationCode;

		private TaskAwaiter<string> <>u__1;

		private TaskAwaiter<WWWResponse<RegisterUserResponse>> <>u__2;

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
	private struct <Login>d__103 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public string inEmail;

		public string inPassword;

		public UI_Window_AccountCreation <>4__this;

		private TaskAwaiter<LoginMessage> <>u__1;

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
	private struct <<RefreshUsernameStatus>b__100_0>d : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_AccountCreation <>4__this;

		private string <usernameToTest>5__2;

		private TaskAwaiter<string> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	[Header("Birthday")]
	private UI_FieldStatusIndicator _birthdayStatusIndicator;

	[SerializeField]
	private UI_Panel_Dropdown _monthDropdown;

	private int _monthCategory;

	private bool _setUpDropdown;

	[SerializeField]
	private TMP_InputField _dayInput;

	[SerializeField]
	private TMP_InputField _yearInput;

	[SerializeField]
	private WWTextMeshProUGUI _birthdayErrorText;

	[SerializeField]
	[Header("Email")]
	private UI_FieldStatusIndicator _emailStatusIndicator;

	[SerializeField]
	private TMP_InputField _emailInput;

	[SerializeField]
	private WWTextMeshProUGUI _emailErrorText;

	[SerializeField]
	[Header("Password")]
	private UI_FieldStatusIndicator _passwordStatusIndicator;

	[SerializeField]
	private TMP_InputField _passwordInput;

	[SerializeField]
	private WWTextMeshProUGUI _passwordErrorText;

	[SerializeField]
	[Header("Username")]
	private UI_FieldStatusIndicator _usernameStatusIndicator;

	[SerializeField]
	private TMP_InputField _usernameInput;

	[SerializeField]
	private WWTextMeshProUGUI _usernameErrorText;

	[SerializeField]
	[Header("TOS")]
	private FeralButton _agreeToTOSToggle;

	[SerializeField]
	[Header("Marketing OptIn")]
	private FeralButton _marketingOptInToggle;

	private bool _agreeToMarketing;

	[SerializeField]
	[Header("Other")]
	private CanvasGroup _formGroup;

	[SerializeField]
	private FeralButton _registrationBtn;

	[SerializeField]
	private TMP_InputField[] _submitFields;

	private bool _birthdayIsDirty;

	private WW.Waiters.Waiter _birthdayValidationWaiter;

	private string _birthdayStatus;

	private bool _emailIsDirty;

	private WW.Waiters.Waiter _emailValidationWaiter;

	private string _emailStatus;

	private Dictionary<string, string> _cachedEmailValidations;

	private bool _passwordIsDirty;

	private WW.Waiters.Waiter _passwordValidationWaiter;

	private List<string> _passwordBlacklist;

	private string _passwordStatus;

	private bool _usernameIsDirty;

	private WW.Waiters.Waiter _usernameValidationWaiter;

	private string _usernameStatus;

	private bool _accountBeingCreated;

	private WW.Waiters.Waiter _postSubmissionWaiter;

	private string Month
	{
		get
		{
			return null;
		}
	}

	private string Day
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private string Year
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private string Birthday
	{
		get
		{
			return null;
		}
	}

	private string Email
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private string Password
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private string Username
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool AgreeToTOS
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool AgreeToMarketing
	{
		get
		{
			return default(bool);
		}
	}

	private bool IsValidBirthday
	{
		get
		{
			return default(bool);
		}
	}

	private bool IsValidEmail
	{
		get
		{
			return default(bool);
		}
	}

	private bool IsValidPassword
	{
		get
		{
			return default(bool);
		}
	}

	private bool IsValidUsername
	{
		get
		{
			return default(bool);
		}
	}

	public static void OpenWindow()
	{
	}

	public static void QueueWindow()
	{
	}

	public static void CloseWindow()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public override void MOnDestroy()
	{
	}

	public void BtnClicked_CreateAccount()
	{
	}

	public void BtnClicked_Back()
	{
	}

	public void BtnClicked_PrivacyPolicy()
	{
	}

	public void BtnClicked_TermsOfService()
	{
	}

	public void BtnToggled_ShowPassword(bool inShowPassword)
	{
	}

	public void OnDropDownItemSelected_Category(int inCategory)
	{
	}

	public void InputFieldValueChanged_Month()
	{
	}

	public void InputFieldValueChanged_Day()
	{
	}

	public void InputFieldValueChanged_Year(string year)
	{
	}

	public void InputFieldValueChanged_Email()
	{
	}

	public void InputFieldValueChanged_Password()
	{
	}

	public void InputFieldValueChanged_Username()
	{
	}

	public void OnFieldDeslected_Birthday()
	{
	}

	public void OnFieldDeselected_Email()
	{
	}

	public void OnFieldDeselected_Password()
	{
	}

	public void OnFieldDeselected_Username()
	{
	}

	private void OnFieldSubmit(string inFieldText)
	{
	}

	private string CheckBirthday()
	{
		return null;
	}

	private void RefreshBirthdayStatus()
	{
	}

	private string CheckEmail()
	{
		return null;
	}

	private void RefreshEmailStatus()
	{
	}

	private string CheckPassword()
	{
		return null;
	}

	private void RefreshPasswordStatus(bool inShowError)
	{
	}

	[AsyncStateMachine(typeof(<CheckUsername>d__99))]
	private Task<string> CheckUsername()
	{
		return null;
	}

	private void RefreshUsernameStatus()
	{
	}

	private void RefreshRegistrationButton()
	{
	}

	[AsyncStateMachine(typeof(<CreateAccount>d__102))]
	private void CreateAccount(string inUsername, string inEmail, string inPassword, string inEmailVerificationCode)
	{
	}

	[AsyncStateMachine(typeof(<Login>d__103))]
	private void Login(string inEmail, string inPassword)
	{
	}
}
