namespace Newtonsoft.Json.Bson
{
	internal class BsonValue : BsonToken
	{
		private readonly object _value;

		private readonly BsonType _type;

		public override BsonType Type
		{
			get
			{
				return default(BsonType);
			}
		}

		public BsonValue(object value, BsonType type)
		{
		}
	}
}
