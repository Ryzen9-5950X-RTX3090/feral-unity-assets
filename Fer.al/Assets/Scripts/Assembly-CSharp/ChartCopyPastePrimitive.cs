using System;

[Serializable]
public class ChartCopyPastePrimitive
{
	public string stringValue;

	public int intValue;

	public float floatValue;

	public string jsonValue;

	public ChartCopyPastePrimitive()
	{
	}

	public ChartCopyPastePrimitive(object inValue)
	{
	}

	public string ToJSON()
	{
		return null;
	}

	public void SetValue(object inValue)
	{
	}

	public object GetValue(Type inType)
	{
		return null;
	}
}
