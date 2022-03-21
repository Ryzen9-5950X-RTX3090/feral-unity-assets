using System;
using UnityEngine;

namespace Cinemachine
{
	[Serializable]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public struct CinemachineBlendDefinition
	{
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum Style
		{
			Cut,
			EaseInOut,
			EaseIn,
			EaseOut,
			HardIn,
			HardOut,
			Linear,
			Custom
		}

		[Tooltip("Shape of the blend curve")]
		public Style m_Style;

		[Tooltip("Duration of the blend, in seconds")]
		public float m_Time;

		public AnimationCurve m_CustomCurve;

		private static AnimationCurve[] sStandardCurves;

		public float BlendTime
		{
			get
			{
				return default(float);
			}
		}

		public AnimationCurve BlendCurve
		{
			get
			{
				return null;
			}
		}

		public CinemachineBlendDefinition(Style style, float time)
		{
		}

		private void CreateStandardCurves()
		{
		}
	}
}
