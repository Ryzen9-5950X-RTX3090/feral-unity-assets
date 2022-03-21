using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

[Serializable]
public class ParsableDefBase
{
	[NonSerialized]
	public string parentChartName;

	[NonSerialized]
	public Dictionary<string, string> headerNameToDataDict;

	[NonSerialized]
	public float lastAccessTime;

	public virtual void Load()
	{
	}

	public virtual void LoadEntry()
	{
	}

	public virtual void LoadComponents()
	{
	}

	public virtual void OnLoaded()
	{
	}

	public T LoadEnum<T>(string inCategory, int inDefaultValue = 0) where T : struct
	{
		return (T)null;
	}

	public T LoadJSON<T>(string inCategory, bool inCanReturnNull = false) where T : new()
	{
		return (T)null;
	}

	public void LoadJSONOverwrite<T>(string inCategory, T inTargetObject) where T : new()
	{
	}

	public string LoadString(string inCategory, string defaultValue = "Missing")
	{
		return null;
	}

	public long LoadDate(string inCategory)
	{
		return default(long);
	}

	public DateTime LoadDateTime(string inCategory)
	{
		return default(DateTime);
	}

	public List<ValueTuple<string, int>> LoadTupleListInt(string inCategory)
	{
		return null;
	}

	public List<ValueTuple<string, string>> LoadTupleListString(string inCategory)
	{
		return null;
	}

	private List<ValueTuple<string, T>> LoadTupleList<T>(string inCategory, Func<string, T> inParseFunc)
	{
		return null;
	}

	public LazyDef<T> LoadLazyDef<T, U>(string inCategory) where T : BaseDef where U : ChartDataObject
	{
		return null;
	}

	public LazyDefList<T> LoadLazyDefList<T, U>(string inCategory) where T : BaseDef where U : ChartDataObject
	{
		return null;
	}

	public List<string> LoadStringList(string inCategory, bool isDynamic = false)
	{
		return null;
	}

	public List<string> LoadStringList(string inCategory, char inSeperator, bool isDynamic = false)
	{
		return null;
	}

	public List<T> LoadGenericDefList<T>(string inChartName, string inCategory) where T : BaseDef
	{
		return null;
	}

	public T LoadGenericDef<T, U>(string inCategory) where T : BaseDef where U : ChartDataObject
	{
		return null;
	}

	public List<T> LoadGenericDefList<T, U>(string inCategory) where T : BaseDef where U : ChartDataObject
	{
		return null;
	}

	public List<T> LoadGenericDynamicDefList<T>(string inCategory) where T : BaseDef
	{
		return null;
	}

	public List<List<string>> LoadColorRefList(string inCategory)
	{
		return null;
	}

	public Color LoadColor(string inCategory)
	{
		return default(Color);
	}

	public Color LoadColorAsString(string inString)
	{
		return default(Color);
	}

	public Vector2 LoadVector2(string inCategory)
	{
		return default(Vector2);
	}

	public Vector3 LoadVector3(string inCategory)
	{
		return default(Vector3);
	}

	public float LoadFloat(string inCategory, [Optional] float? inDefault)
	{
		return default(float);
	}

	public int LoadInt(string inCategory)
	{
		return default(int);
	}

	public long LoadLong(string inCategory)
	{
		return default(long);
	}

	public bool LoadBool(string inCategory, bool inDefault = false)
	{
		return default(bool);
	}
}
