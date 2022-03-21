namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Multiplier
{
	internal class ValidityPreCompInfo : PreCompInfo
	{
		internal static readonly string PRECOMP_NAME;

		private bool failed;

		private bool curveEquationPassed;

		private bool orderPassed;

		internal bool HasFailed()
		{
			return default(bool);
		}

		internal void ReportFailed()
		{
		}

		internal bool HasCurveEquationPassed()
		{
			return default(bool);
		}

		internal void ReportCurveEquationPassed()
		{
		}

		internal bool HasOrderPassed()
		{
			return default(bool);
		}

		internal void ReportOrderPassed()
		{
		}
	}
}
