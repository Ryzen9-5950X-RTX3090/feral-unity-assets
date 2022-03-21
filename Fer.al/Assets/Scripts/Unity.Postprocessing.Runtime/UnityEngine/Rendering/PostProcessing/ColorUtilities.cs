namespace UnityEngine.Rendering.PostProcessing
{
	public static class ColorUtilities
	{
		private const float logC_cut = 0.011361f;

		private const float logC_a = 5.555556f;

		private const float logC_b = 0.047996f;

		private const float logC_c = 0.244161f;

		private const float logC_d = 0.386036f;

		private const float logC_e = 5.301883f;

		private const float logC_f = 0.092819f;

		public static float StandardIlluminantY(float x)
		{
			return default(float);
		}

		public static Vector3 CIExyToLMS(float x, float y)
		{
			return default(Vector3);
		}

		public static Vector3 ComputeColorBalance(float temperature, float tint)
		{
			return default(Vector3);
		}

		public static Vector3 ColorToLift(Vector4 color)
		{
			return default(Vector3);
		}

		public static Vector3 ColorToInverseGamma(Vector4 color)
		{
			return default(Vector3);
		}

		public static Vector3 ColorToGain(Vector4 color)
		{
			return default(Vector3);
		}

		public static float LogCToLinear(float x)
		{
			return default(float);
		}

		public static float LinearToLogC(float x)
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
