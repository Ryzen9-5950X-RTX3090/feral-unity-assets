using System.Collections.Generic;
using System.Reflection;

namespace Newtonsoft.Json.Linq
{
	[DefaultMember("Item")]
	public class JConstructor : JContainer
	{
		private string _name;

		private readonly List<JToken> _values;

		protected override IList<JToken> ChildrenTokens
		{
			get
			{
				return null;
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
		}

		public override JTokenType Type
		{
			get
			{
				return default(JTokenType);
			}
		}

		internal override int IndexOfItem(JToken item)
		{
			return default(int);
		}

		public JConstructor(JConstructor other)
		{
		}

		public JConstructor(string name)
		{
		}

		internal override JToken CloneToken()
		{
			return null;
		}

		public override void WriteTo(JsonWriter writer, JsonConverter[] converters)
		{
		}

		public static JConstructor Load(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}
	}
}
