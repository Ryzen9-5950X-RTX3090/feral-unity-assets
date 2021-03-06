using System.Collections.Generic;

namespace Newtonsoft.Json.Bson
{
	internal class BsonObject : BsonToken
	{
		private readonly List<BsonProperty> _children;

		public override BsonType Type
		{
			get
			{
				return default(BsonType);
			}
		}

		public void Add(string name, BsonToken token)
		{
		}
	}
}
