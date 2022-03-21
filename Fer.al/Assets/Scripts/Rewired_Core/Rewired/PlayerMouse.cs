using System;
using System.Runtime.CompilerServices;
using Rewired.UI;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	public sealed class PlayerMouse : PlayerController, IPlayerController, IPlayerMouse, IMouseInputSource
	{
		public new sealed class Definition : PlayerController.Definition
		{
			public bool defaultToCenter;

			public ScreenRect movementArea;

			public MovementAreaUnit movementAreaUnit;

			public float pointerSpeed;

			public bool useHardwarePointerPosition;

			internal Definition()
			{
			}
		}

		public new static class Factory
		{
			public static PlayerMouse Create()
			{
				return null;
			}

			private static PlayerMouse AQMpZVIIXTyemnHtIDPtxhINdLN(int P_0, int P_1)
			{
				return null;
			}

			public static PlayerMouse Create(Definition definition)
			{
				return null;
			}
		}

		public enum MovementAreaUnit
		{
			Screen,
			Pixel
		}

		internal const bool HQEdndDaFwIwGalojhdRtrhDpwew = true;

		internal const float pWzyrjXxGEoDGbEWiLORWqktbuQ = 1f;

		internal const bool wKCyDIeaoKvbOGmyrUKZlOBsebj = true;

		internal const MovementAreaUnit WMQxPvlljeuHsJVjfTqwcggfryg = MovementAreaUnit.Screen;

		private const int jZRthwHNmPbGwjLfWJZtBeZgLcAa = 3;

		private const int dnsJJLjtGEVHrnAXHDHcEiatluew = 3;

		internal const string bhrRVluoFFIpaqucZecGDEQQySt = "Movement";

		internal const string CpQDulgkhglxvQGxytDeoJxDBbFb = "Horizontal";

		internal const string hGlAHideXxDeMONVqVIAsoSniHjP = "Vertical";

		internal const string xyuMaMvxrWOlZIbqeLzbnhtWyyE = "Wheel";

		internal const string SfMzeGrsYrlcsDSoybYRPAtuJfR = "Wheel Horizontal";

		internal const string ZYbhVRtTAAryygNrIrIOWSCBllJ = "Wheel Vertical";

		internal const string ITrObforPxvmdtnlnHeKuAHPPuB = "Left Button";

		internal const string LMhdOeIljkXnmhuqCNUGPMGQfIkI = "Right Button";

		internal const string nHahgWkwqniHjsNcPotUXpLPrwD = "Middle Button";

		internal static readonly ScreenRect CTmjDrxvDtpliYHLnxhgZrUIkdX;

		private readonly int WJHPpBMvjifwgdCoZMTifXYYins;

		private readonly int kFzMbawTeCKeFcOAxCsUgNskFXS;

		private readonly int AnYAQApbJsgIGrVrdhgQPaoGhDm;

		private readonly int OZXAqZwYQEVqlVygkBCwCKwrMGI;

		private readonly int gGoElrTpWpgCznJFJCvftSLJtVr;

		private readonly int zXEcRXvvoWZQtqNVTzlzbjEcRvf;

		private bool WdeyosbkusXcbkNfnWGHmcggbVO;

		private Vector2 HDQaAcmEDoIpLHXMJBUfBpvFZxyA;

		private Vector2 SUWxlKNudhJjradzfyjDmkAgCsQH;

		private Vector2 sTSVgVPBgmimeOUJBMVVVRlUnxR;

		private Vector2 apLCgPXpLiavDogCoiNohrBseCu;

		private Vector2 fzJUoNcFXEknrIcSVeTwCEFdGml;

		private float nZkDILCzWFjEgabZDFOJIIVOfTd;

		private bool cEcHVWQCGOFtUbnEesWwTHElauLz;

		private Action<Vector2> SuEjtWTYBYowuCfRQmgbIzLWlmm;

		private bool PZJqsbAzxtNrotnsYzFzlPBGoDm;

		private ScreenRect MHGNrqcfsqIPlQQZabtbWvefCkr;

		private MovementAreaUnit tRtjTqdAqNYMUnesxaCAhoAikrt;

		[CompilerGenerated]
		private static Predicate<Axis> rMADKvwwlBDxGizQaeqoBdFZwld;

		[CompilerGenerated]
		private static Predicate<Axis> JTCXEGDxEOeUKhqiWcgWTpItzfs;

		public bool defaultToCenter
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public ScreenRect movementArea
		{
			get
			{
				return default(ScreenRect);
			}
			set
			{
			}
		}

		public MovementAreaUnit movementAreaUnit
		{
			get
			{
				return default(MovementAreaUnit);
			}
			set
			{
			}
		}

		public Vector2 screenPosition
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 screenPositionPrev
		{
			get
			{
				return default(Vector2);
			}
		}

		public Vector2 screenPositionDelta
		{
			get
			{
				return default(Vector2);
			}
		}

		public MouseAxis xAxis
		{
			get
			{
				return null;
			}
		}

		public MouseAxis yAxis
		{
			get
			{
				return null;
			}
		}

		public MouseWheel wheel
		{
			get
			{
				return null;
			}
		}

		public Button leftButton
		{
			get
			{
				return null;
			}
		}

		public Button rightButton
		{
			get
			{
				return null;
			}
		}

		public Button middleButton
		{
			get
			{
				return null;
			}
		}

		public float pointerSpeed
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool useHardwarePointerPosition
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		bool IMouseInputSource.enabled
		{
			get
			{
				return default(bool);
			}
		}

		Vector2 IMouseInputSource.screenPosition
		{
			get
			{
				return default(Vector2);
			}
		}

		Vector2 IMouseInputSource.screenPositionDelta
		{
			get
			{
				return default(Vector2);
			}
		}

		Vector2 IMouseInputSource.wheelDelta
		{
			get
			{
				return default(Vector2);
			}
		}

		bool IMouseInputSource.locked
		{
			get
			{
				return default(bool);
			}
		}

		public event Action<Vector2> ScreenPositionChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private PlayerMouse(Definition definition)
		{
		}

		protected override bool Update(UpdateLoopType updateLoop)
		{
			return default(bool);
		}

		protected override void UpdateFinished()
		{
		}

		protected override void ClearVars()
		{
		}

		private void MISqOAxSrCshFXkTwEtcahOKdPm(Vector2 P_0)
		{
		}

		private ScreenRect iljzZlGLmAUOKxDsrxjuTuLThZm()
		{
			return default(ScreenRect);
		}

		private void eJVoVTHkzmqGaCNyrmZYueWcdOR()
		{
		}

		private static float BNJbCEbFMkcPsirKMpDxWXzXNbF(Axis P_0, float P_1, float P_2)
		{
			return default(float);
		}

		bool IMouseInputSource.GetButtonDown(int P_0)
		{
			return default(bool);
		}

		bool IMouseInputSource.GetButtonUp(int P_0)
		{
			return default(bool);
		}

		bool IMouseInputSource.GetButton(int P_0)
		{
			return default(bool);
		}

		[CompilerGenerated]
		private static bool QCnBhbrcMfEzZgtusefqogRXgSm(Axis P_0)
		{
			return default(bool);
		}

		[CompilerGenerated]
		private static bool duLhsEnrjkGDDwuCgfSCCWjnKgSn(Axis P_0)
		{
			return default(bool);
		}
	}
}
