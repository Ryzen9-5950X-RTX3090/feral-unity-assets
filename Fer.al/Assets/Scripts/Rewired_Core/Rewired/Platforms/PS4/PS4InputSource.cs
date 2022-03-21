using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Rewired.Interfaces;
using Rewired.Platforms.Custom;
using Rewired.Platforms.PS4.Internal;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Platforms.PS4
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal sealed class PS4InputSource : CustomInputSource, IControllerAssigner
	{
		private class bVdLitkJwIkMtgpGEhlltNcDAVtB
		{
			public struct amDVRclcdlhHlNBNMFAuxkaDfvL
			{
				public int yqGgGVbZkMCNTIxfuiHTVgIqHCJ;

				public int UWBFQEfrTnYUCjshCYfdJplmoOOm;

				public int bdmIEaEbgsJTwdQWVXeQWkyhpqFe;

				public bool STsORkqoVwmWsWAMVLhuWNzKAJj;

				public amDVRclcdlhHlNBNMFAuxkaDfvL(int playerId, int handle, int deviceClass, bool isSpecialController)
				{
				}
			}

			public struct QUohiajXjNgRguTFzwsChJokNwo
			{
				public int yqGgGVbZkMCNTIxfuiHTVgIqHCJ;

				public int UWBFQEfrTnYUCjshCYfdJplmoOOm;

				public bool STsORkqoVwmWsWAMVLhuWNzKAJj;

				public QUohiajXjNgRguTFzwsChJokNwo(int playerId, int handle, bool isSpecialController)
				{
				}
			}

			private class gJimgVEtEKjjtBghbyfHMHtAltx
			{
				public readonly bool STsORkqoVwmWsWAMVLhuWNzKAJj;

				public bool hvZFJvCsezEBoyduXJlPDonRVQP;

				public int UWBFQEfrTnYUCjshCYfdJplmoOOm;

				public int bdmIEaEbgsJTwdQWVXeQWkyhpqFe;

				public gJimgVEtEKjjtBghbyfHMHtAltx(bool isSpecialController)
				{
				}

				public iOffFQkOuXzkNBIpmUecQVQqSVLS KkJiNfHDfiJwfwbJJdnbTpAKFxkf(bool P_0, int P_1, int P_2)
				{
					return default(iOffFQkOuXzkNBIpmUecQVQqSVLS);
				}

				private void vMfAexzdpfzhXKkyGdAHmJVnQEr()
				{
				}
			}

			[Flags]
			private enum iOffFQkOuXzkNBIpmUecQVQqSVLS
			{
				PoBZZNoYGVGuWkUBxQqhGBhFqWy = 0,
				MuvJHvZGEoEJPiVlttEMQktXAcqj = 1,
				tzmAMoABfcLEwMCWeFSzgCQDVbI = 2,
				qQucigIhMiBUrHzLuPJvduaBobf = 4
			}

			private readonly int fRskZosLuSThEgySMpCXrMvfEqAf;

			private readonly bool mswGSyiKsnzKVrCPvokGGJlKMST;

			private readonly int[] UUjceoLFgvIGaMyOQDfnconnThG;

			private readonly int[] idiRIMrDIGaSGhMbgWLBMfoxGZn;

			private readonly IExternalTools nhAGFSdWWacMFCxNPAHNFwdgKnWN;

			private readonly gJimgVEtEKjjtBghbyfHMHtAltx[] UlmLLsTkJpWdOfbQsFlLjUIHKtE;

			private readonly gJimgVEtEKjjtBghbyfHMHtAltx[] myaxGznpiRYndWgPoVJUdBdMRLE;

			private readonly List<amDVRclcdlhHlNBNMFAuxkaDfvL> ayAOfBdgxZPHSGhlydbfGudSkRr;

			private readonly List<QUohiajXjNgRguTFzwsChJokNwo> PRJXUKSZqDhVcGjBINtDBqGFgQw;

			[CompilerGenerated]
			private static Func<gJimgVEtEKjjtBghbyfHMHtAltx> SoptGiBIwpEzOTmBujKpoVBsSer;

			[CompilerGenerated]
			private static Func<gJimgVEtEKjjtBghbyfHMHtAltx> AGoLVphFiYSQJEBguHfxHhzJytur;

			public event Action<amDVRclcdlhHlNBNMFAuxkaDfvL> otSrWzRexeFOjkthPDUVyKctLKV
			{
				add
				{
				}
				remove
				{
				}
			}

			public event Action<QUohiajXjNgRguTFzwsChJokNwo> XwQJpVrFTBzrglJROxGzUiOThmr
			{
				add
				{
				}
				remove
				{
				}
			}

			public bVdLitkJwIkMtgpGEhlltNcDAVtB(int maxPlayers, bool supportSpecialControllers)
			{
			}

			public void MrPMknIMZzaXDjcXZFUzCeTcWDAs()
			{
			}

			private void UtGfmFMhxafSIjqIPBQMfvpUQDKu(int P_0, gJimgVEtEKjjtBghbyfHMHtAltx P_1, int P_2, bool P_3)
			{
			}

			[CompilerGenerated]
			private static gJimgVEtEKjjtBghbyfHMHtAltx pOcCcEPETYfiVgcsLGAPfcnitqGJ()
			{
				return null;
			}

			[CompilerGenerated]
			private static gJimgVEtEKjjtBghbyfHMHtAltx nKBfZOoSRNcWGVmXsGDbjHqfeFdg()
			{
				return null;
			}
		}

		private abstract class meaDvZLdTStMzqDmUtkldoXVBFq : Joystick, IPS4ControllerExtensionSourceSixAxisSensor, IPS4ControllerExtensionSourceVibrator, IPS4ControllerExtensionSourceLight, IPS4ControllerExtensionSource
		{
			[CustomObfuscation]
			public enum ControllerType
			{
				[CustomObfuscation]
				Unknown,
				[CustomObfuscation]
				Gamepad,
				[CustomObfuscation]
				Move,
				[CustomObfuscation]
				Guitar,
				[CustomObfuscation]
				Drum,
				[CustomObfuscation]
				DjTurntable,
				[CustomObfuscation]
				DanceMat,
				[CustomObfuscation]
				Navigation,
				[CustomObfuscation]
				SteeringWheel,
				[CustomObfuscation]
				Stick,
				[CustomObfuscation]
				FlightStick,
				[CustomObfuscation]
				Gun
			}

			protected enum RdBLmZZaUnqkUJwfsSPLBCRwHRe
			{
				IjuFlluoMybUtpSqFtBQAlMgUyR,
				NmKtZgJGKXhhdAwkHccPjmHfhnk,
				xeXPypynNGxwlFuyHbzDZbmdEHH
			}

			public class tQdmWIvYpLTtWCLOpumBTXPfGCC
			{
				public readonly int RweyBZyAAIjbTgpvgIOlbybhzioP;

				public readonly int QsBvetqPHrzKthaGEErdieSJgIkd;

				public readonly float HweParDwxxcsTfyepGGaAhkTWgF;

				public readonly int zGdbUshTycKAtYCpVcJXKunoKXo;

				public readonly int NvkUvSVhegrIiySWCTpxvOgoaTSa;

				public tQdmWIvYpLTtWCLOpumBTXPfGCC(int axisCount, int buttonCount, float dpadDeadzone, int vibrationMotorCount, int maxTouches)
				{
				}
			}

			public const bool NxiTYncgJCKPdSFDMzEERQuieof = true;

			private static int ucpRwVXBZbQgsGhKbOwcYGtApRI;

			protected readonly int qInCCRhldamcdoUHmMSlSCAIgFUz;

			protected readonly int QMUmjZykbifGzWsGXBcuZDqXGch;

			protected readonly bool KDDiayBbyUnoivkjIEsSEPzqrqa;

			protected readonly tQdmWIvYpLTtWCLOpumBTXPfGCC OgaPkhmfietDMGNMncaxtfOzABd;

			protected readonly int PwftjjvcgliCLJyonFqzuKQTKBiF;

			protected readonly float[] aYpEXMpeIlDrjPmxJHNTdCFZEre;

			private readonly LoggedInUser VvJaKBblAblboVBpsLwTwPFJZejV;

			protected readonly ControllerType qYQtZXCUUQiyGpzdDXLOHBOwcPe;

			private readonly Func<int, bool> OpXdpQccvLImWIXxHKgvuzfGsAmF;

			private readonly Action<int, int, int> vWhrNKOqEhrdskFUnMvMpauOGbqH;

			private readonly Action<int, int, int, int> sxZGfQdFVZIGlJwDoYJCEEKyBXvg;

			private readonly Action<int> ajZwKdHBxJwudVLhbNcxmfCHOOw;

			private Action<int, bool> HFgnOHnDYptVLvyQcpHRiGoTBMr;

			private Action<int, bool> HIbiqWlIcGkhhGMUmGLDpMMwdoO;

			private Action<int, bool> jKgyyjmaziMcrZEufFHDpNhyaqY;

			private Action<int> cycXMrdWdneDgzJsUeuLdmudHGdi;

			private Func<int, Vector3> USNpbppkhrGrUFwdnjvxnsyxTEnL;

			private Func<int, Vector3> IOIUuNmayTsgFrRAIYTLjONLpOv;

			private Func<int, Vector4> geVNoYXfjwWRPnRCRdakcgPddEn;

			private static int oUnPkmyGsXCbUrBRISmROqOzVyR
			{
				get
				{
					return default(int);
				}
			}

			protected LoggedInUser jFcgNPgLNoHPNaHdtdgwroqnnJh
			{
				get
				{
					return null;
				}
			}

			public ControllerType JmvHHQieRmxAYahCfvzgQBWHgSne
			{
				get
				{
					return default(ControllerType);
				}
			}

			public int yqGgGVbZkMCNTIxfuiHTVgIqHCJ
			{
				get
				{
					return default(int);
				}
			}

			public int UWBFQEfrTnYUCjshCYfdJplmoOOm
			{
				get
				{
					return default(int);
				}
			}

			public bool STsORkqoVwmWsWAMVLhuWNzKAJj
			{
				get
				{
					return default(bool);
				}
			}

			private bool BSWZxPQiWxBhGncxrWjXxmTWBcOd
			{
				get
				{
					return default(bool);
				}
			}

			public int zGdbUshTycKAtYCpVcJXKunoKXo
			{
				get
				{
					return default(int);
				}
			}

			public static meaDvZLdTStMzqDmUtkldoXVBFq AQMpZVIIXTyemnHtIDPtxhINdLN(ControllerType P_0, int P_1, int P_2)
			{
				return null;
			}

			public static meaDvZLdTStMzqDmUtkldoXVBFq AQMpZVIIXTyemnHtIDPtxhINdLN(bool P_0, int P_1, int P_2, int P_3)
			{
				return null;
			}

			protected meaDvZLdTStMzqDmUtkldoXVBFq(ControllerType type, string name, int playerId, int unityJoystickId, int handle, tQdmWIvYpLTtWCLOpumBTXPfGCC capabilities)
			{
			}

			public override void Update()
			{
			}

			public int GetUserId()
			{
				return default(int);
			}

			public int GetUserStatus()
			{
				return default(int);
			}

			public bool GetUserIsPrimary()
			{
				return default(bool);
			}

			public Color GetUserColor()
			{
				return default(Color);
			}

			public int GetUserColorId()
			{
				return default(int);
			}

			public string GetUserName()
			{
				return null;
			}

			public void StopVibration()
			{
			}

			public void SetVibration(int P_0, float P_1)
			{
			}

			public float GetVibration(int P_0)
			{
				return default(float);
			}

			public void SetMotionSensorState(bool P_0)
			{
			}

			public void SetTiltCorrectionState(bool P_0)
			{
			}

			public void SetAngularVelocityDeadbandState(bool P_0)
			{
			}

			public void ResetOrientation()
			{
			}

			public Vector3 GetLastAcceleration()
			{
				return default(Vector3);
			}

			public Vector3 GetLastAccelerationRaw()
			{
				return default(Vector3);
			}

			public Vector3 GetLastGyro()
			{
				return default(Vector3);
			}

			public Vector3 GetLastGyroRaw()
			{
				return default(Vector3);
			}

			public Quaternion GetLastOrientation()
			{
				return default(Quaternion);
			}

			public Quaternion GetLastOrientationRaw()
			{
				return default(Quaternion);
			}

			public void SetLightColor(int P_0, int P_1, int P_2)
			{
			}

			public void ResetLight()
			{
			}

			protected virtual void UpdateElementValues()
			{
			}

			protected void YIJmswKDRGGwbeMwDPctrpFlaCfB()
			{
			}

			protected static int EiFnhVyRTjWqpJdPQkRqjBgOfCtJ(float P_0)
			{
				return default(int);
			}

			protected static void wMNgJRrudGAWubGHyAWxyCZGiRK(ref Vector3 P_0)
			{
			}

			protected static void cXLjRmmfCEMdyWhIZBaghglIYrM(ref Vector3 P_0)
			{
			}

			protected static bool pPraApegcHjBgTMNFkMziqCEubU(int P_0, out ControllerType P_1)
			{
				return default(bool);
			}
		}

		private sealed class fEnDRSNGvhiPWyEueacdxsgliKZD : meaDvZLdTStMzqDmUtkldoXVBFq, IPS4ControllerExtensionSourceSixAxisSensor, IPS4ControllerExtensionSourceVibrator, IPS4ControllerExtensionSourceLight, IPS4ControllerExtensionSource, IPS4ControllerExtensionSourceTouchPad, IPS4GamepadExtensionSource
		{
			private const int mcagbMPDbZbuDLVSXAdSGosiwJk = 6;

			private const int yPnzCDCUouValTYijrIjZkOzBoi = 14;

			private const float swbSgarzlrGRoFvCfYeRBWtvXGW = 0.05f;

			private const int iKKGYPMEeUBIYTaUvEXNQCRNdYp = 2;

			private const int YTmtiWsooyXPPDNxOuSQfjMYCjb = 2;

			private int CLokCjmRDuGKgNijaGpGBWdmSwD;

			private int rfRbawqrmICYjFWUXzcXQqfCztB;

			private Vector2 DvbJPHrSfpygvvUdVrrkWlukaxg;

			private int aHlbeFwPGEHrjwMwhDSRkTHdGnMa;

			private Vector2 ZDjjIbbrIkFQcdXvzzJkZgNwNfa;

			private RdBLmZZaUnqkUJwfsSPLBCRwHRe IxfsoeEpAHVPWghijMaYjysTBpG;

			private int yRciSqJMnhbljRPfJxDJnVBAVbx;

			private int sUwfKsIesLcHCHQAWOjfiltLoSwN;

			private int kTaFgxgLQTpfdVsnOULhFfdGEWxW;

			private int DrloXsoVwXQnbYChKvNmoPFVFpD;

			private float JMVlDVdgZyMqASCdOEPeeqvpHqoE;

			public int NvkUvSVhegrIiySWCTpxvOgoaTSa
			{
				get
				{
					return default(int);
				}
			}

			public fEnDRSNGvhiPWyEueacdxsgliKZD(string name, int playerId, int unityJoystickId, int handle)
			{
			}

			public int GetConnectionType()
			{
				return default(int);
			}

			public int GetAnalogDeadZoneLeft()
			{
				return default(int);
			}

			public int GetAnalogDeadZoneRight()
			{
				return default(int);
			}

			public float GetTouchPixelDensity()
			{
				return default(float);
			}

			public int GetTouchpadResolutionX()
			{
				return default(int);
			}

			public int GetTouchpadResolutionY()
			{
				return default(int);
			}

			public int GetTouchCount()
			{
				return default(int);
			}

			public int GetTouchId(int P_0)
			{
				return default(int);
			}

			public bool GetTouchPositionAbsByIndex(int P_0, out Vector2 P_1)
			{
				return default(bool);
			}

			public bool GetTouchPositionAbsByTouchId(int P_0, out Vector2 P_1)
			{
				return default(bool);
			}

			public bool GetTouchPositionByIndex(int P_0, out Vector2 P_1)
			{
				return default(bool);
			}

			public bool GetTouchPositionByTouchId(int P_0, out Vector2 P_1)
			{
				return default(bool);
			}

			public bool IsTouchingByIndex(int P_0)
			{
				return default(bool);
			}

			public bool IsTouchingByTouchId(int P_0)
			{
				return default(bool);
			}

			protected override void UpdateElementValues()
			{
			}

			private void duLuRPLQXuawkWSRsiMYVvscyVg()
			{
			}

			private int UsLXGrvbyhupVWNLGtdNiZcXneC(int P_0)
			{
				return default(int);
			}
		}

		private abstract class CknYkuQcoBUbjagcoOrGtIdyKQI : meaDvZLdTStMzqDmUtkldoXVBFq
		{
			protected CknYkuQcoBUbjagcoOrGtIdyKQI(ControllerType controllerType, string name, int playerId, int unityJoystickId, int handle, tQdmWIvYpLTtWCLOpumBTXPfGCC capabilities)
			{
			}

			public static CknYkuQcoBUbjagcoOrGtIdyKQI AQMpZVIIXTyemnHtIDPtxhINdLN(int P_0, int P_1, int P_2)
			{
				return null;
			}

			public new static CknYkuQcoBUbjagcoOrGtIdyKQI AQMpZVIIXTyemnHtIDPtxhINdLN(ControllerType P_0, int P_1, int P_2)
			{
				return null;
			}
		}

		private sealed class YsLdaqHZYDISWmrMuFxZJmPjYif : CknYkuQcoBUbjagcoOrGtIdyKQI
		{
			private const int mcagbMPDbZbuDLVSXAdSGosiwJk = 13;

			private const int yPnzCDCUouValTYijrIjZkOzBoi = 14;

			private const float swbSgarzlrGRoFvCfYeRBWtvXGW = 0.05f;

			private const int iKKGYPMEeUBIYTaUvEXNQCRNdYp = 2;

			private const int YTmtiWsooyXPPDNxOuSQfjMYCjb = 0;

			public YsLdaqHZYDISWmrMuFxZJmPjYif(string name, int playerId, int unityJoystickId, int handle)
			{
			}

			protected override void UpdateElementValues()
			{
			}
		}

		private sealed class lWkOlHrPyWcPVJxrdRpstuTftvDD : CknYkuQcoBUbjagcoOrGtIdyKQI
		{
			private const int mcagbMPDbZbuDLVSXAdSGosiwJk = 11;

			private const int yPnzCDCUouValTYijrIjZkOzBoi = 14;

			private const float swbSgarzlrGRoFvCfYeRBWtvXGW = 0.05f;

			private const int iKKGYPMEeUBIYTaUvEXNQCRNdYp = 2;

			private const int YTmtiWsooyXPPDNxOuSQfjMYCjb = 0;

			public lWkOlHrPyWcPVJxrdRpstuTftvDD(string name, int playerId, int unityJoystickId, int handle)
			{
			}

			protected override void UpdateElementValues()
			{
			}
		}

		private sealed class rzNYMZYIQsNEVTaFRYgqLRGRoq : CknYkuQcoBUbjagcoOrGtIdyKQI
		{
			private const int mcagbMPDbZbuDLVSXAdSGosiwJk = 13;

			private const int yPnzCDCUouValTYijrIjZkOzBoi = 14;

			private const float swbSgarzlrGRoFvCfYeRBWtvXGW = 0.05f;

			private const int iKKGYPMEeUBIYTaUvEXNQCRNdYp = 2;

			private const int YTmtiWsooyXPPDNxOuSQfjMYCjb = 0;

			public rzNYMZYIQsNEVTaFRYgqLRGRoq(string name, int playerId, int unityJoystickId, int handle)
			{
			}

			protected override void UpdateElementValues()
			{
			}
		}

		private sealed class rCMtaRpoIOPIugppYzJiTIEyDeF : CknYkuQcoBUbjagcoOrGtIdyKQI
		{
			private const int mcagbMPDbZbuDLVSXAdSGosiwJk = 16;

			private const int yPnzCDCUouValTYijrIjZkOzBoi = 14;

			private const float swbSgarzlrGRoFvCfYeRBWtvXGW = 0.05f;

			private const int iKKGYPMEeUBIYTaUvEXNQCRNdYp = 2;

			private const int YTmtiWsooyXPPDNxOuSQfjMYCjb = 0;

			public rCMtaRpoIOPIugppYzJiTIEyDeF(string name, int playerId, int unityJoystickId, int handle)
			{
			}

			protected override void UpdateElementValues()
			{
			}
		}

		private bVdLitkJwIkMtgpGEhlltNcDAVtB KKgGBnvVPIHKLeoEiDFMVEWiQgg;

		private bool oNOIeYMKHAHgxzxbeCSiMiBWGly;

		private bool vEblpmllYIOuQHCXVghuIpihdSG;

		public override bool isReady
		{
			get
			{
				return default(bool);
			}
		}

		bool IControllerAssigner.enabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public override void Update()
		{
		}

		private static int rLVmTOqNErjHkWyUpBjrFOoWFIpH(int P_0)
		{
			return default(int);
		}

		private void GdRcCOFmVZAjFbwjBuCgYQywFWCa(bVdLitkJwIkMtgpGEhlltNcDAVtB.amDVRclcdlhHlNBNMFAuxkaDfvL P_0)
		{
		}

		private void tIwuLieLNiScUkipWTuUyLaZXHX(meaDvZLdTStMzqDmUtkldoXVBFq P_0)
		{
		}

		private void DzWNUjqlJPmrsXCgJElPACZumzA(bVdLitkJwIkMtgpGEhlltNcDAVtB.QUohiajXjNgRguTFzwsChJokNwo P_0)
		{
		}

		bool IControllerAssigner.CanHandleAssignment(ControllerType P_0, Rewired.Controller P_1)
		{
			return default(bool);
		}

		void IControllerAssigner.AssignController(ControllerType P_0, Rewired.Controller P_1)
		{
		}

		~PS4InputSource()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}
}
