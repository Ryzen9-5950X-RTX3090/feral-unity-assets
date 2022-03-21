using System.Collections.Generic;
using Rewired.Platforms.Custom;

namespace Rewired.Platforms.XboxOne
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal sealed class XboxOneInputSource : CustomInputSource, IXboxOneInputSource
	{
		[CustomObfuscation]
		private enum BadConnectionReason
		{
			[CustomObfuscation]
			None,
			[CustomObfuscation]
			GamepadNotActive,
			[CustomObfuscation]
			InvalidName
		}

		private struct rflDiHfmIiyzeUOeHoOuSMbBGydt
		{
			public uint yakyHVnzrOMeZdFhXNCFSGyAFNJh;

			public uint HQXhoqfkzLflnbuuTrhWOUOsxKH;

			public rflDiHfmIiyzeUOeHoOuSMbBGydt(uint unityJoystickId, uint connectedFrame)
			{
			}
		}

		private class BAggblEwbzkGnmKltXUmGbwGZdr : Joystick
		{
			private const int HSpXIOmQNElWIyytfUCCACgxbmfG = 6;

			private const int frWlFJmIuHDCrDwnhgqBkPNnPHK = 14;

			private const string uKDxeFKtfnwGPvkHrjhVFDuaWaQo = "Xbox One Controller";

			private const int PJHfszffTHZddbYqNkohfczQCGj = 0;

			private const int mWoGHZQNjtYjjCCufdSIXxpXZJO = 1;

			private const int VImxkSsWioOUPCQAneQizhUzfgVi = 2;

			private const int eMQCObENobJsHDiamEBVmTAjtJL = 3;

			private const int pvKnYdVMJgPUUuBOirGwFjDpyWn = 4;

			private const int SggBkLtPbYbphCToZBMrTOFgjnEL = 5;

			private const int spHTvylmOUFroBJixXaFvZHUKtyf = 6;

			private const int PZAsbeNupayJnjUpRVBfPDnajOb = 7;

			private const int pLgeISCQzuqBbjrqHuuirPeqiQbC = 8;

			private const int DJHNsPfGNheTzalclmJsupYExoX = 9;

			private const int ysmhsjwTxsYYkXDmjHXLVAmOkKL = 12;

			private const int xUkoNEMjxMkOrRdeBCpmaFNMaYk = 13;

			private const int VKzGtaGKpjzERDNSRNBpHEvpUiq = 14;

			private const int BFIjBYvbKkBNveTGExWwuRomvSt = 15;

			private const int DNyPiEFpTbGNvTgHqaaGKARsyjD = 0;

			private const int gXPwHcnPNDxftbaxqnAyHPpypDN = 1;

			private const int jlqjIjzPdLHAvGCzZROnqCuaEuOr = 3;

			private const int iytgxJHSREAfTapjKMMpdIXqHoGK = 4;

			private const int NcZDvMdeDbEbdHTGBlYxErQLjKDk = 8;

			private const int qBUZhZapWIzjJMYztNyCDAsiamH = 9;

			private readonly IXboxOneInputSource IfWmLaqyRlsuporQiJgqwmXsLqe;

			private int PwftjjvcgliCLJyonFqzuKQTKBiF;

			private ulong CBXmiFoQFoTazOFFeobCBxnQqOY;

			private string[] laTiEekcmcoZfZgrSDZOeWgHGyQ;

			public ulong LgvHvwZktzCBtWrELBYgfCvURvt
			{
				get
				{
					return default(ulong);
				}
			}

			public BAggblEwbzkGnmKltXUmGbwGZdr(IXboxOneInputSource inputSource, ulong xboxControllerId, int unityJoystickId, bool isConnected)
			{
			}

			public override void Update()
			{
			}

			public void ItdhavHGXcUkAhyjaCFbIXENJheh(ulong P_0)
			{
			}

			private void duLuRPLQXuawkWSRsiMYVvscyVg()
			{
			}

			private bool fanZEvScpHOhjdyqIAGzUttVsod(int P_0)
			{
				return default(bool);
			}

			private void UpSNrCWxlLHTMarUaEyOkHdRUug()
			{
			}
		}

		private const int CljYMibFYEKebAlwFYmJUyrwtij = 8;

		private readonly bool UiuVfXaOVJlpnMDNdnJtrhHFBAyf;

		private bool pyGeXNEBbHwJbQEEeOUTZGJFHBcC;

		private Queue<rflDiHfmIiyzeUOeHoOuSMbBGydt> QoCsVbrNbDrlNdtDlVkqPOHfTLU;

		private bool vEblpmllYIOuQHCXVghuIpihdSG;

		public override bool isReady
		{
			get
			{
				return default(bool);
			}
		}

		public override void Update()
		{
		}

		private void IdrJLwlQkclhWJnlmoCaMKrlJEm(uint P_0, bool P_1)
		{
		}

		private void uHpqNzGhRTBZibUgqVZPNPardwDD(uint P_0, bool P_1)
		{
		}

		private void NsUKomOVOfUmonpfKuZRSJscJoa()
		{
		}

		private bool scAswdcibZgXmojhsmmgibTxHlC(uint P_0, bool P_1, out BadConnectionReason P_2)
		{
			return default(bool);
		}

		private void eytOUFzpxdBqVGrBUfevEeQiFTKA()
		{
		}

		public int GetXboxOneUserIdFromUnityJoystick(int unityJoystickId)
		{
			return default(int);
		}

		public void PulseVibrateMotor(ulong xboxOneJoystickId, XboxOneGamepadMotorType motor, float startLevel, float endLevel, float duration)
		{
		}

		public bool SetXboxOneVibration(ulong xboxOneJoystickId, xcWyiIfNoFqFVFpAfvXHnUTXXPi vibration)
		{
			return default(bool);
		}

		public override void Dispose()
		{
		}

		~XboxOneInputSource()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}
}
