namespace FMOD.Studio
{
	public struct USER_PROPERTY
	{
		public StringWrapper name;

		public USER_PROPERTY_TYPE type;

		private Union_IntBoolFloatString value;

		public int intValue()
		{
			return default(int);
		}

		public bool boolValue()
		{
			return default(bool);
		}

		public float floatValue()
		{
			return default(float);
		}

		public string stringValue()
		{
			return null;
		}
	}
}
