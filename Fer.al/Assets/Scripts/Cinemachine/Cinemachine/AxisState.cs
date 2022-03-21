using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace Cinemachine
{
	[Serializable]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public struct AxisState
	{
		public enum SpeedMode
		{
			MaxSpeed,
			InputValueGain
		}

		public interface IInputAxisProvider
		{
			float GetAxisValue(int axis);
		}

		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct Recentering
		{
			[Tooltip("If checked, will enable automatic recentering of the axis. If unchecked, recenting is disabled.")]
			public bool m_enabled;

			[Tooltip("If no user input has been detected on the axis, the axis will wait this long in seconds before recentering.")]
			public float m_WaitTime;

			[Tooltip("How long it takes to reach destination once recentering has started.")]
			public float m_RecenteringTime;

			private float mLastAxisInputTime;

			private float mRecenteringVelocity;

			[HideInInspector]
			[SerializeField]
			[FormerlySerializedAs("m_HeadingDefinition")]
			private int m_LegacyHeadingDefinition;

			[SerializeField]
			[HideInInspector]
			[FormerlySerializedAs("m_VelocityFilterStrength")]
			private int m_LegacyVelocityFilterStrength;

			public Recentering(bool enabled, float waitTime, float recenteringTime)
			{
			}

			public void Validate()
			{
			}

			public void CancelRecentering()
			{
			}

			public void DoRecentering(ref AxisState axis, float deltaTime, float recenterTarget)
			{
			}

			internal bool LegacyUpgrade(ref int heading, ref int velocityFilter)
			{
				return default(bool);
			}
		}

		[NoSaveDuringPlay]
		[Tooltip("The current value of the axis.")]
		public float Value;

		[Tooltip("How to interpret the Max Speed setting: in units/second, or as a direct input value multiplier")]
		public SpeedMode m_SpeedMode;

		[Tooltip("The maximum speed of this axis in units/second, or the input value multiplier, depending on the Speed Mode")]
		public float m_MaxSpeed;

		[Tooltip("The amount of time in seconds it takes to accelerate to MaxSpeed with the supplied Axis at its maximum value")]
		public float m_AccelTime;

		[Tooltip("The amount of time in seconds it takes to decelerate the axis to zero if the supplied axis is in a neutral position")]
		public float m_DecelTime;

		[FormerlySerializedAs("m_AxisName")]
		[Tooltip("The name of this axis as specified in Unity Input manager. Setting to an empty string will disable the automatic updating of this axis")]
		public string m_InputAxisName;

		[NoSaveDuringPlay]
		[Tooltip("The value of the input axis.  A value of 0 means no input.  You can drive this directly from a custom input system, or you can set the Axis Name and have the value driven by the internal Input Manager")]
		public float m_InputAxisValue;

		[FormerlySerializedAs("m_InvertAxis")]
		[Tooltip("If checked, then the raw value of the input axis will be inverted before it is used")]
		public bool m_InvertInput;

		[Tooltip("The minimum value for the axis")]
		public float m_MinValue;

		[Tooltip("The maximum value for the axis")]
		public float m_MaxValue;

		[Tooltip("If checked, then the axis will wrap around at the min/max values, forming a loop")]
		public bool m_Wrap;

		[Tooltip("Automatic recentering to at-rest position")]
		public Recentering m_Recentering;

		private float mCurrentSpeed;

		private const float Epsilon = 0.0001f;

		private IInputAxisProvider m_InputAxisProvider;

		private int m_InputAxisIndex;

		public bool ValueRangeLocked
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public bool HasRecentering
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public AxisState(float minValue, float maxValue, bool wrap, bool rangeLocked, float maxSpeed, float accelTime, float decelTime, string name, bool invert)
		{
		}

		public void Validate()
		{
		}

		public void Reset()
		{
		}

		public void SetInputAxisProvider(int axis, IInputAxisProvider provider)
		{
		}

		public bool Update(float deltaTime)
		{
			return default(bool);
		}

		private float ClampValue(float v)
		{
			return default(float);
		}

		private bool MaxSpeedUpdate(float input, float deltaTime)
		{
			return default(bool);
		}

		private float GetMaxSpeed()
		{
			return default(float);
		}
	}
}
