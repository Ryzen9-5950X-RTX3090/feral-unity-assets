namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC
{
	public abstract class AbstractF2mFieldElement : ECFieldElement
	{
		public virtual bool HasFastTrace
		{
			get
			{
				return default(bool);
			}
		}

		public virtual ECFieldElement HalfTrace()
		{
			return null;
		}

		public virtual int Trace()
		{
			return default(int);
		}
	}
}
