using System;
using System.Runtime.InteropServices;

namespace UnityEngine.Rendering
{
	public static class ColorUtils
	{
		public static float s_LightMeterCalibrationConstant;

		public static float s_LensAttenuation;

		public static float lensImperfectionExposureScale
		{
			get
			{
				return default(float);
			}
		}

		public static float StandardIlluminantY(float x)
		{
			return default(float);
		}

		public static Vector3 CIExyToLMS(float x, float y)
		{
			return default(Vector3);
		}

		public static Vector3 ColorBalanceToLMSCoeffs(float temperature, float tint)
		{
			return default(Vector3);
		}

		public static ValueTuple<Vector4, Vector4, Vector4> PrepareShadowsMidtonesHighlights([In] ref Vector4 inShadows, [In] ref Vector4 inMidtones, [In] ref Vector4 inHighlights)
		{
			return default(ValueTuple<Vector4, Vector4, Vector4>);
		}

		public static ValueTuple<Vector4, Vector4, Vector4> PrepareLiftGammaGain([In] ref Vector4 inLift, [In] ref Vector4 inGamma, [In] ref Vector4 inGain)
		{
			return default(ValueTuple<Vector4, Vector4, Vector4>);
		}

		public static ValueTuple<Vector4, Vector4> PrepareSplitToning([In] ref Vector4 inShadows, [In] ref Vector4 inHighlights, float balance)
		{
			return default(ValueTuple<Vector4, Vector4>);
		}

		public static float Luminance([In] ref Color color)
		{
			return default(float);
		}

		public static float ComputeEV100(float aperture, float shutterSpeed, float ISO)
		{
			return default(float);
		}

		public static float ConvertEV100ToExposure(float EV100)
		{
			return default(float);
		}

		public static float ConvertExposureToEV100(float exposure)
		{
			return default(float);
		}

		public static float ComputeEV100FromAvgLuminance(float avgLuminance)
		{
			return default(float);
		}

		public static float ComputeISO(float aperture, float shutterSpeed, float targetEV100)
		{
			return default(float);
		}

		public static uint ToHex(Color c)
		{
			return default(uint);
		}

		public static Color ToRGBA(uint hex)
		{
			return default(Color);
		}
	}
}
