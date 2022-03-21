using System;
using Rewired.Drivers.Interfaces;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired.HID.Drivers
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal class DualShock4Driver : HIDDeviceDriver, IDisposable, IControllerDriver, IDriver_DualShock4
	{
		private enum CcxSamzDLVbBjbOUDyZELlwQbwG
		{
			xAomvonipbmXpporXoNBoOdfStq,
			PVgcydSbNDROAuQJZlzSxFwdtoZ,
			PocWozENsBwPujngorriXlJqKzh
		}

		private enum ISEXaYLKrUwSsDCKfYxeYXIyLLD
		{
			PoBZZNoYGVGuWkUBxQqhGBhFqWy,
			jeDCkdtzztZnRAdYJyTaZiqoDkr,
			PVgcydSbNDROAuQJZlzSxFwdtoZ
		}

		private const float PiGFndTLnSUCzMhgmEQlDlczrbt = 4f;

		private const int yPnzCDCUouValTYijrIjZkOzBoi = 14;

		private const int gHoDAZBGMoBxErBGngmAckcknKLY = 2;

		private const int KrjpCsXuCFdbTORRAOtKvmkGEiZ = 0;

		private const int crsGAtILwmOgzyZgZZYBBDBKIlf = 1912;

		private const int UQVPSaLpBciqjjmDPdNKlRoDtHn = 0;

		private const int vWNiZoybugHSHYUjelQVgDdckgi = 941;

		private const bool ZVDtcJzDDgDxDZembjqwPTffFjf = false;

		private const bool FuRpobCCAbNLHZKoqrIkWBGwwip = true;

		private const float pAzHEvkGapSPqiVeXWsqoATNFEkA = 2.5f;

		private const int HwnbjuynQFAdgrQaOuGHjwiIJmf = 0;

		private const int FFiHvFTyIcyhlboMNrhehMCRXpf = 0;

		private const int aNAFjJKdXImWljqNFSTsDWlNDmy = 1;

		private const int BzaWfjesAqKbjwFbBQsvbhpHzzp = 0;

		private const int HOQQRyZVdaxICQOrsBulESyrBXl = 0;

		private const int DjMQqOGvBLjDwDKiqtyAlSXJCBy = 0;

		private const int sUaHiXJXErvDdfBjUarpuXDAJaN = 1;

		private const int OQyxUCGTioIGdTmOOubEVncKiyE = 17;

		private const int gRRRzPLeyJGbUaYrhNmHljqrMFcb = 0;

		private const int NhjXZtRhzQjtfIgkHsMzAgqssXw = 2;

		private const int jcpOukCYTRKBqJGhjenbFCbHJwv = 64;

		private const int rhUTETHZBMRIDFGktJTyjaNbrdH = 78;

		private const int KDjywAhqbsQFsLJQaWiOliqnSOO = 1;

		private const int lexkYOvSZzEtKjmgvxuGurgBJqc = 2;

		private const int elDUOmDgdYymQdwCdhFfmsuksFT = 3;

		private const int wCeoZZmyIICGSrNTGfkAVRUwtxv = 4;

		private const int CeHJGHRoAlIjbDigOJkIkaAMOAe = 8;

		private const int BopDbbAEswKYMdBMZheGhNkfnjM = 9;

		private const int PzZkJKhrEwPBTuUkkrUESmNBVEh = 5;

		private const int RcAIpcDUFLUOCRXyhCOnHRAYONyH = 19;

		private const int httUqyHeWurXHRYwzRsOcBrmKEN = 13;

		private const int wdSPqgDyCXqZsrFIJHFWznctLSm = 35;

		private const int DmMlqCiKPRpvFbdoLIPreDVNegE = 5;

		private const int crYkNFiIRZUBIyHDWvEsYBhbGQg = 6;

		private const int GKdQloORUHNPtxcHstdmuWxsDZD = 7;

		private const int sSGhsmDgvNuHMhprjkgngffahhVh = 10;

		private const int qWtvAigEJdRQGWBoagAVAEaJdDP = 30;

		private const int JiBBVqAnbWayUBooihgKbWCBJSXU = 27;

		private const byte gRXEWVINmxbGLwYEoSdoLJhEiGg = 200;

		private const byte GLCApaqWSGcbyLoVjtlRJXEBBcy = 53;

		private const byte tOItTmDbVFAFgHyWRWWXyneFbRH = byte.MaxValue;

		private const byte yfKcIVfWKSDfEjXaQxGIfDsTsqT = 0;

		private const bool xNhjYFxzfglQPMdtzYTEeocvcZZE = true;

		private const bool DhOEUeGsfjHIOfgDQcyoMSeDCey = true;

		private const bool flBFIEogoZDBdtppKNNrHcNLhFE = false;

		private const bool MirerWEMJyzUwTfdVKlpZDWVKxe = true;

		private const int bOUSQjkQXejIhKqgJKbkRkppkvx = 25;

		private const bool xroMfgSsMnnUByHlnitLzdIJjTGg = true;

		private const float EEUiwMoRtjeuafbvipGPTrFgZra = 8192f;

		private const float NCnDfNFzhLTclwMxzZieFmfjZJZc = 4096f;

		private const float kCfQwRNRZWIuUEpmVQXXsmibCVN = 16384f;

		private const float jrcgeJOUAIgizczzRMkqrrKHFSMK = 16777216f;

		private const float eHdvNbRiZaRlVOIRPEUIsdqbIdk = 268435460f;

		private const float WaVHDcAuQkqWNDINuVvuaBDAIxr = 0.01999998f;

		private const float TOLOPxQxKwrmoVczTTkxYVKIawu = 8192f;

		private const float gFWPqmCdZcpEBaCJqFkqbjJFbxG = 0.0009765625f;

		private const float mDyamlbNTVMynlvaIwQUHeiHsDyC = 0.05595291f;

		private const float EKyPVWfiUypHVvnCGdahmutRcmCa = 0.98f;

		private const float XYBqVsWjhaboihaFojcBMzivgCo = 45f;

		private const float medcDWAafCLDeRBKmvTWdjtziOgd = 10f;

		private readonly bool IhlGCfAoauXIaGqgprCclpysuVHM;

		private readonly int BUMzWXEOFmIRPoWgBNJDLchwuqp;

		private readonly int HDiKNUYtqzrrqCVEXbFtEdEhwHz;

		private readonly bool TQskGMETlYDPbDBWtkyupzTgrcM;

		private readonly byte UsgaDeDHqjJirMRAUYMYwoQgWpEx;

		private readonly int GJMrjKTWgsnGyzToEcayzhDgjUU;

		private readonly int ynmbAHmTASdkPGdsGSpsCsQQwjyw;

		private readonly int MkThdjyKzwtBOjbwSolJrEHfyeN;

		private readonly int UEEAjdFzqhoZKHeIXpvPeGURzJfv;

		private readonly int ZOsAXEbftaZzbKKigjlRAOgidRGC;

		private readonly int nzUxZwgnyxlcWHGgGNiyFUGupcQ;

		private readonly NativeBuffer opZNohkiMGYnLwvAgGWTlKZYMKU;

		private readonly NativeBuffer bGwmQLshkzsZvTEvekXPlVbBfQZ;

		private readonly OutputReport mItRKAnsahRlyYDrIigpMCrvyLj;

		private readonly Func<OutputReport, bool> GIMKncRHOXHxWIVrhQZQpLQjIqU;

		private readonly Action<OutputReport> zUUVhqwbAFbCuKMbuxukcRjFlmGe;

		private bool viAyhMbVQPFuhhveSKOFsEUsaoR;

		private bool nyuJgSiiVZdEbZMuzEAmuWNYgCjG;

		private float AsuRMglpfyDkOdSWajJQrdtxHFUC;

		private byte uPFReEAQavKWkqSyKpuuEvIRGER;

		private Quaternion ZUmHOvOaiTkmkqMhBzCQsCgHJrF;

		private ushort sDmIYarUtEZfciQqRxcCaflJYoi;

		private float ZODaNAJNsJTxaCkHcmFGwAHtBDf;

		private float DoJICLJLQXjKHOftTXsCcbFPZQs;

		private float mrzEMvYFSOiJGWyEFpCfjgHSMy;

		private byte QrJOiDMgczZqDRzKBUlTOivjVxn;

		private byte nNyACKkPqVIYWTTmNtKGMvXpbdp;

		private Quaternion XrxbgmJGKAHQFnOkAEugkQVeNoC;

		private bool SVSaOlvkKMaBDuqnTwwLPAMrHFKK;

		private int VwAgKOJRYcPSKJxMGblUyPdimdC;

		private int[] NNcsawzCrIzCbspQCrsAElLdEvg;

		private int[] oWBStAVKKGbIDApbnwixaIcdtKhb;

		private bool isVibrating
		{
			get
			{
				return default(bool);
			}
		}

		public float BatteryLevel
		{
			get
			{
				return default(float);
			}
		}

		public float LeftMotor
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float RightMotor
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float LightColorR
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float LightColorG
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float LightColorB
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float LightFlashOnDuration
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float LightFlashOffDuration
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Vector3 AccelerometerValue
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 AccelerometerValueRaw
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 GyroscopeValue
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 GyroscopeValueRaw
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 LastGyroscopeValue
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 LastGyroscopeValueRaw
		{
			get
			{
				return default(Vector3);
			}
		}

		public Quaternion Orientation
		{
			get
			{
				return default(Quaternion);
			}
		}

		public int MaxTouches
		{
			get
			{
				return default(int);
			}
		}

		public void ResetOrientation()
		{
		}

		public int GetTouchCount()
		{
			return default(int);
		}

		public bool IsTouchingAtIndex(int index)
		{
			return default(bool);
		}

		public bool IsTouchingAtTouchId(int touchId)
		{
			return default(bool);
		}

		public int GetTouchIdAtIndex(int index)
		{
			return default(int);
		}

		public bool GetTouchPositionByIndex(int index, out Vector2 position)
		{
			return default(bool);
		}

		public bool GetTouchPositionByTouchId(int touchId, out Vector2 position)
		{
			return default(bool);
		}

		public bool GetTouchPositionAbsoluteByIndex(int index, out int positionX, out int positionY)
		{
			return default(bool);
		}

		public bool GetTouchPositionAbsoluteByTouchId(int touchId, out int positionX, out int positionY)
		{
			return default(bool);
		}

		public void StopLightFlash()
		{
		}

		public void StopVibration()
		{
		}

		public DualShock4Driver(InitArgs initArgs)
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

		private void whZeXfivRwxFMuTNeZKehdwmBKt(SBUIcpSIfZEbnLGolpTEtKWROEd P_0)
		{
		}

		private bool STtZZcScRaSedwCGlozUlagaXNr(SBUIcpSIfZEbnLGolpTEtKWROEd P_0)
		{
			return default(bool);
		}

		private void xmtaawpaLafFNiSlNPCDoSJEbqh()
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

		private void ltYcfSjOphvSKzdBwCVRphcMgjp()
		{
		}

		private void eeVOLXnzlBYhUSLorajJKTtosmY(NativeBuffer P_0)
		{
		}

		private void gmAhEJPYfgmRbUAuCfEYRvFLFrm()
		{
		}

		private void xAkpQbMntWLqPZjKxclDLtwZcFg(Vector3 P_0, Vector3 P_1)
		{
		}

		private static Quaternion OZDtwQwaiZiYzqydBAnVVjFbbKT(Quaternion P_0, Vector3 P_1)
		{
			return default(Quaternion);
		}

		private static Vector3 mXRndyaiwUzFdfksPCGekcnQUaBK(Vector3 P_0, Vector3 P_1)
		{
			return default(Vector3);
		}

		private Quaternion IgxNsIeoJPvisipGodsnBZescxQO(Quaternion P_0, CcxSamzDLVbBjbOUDyZELlwQbwG P_1)
		{
			return default(Quaternion);
		}

		public static Quaternion Inverse(Quaternion quaternion)
		{
			return default(Quaternion);
		}

		private float kpiaNkpzJYHVauFjTxFhxHJRUkf(float P_0, float P_1)
		{
			return default(float);
		}

		private Vector3 glSrmSnNYfrsxScMjcynYaaQkzR(Vector3 P_0, float P_1 = 0f)
		{
			return default(Vector3);
		}

		private Quaternion vifkLlEduLcOsdUYoOUINnhwtZfI(Vector3 P_0, float P_1 = 0f)
		{
			return default(Quaternion);
		}

		private Quaternion kQUXcFQVCsSQDpBqkNHLzrykcue(Vector3 P_0, float P_1 = 0f)
		{
			return default(Quaternion);
		}

		private float GQUpjntVDHedlxMmlUIlMKzSGAm(Vector3 P_0)
		{
			return default(float);
		}

		private bool XdvdeeCJakiVRJfPsRyxGRTQJvxF(float P_0)
		{
			return default(bool);
		}

		private bool KDDRRIMPQkxTJjqVLcFejacXyVp(Vector3 P_0, out ISEXaYLKrUwSsDCKfYxeYXIyLLD P_1)
		{
			return default(bool);
		}

		private bool ofCnKygwiaKWGeFzyCeobZwGghT(Vector3 P_0)
		{
			return default(bool);
		}

		private bool ZGmhRfKIHBGEBOjlxhGEkfAtanL(Vector3 P_0)
		{
			return default(bool);
		}

		private Vector3 wMNgJRrudGAWubGHyAWxyCZGiRK(float[] P_0)
		{
			return default(Vector3);
		}

		private Vector3 cXLjRmmfCEMdyWhIZBaghglIYrM(ExpandableArray_DataContainer<HIDGyroscope.MHFgKytqZWorXhVxTJLZCCoNZhX> P_0)
		{
			return default(Vector3);
		}

		private Vector3 cXLjRmmfCEMdyWhIZBaghglIYrM(Vector3 P_0, float P_1)
		{
			return default(Vector3);
		}

		private int YPGenAfUkaGjJawPDPPonblNlOE(int P_0)
		{
			return default(int);
		}

		private void IhqbZzQkTyfKzMUpJdEZQQOYAdS(byte[] P_0, float[] P_1)
		{
		}

		private void FWllakxzsKClZIphbcdGNnYyTpn(byte[] P_0, float[] P_1)
		{
		}

		private float AZewDUjOfTFTWHFyIlpdAwDodXq()
		{
			return default(float);
		}

		private void HegkzGpWZGxDjSJtYtjBVVqnBhj(NativeBuffer P_0, HIDTouchpad.TouchData[] P_1)
		{
		}

		private int DFDDkfzkXwkDBObizwgVmiajVLK(int P_0, bool P_1, int P_2)
		{
			return default(int);
		}

		private void UZTfLyGQpDDqCwcKMvJouKKXhMbA()
		{
		}

		~DualShock4Driver()
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
