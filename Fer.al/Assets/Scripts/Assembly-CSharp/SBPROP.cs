public class SBPROP
{
	private uint _id;

	private string _key;

	private object _value;

	private bool _newDef;

	public uint id
	{
		get
		{
			return default(uint);
		}
	}

	public string key
	{
		get
		{
			return null;
		}
	}

	public object value
	{
		get
		{
			return null;
		}
	}

	public bool NewDef
	{
		get
		{
			return default(bool);
		}
	}

	public SBPROP(uint id, string key, object value, bool newDef = false)
	{
	}

	public string toJson(bool onlyValuePair = false)
	{
		return null;
	}

	private string valueToJson()
	{
		return null;
	}
}
