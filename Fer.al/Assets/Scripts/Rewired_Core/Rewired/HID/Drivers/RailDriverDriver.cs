using System;
using Rewired.Drivers.Interfaces;
using Rewired.Utils.Classes.Data;

namespace Rewired.HID.Drivers
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal class RailDriverDriver : HIDDeviceDriver, IDisposable, IControllerDriver, IDriver_RailDriver
	{
		private enum AFxHdGfMvNhWIPlpkFLSAWJPfHRg
		{
			DHOlrMeLFQUrhrciWPVesxlfgtQ,
			HIiniPCUXVlnvbRIUhyVKcQvzjB
		}

		private const int SXCnvSUfzkSiSZZMEBgvGimCHHDc = 1523;

		private const int MIPPHacrrActZxEOPbwJPoaHgQX = 210;

		private const int yPnzCDCUouValTYijrIjZkOzBoi = 50;

		private const int qABrgFEjALgosESANWdsZwvFoEn = 44;

		private const int oCnUkxqPzqiTDMRGjHGGsCuheDI = 6;

		private const int MgKqEWEhAJJmlWKWdAwWgZQhpSnn = 44;

		private const int FLrCYJHbvslPRwEjrTrqsIUiCUWW = 45;

		private const int KyPCFAfgfiofaBpJSMCTlpCOZMPS = 46;

		private const int LClhQgPHXQKvauRQFlfjZwYBVtk = 47;

		private const int eqqbPeVYDynUKiXIsBwMMBPqcvp = 48;

		private const int ZEipcodOoJhLqcszhPlKjxovLgMF = 49;

		private const int SEnsVgQFSGrpwRoCEnQzySEHRSQ = 0;

		private const int BKeETAgVDMDeYExCWBdJCeqZuYne = 15;

		private const int SfTsyyxPIZkxIuaXoTURnukHgjm = 9;

		private const int DdTAXzqDnWljgdGYWrdoTfOOGwm = 1;

		private const int GAOPeoRCMOmyILukEJYDXyubPLK = 2;

		private const int kjqNgGUJlHcIcIVyAPgfYEVKkuB = 3;

		private const int NuCSAqyaxZaFFARhIBrzVvyvUyE = 4;

		private const int aYLKzFUaZamZdzDNoMqsjJpVYCS = 5;

		private const int ElcFNrHVUGoGRWwTsPgMpjdVnbS = 6;

		private const int rSopJwiJCSwYGjOPaRUOlKJiBUli = 7;

		private const int BpvGEZkOLhPjIQfQeeHUDIunqVxD = 8;

		private const int PJlkWuhvsQlHkNIPUOYdvaitYLU = 14;

		private const int FOYjSJapvofdCiakiFZGEnXnoTu = 3;

		private const int CnybBHFvApCxFnaFefnbFbXXpNIj = 7;

		private readonly NativeBuffer opZNohkiMGYnLwvAgGWTlKZYMKU;

		private readonly NativeBuffer bGwmQLshkzsZvTEvekXPlVbBfQZ;

		private bool LNlAsuyZsRDRuKKmwIFPJLhgNaXz;

		private byte[] utaxvOAPighrKujUifizdiNobRH;

		private readonly OutputReport mItRKAnsahRlyYDrIigpMCrvyLj;

		private readonly Func<OutputReport, bool> GIMKncRHOXHxWIVrhQZQpLQjIqU;

		private readonly Action<OutputReport> zUUVhqwbAFbCuKMbuxukcRjFlmGe;

		public bool SpeakerEnabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public void SetLEDDisplay(int digitIndex, byte digitBitValues)
		{
		}

		public void SetLEDDisplay(byte digit1BitValues, byte digit2BitValues, byte digit3BitValues)
		{
		}

		public RailDriverDriver(InitArgs initArgs)
		{
		}

		public override void Update(UpdateLoopType updateLoop)
		{
		}

		public override bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, float timestamp)
		{
			return default(bool);
		}

		public override Controller.Extension CreateControllerExtension()
		{
			return null;
		}

		private bool STtZZcScRaSedwCGlozUlagaXNr(AFxHdGfMvNhWIPlpkFLSAWJPfHRg P_0, SBUIcpSIfZEbnLGolpTEtKWROEd P_1)
		{
			return default(bool);
		}

		private void xmtaawpaLafFNiSlNPCDoSJEbqh(AFxHdGfMvNhWIPlpkFLSAWJPfHRg P_0)
		{
		}

		private bool WPZGMlGadzWGNkNNYCTxRoUawjbo(SBUIcpSIfZEbnLGolpTEtKWROEd P_0)
		{
			return default(bool);
		}

		private void nxhcezssRzdcWxCszmkJAETEeBj(NativeBuffer P_0, float P_1)
		{
		}

		private void LMjlrIxnXrEhSIfGklJAMuSHCDA(HIDControllerElement[] P_0, NativeBuffer P_1, float P_2)
		{
		}

		~RailDriverDriver()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public static bool Matches(int vid, int pid)
		{
			return default(bool);
		}
	}
}
