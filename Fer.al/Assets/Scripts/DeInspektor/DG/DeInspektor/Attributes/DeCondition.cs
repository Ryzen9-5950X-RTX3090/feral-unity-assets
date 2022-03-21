namespace DG.DeInspektor.Attributes
{
	public struct DeCondition
	{
		internal string propertyToCompare;

		internal bool boolValue;

		internal string stringValue;

		internal float numValue;

		internal Condition conditionType;

		public DeCondition(string propertyToCompare, bool value)
		{
		}

		public DeCondition(string propertyToCompare, int value, Condition conditionType = Condition.Is)
		{
		}

		public DeCondition(string propertyToCompare, Condition conditionType = Condition.IsNotNullOrEmpty)
		{
		}
	}
}
