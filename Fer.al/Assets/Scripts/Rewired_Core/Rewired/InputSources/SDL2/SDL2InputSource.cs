using System;
using System.Collections.Generic;
using Rewired.Config;
using Rewired.Interfaces;
using Rewired.Utils.Classes.Data;

namespace Rewired.InputSources.SDL2
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal class SDL2InputSource : IDisposable, IInputSource
	{
		public delegate void uwjZggTggHTBFDQfjMwGaSLOFIX(int joystickId, byte rewiredElementType, byte elementIndex, short value);

		public delegate void DeLfqRCqbcdOgUpoBUouRXfvGJlt(int joystickIndex);

		public delegate void ZMOPkowrnwYTqyMKXwJAXaOfKbO(int joystickId);

		public delegate void xCxjPqmGZJdILDrTWBQFiFIMmOIs(int gameControllerId, byte rewiredElementType, byte sdlElementType, short value);

		private const int plxeZeVfHQLnGjshIxKjElCCfcQ = 32;

		private bool pSRVZPQHHLdqaCmDIDqEkwkQucOa;

		private bool miJWcVWeQXlcUDrUlRaMRILjqTN;

		private bool ReJWQryoBAahRzFrevXyiVZGxmJ;

		private bool qiiEmbGbcnhQClsRHlkOikgiwyiS;

		private bool ZjOOLblNcYQwrXXNEEJgJyiCsWf;

		private ADictionary<int, ofCXUZZnthwMsLfobYEuFfXddmd> YxWCMHbPaQgZcysPKFMIEybVXlg;

		private ADictionary<int, YpOXstdUISWZyhnwSxuyzINfBuO> enoBmNllMvDoxGsoUeIxydpFpBhK;

		private XuQduOJtehtSnRIDvBZHHUdTYQd.VWPjGWEoQUlbjzVArBuzvMhEZTD VRpoIuoZCakijspNBAndamLPUBu;

		private NativeBuffer uOlaDNeWiMxBKUQIhxYNYMppvQM;

		private Action yWUlHJfAowoXwxtjUhoNiHqDKak;

		private bool vEblpmllYIOuQHCXVghuIpihdSG;

		public bool initialized
		{
			get
			{
				return default(bool);
			}
		}

		private event Action _DeviceChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action DeviceChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public SDL2InputSource(UpdateLoopSetting updateLoop, bool handleJoysticks, bool handleGamepads, bool handleUnifiedMouse, bool handleUnifiedKeyboard)
		{
		}

		public void SystemDeviceConnected()
		{
		}

		public void SystemDeviceDisconnected()
		{
		}

		public void Update()
		{
		}

		public void UpdateDevices(UpdateLoopType updateLoop)
		{
		}

		public void UpdateFinished()
		{
		}

		public IList<T> GetJoysticks<T>() where T : class
		{
			return null;
		}

		private int kmDiaVkDOxWZPWJknkGiaOdwdOR()
		{
			return default(int);
		}

		private int oRyFhUVvytbmsDHHhtDbWocChZNw()
		{
			return default(int);
		}

		private ofCXUZZnthwMsLfobYEuFfXddmd JTJRDbWIJsALOCWPVJzLDDXNikSH(int P_0)
		{
			return null;
		}

		private YpOXstdUISWZyhnwSxuyzINfBuO fbyYLBMDLvSkJStFMWypxeAZVNN(int P_0)
		{
			return null;
		}

		private NZfxZgapcZrDfHOIlImhbYniErsQ WlRdAMASEuJhkZuvlJtChLGaXddg(int P_0, vxJvUArhEAFCtWNhHGCwJpxnawZ P_1)
		{
			return null;
		}

		private NZfxZgapcZrDfHOIlImhbYniErsQ MroXjiGHtYtORLdnEnEJObdjDJLH(int P_0, ooiUvbxDJOfANpQNqxCQYuhBdqW P_1)
		{
			return null;
		}

		private void SFdkawHchMjouIijwHcpLeFrppT()
		{
		}

		private void auejyNVQFahvIYYDWTfcsfvkytm()
		{
		}

		private bool XaPQxcyWqNsdQjhKzBKsjimvZyS(int P_0)
		{
			return default(bool);
		}

		private void xzceZeGGWmetBAeiWNsduDUsewIa(int P_0)
		{
		}

		private bool PBHZsPtuEbxYILeNNedeeArLgHk(int P_0)
		{
			return default(bool);
		}

		private void pDpVsCyBVQtoWpNscFUJYZrMgxM(int P_0)
		{
		}

		private ofCXUZZnthwMsLfobYEuFfXddmd YenhsGyKhilmpWqdaavZzFpxwk(int P_0)
		{
			return null;
		}

		private YpOXstdUISWZyhnwSxuyzINfBuO WtXKmRbxoZPiDarUmooqQcFMkDu(int P_0)
		{
			return null;
		}

		private void HrKyBteQRTGPVZoOyXtDRwkStWJ()
		{
		}

		private void fQioYvBbwXIqfkEAMtzXUmcldUS(ref XuQduOJtehtSnRIDvBZHHUdTYQd.XjyyRsSGBQTmFSrAEjSYYxYVcvZ P_0, float P_1)
		{
		}

		private void rCHeKFOVlnBeLkqBFsDahkjBQyv(ref XuQduOJtehtSnRIDvBZHHUdTYQd.eaiLQxFPVbiyzQeYbMDfsjXuYus P_0, float P_1)
		{
		}

		private void CpFBdEmuutFwHBCVXuwZRdenKwV(ref XuQduOJtehtSnRIDvBZHHUdTYQd.VbqHzpkFQxelXAAgaCTyIBDkDeiS P_0, float P_1)
		{
		}

		private void KfGsqunNaoaRJkjbFMseyVJmbDap(ref XuQduOJtehtSnRIDvBZHHUdTYQd.vFoaHIvxPKHheIeNlMtTEhigGsHh P_0, float P_1)
		{
		}

		private void MOAzAShnoEtLIJiGRGTiIdLqOLpp(ref XuQduOJtehtSnRIDvBZHHUdTYQd.KeufpOPSyPatYATlqXKEcbKbDMxe P_0)
		{
		}

		private void ArIooqjuAaMpjMeGWIJWUBKjXUj(ref XuQduOJtehtSnRIDvBZHHUdTYQd.KeufpOPSyPatYATlqXKEcbKbDMxe P_0)
		{
		}

		private void zljZKcoetjcSBkJyfKGGqJsttKOk(ref XuQduOJtehtSnRIDvBZHHUdTYQd.nqEtmsjAEnVUpVynOEmjtAVlpJT P_0, float P_1)
		{
		}

		private void AeIfhvlGbNQHVsGeEGhtMwWZKCx(ref XuQduOJtehtSnRIDvBZHHUdTYQd.kYOOkxdUscjOIJJnvKGoGAdHCDC P_0, float P_1)
		{
		}

		private void dghGPtQAmsiURiBZQDsOoLljdZG(ref XuQduOJtehtSnRIDvBZHHUdTYQd.TWbSqjGUHWCCRHgNzSNRhhTPAAw P_0)
		{
		}

		private void NSYKTwNWdKqoDyplZhWfEfHrpNE(ref XuQduOJtehtSnRIDvBZHHUdTYQd.TWbSqjGUHWCCRHgNzSNRhhTPAAw P_0)
		{
		}

		private void yzlkJDggnLqEgPETmBviQcQtfdx(ref XuQduOJtehtSnRIDvBZHHUdTYQd.TWbSqjGUHWCCRHgNzSNRhhTPAAw P_0)
		{
		}

		private void viMVeAbZyzvWWShccQnmKwbAOGs(int P_0, heWsaowXosfzMSjjpixrjKJUuub P_1, byte P_2, short P_3, float P_4)
		{
		}

		private void aCkXDLyoBSVamKmqZkvIsmfYgFt(int P_0, heWsaowXosfzMSjjpixrjKJUuub P_1, byte P_2, short P_3, float P_4)
		{
		}

		private void YEEGRcrMNcgsYAerxnXVzhvkzPs()
		{
		}

		public void Dispose()
		{
		}

		~SDL2InputSource()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
