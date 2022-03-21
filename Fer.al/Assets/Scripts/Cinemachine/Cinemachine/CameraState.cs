using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Cinemachine
{
	public struct CameraState
	{
		public enum BlendHintValue
		{
			Nothing = 0,
			NoPosition = 1,
			NoOrientation = 2,
			NoTransform = 3,
			SphericalPositionBlend = 4,
			CylindricalPositionBlend = 8,
			RadialAimBlend = 16,
			IgnoreLookAtTarget = 32,
			NoLens = 64
		}

		public struct CustomBlendable
		{
			public Object m_Custom;

			public float m_Weight;

			public CustomBlendable(Object custom, float weight)
			{
			}
		}

		public static Vector3 kNoPoint;

		private CustomBlendable mCustom0;

		private CustomBlendable mCustom1;

		private CustomBlendable mCustom2;

		private CustomBlendable mCustom3;

		private List<CustomBlendable> m_CustomOverflow;

		public LensSettings Lens
		{
			[IsReadOnly]
			[CompilerGenerated]
			get
			{
				return default(LensSettings);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 ReferenceUp
		{
			[CompilerGenerated]
			[IsReadOnly]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 ReferenceLookAt
		{
			[IsReadOnly]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool HasLookAt
		{
			get
			{
				return default(bool);
			}
		}

		public Vector3 RawPosition
		{
			[IsReadOnly]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Quaternion RawOrientation
		{
			[IsReadOnly]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 PositionDampingBypass
		{
			[IsReadOnly]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float ShotQuality
		{
			[IsReadOnly]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 PositionCorrection
		{
			[IsReadOnly]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Quaternion OrientationCorrection
		{
			[IsReadOnly]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 CorrectedPosition
		{
			get
			{
				return default(Vector3);
			}
		}

		public Quaternion CorrectedOrientation
		{
			get
			{
				return default(Quaternion);
			}
		}

		public Vector3 FinalPosition
		{
			get
			{
				return default(Vector3);
			}
		}

		public Quaternion FinalOrientation
		{
			get
			{
				return default(Quaternion);
			}
		}

		public BlendHintValue BlendHint
		{
			[CompilerGenerated]
			[IsReadOnly]
			get
			{
				return default(BlendHintValue);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static CameraState Default
		{
			get
			{
				return default(CameraState);
			}
		}

		public int NumCustomBlendables
		{
			[IsReadOnly]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CustomBlendable GetCustomBlendable(int index)
		{
			return default(CustomBlendable);
		}

		private int FindCustomBlendable(Object custom)
		{
			return default(int);
		}

		public void AddCustomBlendable(CustomBlendable b)
		{
		}

		public static CameraState Lerp(CameraState stateA, CameraState stateB, float t)
		{
			return default(CameraState);
		}

		private static float InterpolateFOV(float fovA, float fovB, float dA, float dB, float t)
		{
			return default(float);
		}

		private static Vector3 ApplyPosBlendHint(Vector3 posA, BlendHintValue hintA, Vector3 posB, BlendHintValue hintB, Vector3 original, Vector3 blended)
		{
			return default(Vector3);
		}

		private static Quaternion ApplyRotBlendHint(Quaternion rotA, BlendHintValue hintA, Quaternion rotB, BlendHintValue hintB, Quaternion original, Quaternion blended)
		{
			return default(Quaternion);
		}

		private Vector3 InterpolatePosition(Vector3 posA, Vector3 pivotA, Vector3 posB, Vector3 pivotB, float t)
		{
			return default(Vector3);
		}
	}
}
