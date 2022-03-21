using System;
using System.Collections.Generic;
using LitJson;

public class BaseDef : ParsableDefBase
{
	[Serializable]
	public class ChartSerializedJSONComponent
	{
		public string componentClass;

		public string componentJSON;

		public bool componentIsCustom;
	}

	[Serializable]
	public class ChartSerializedJSON
	{
		public string templateClass;

		public string templateFormatHash;

		public List<ChartSerializedJSONComponent> components;
	}

	public static class Constructor
	{
		public static Delegate Compile(Type delegateType, Type instanceType)
		{
			return null;
		}

		public static TDelegate Compile<TDelegate>(Type instanceType)
		{
			return (TDelegate)null;
		}
	}

	[NonSerialized]
	public string defName;

	[NonSerialized]
	public string lowerDefName;

	[NonSerialized]
	public string defID;

	[NonSerialized]
	public Type templateType;

	private static Dictionary<string, ChartDataObject> _defIDToChartName;

	private static Dictionary<string, List<string>> _templateToDefIDs;

	private static Dictionary<string, Func<DefComponent>> _defComponentConstructorDict;

	private ComponentContainer _components;

	private static Dictionary<string, ChartDataObject> DefIDToChart
	{
		get
		{
			return null;
		}
	}

	private static Dictionary<string, List<string>> TemplateToDefIDs
	{
		get
		{
			return null;
		}
	}

	public virtual Type ChartType
	{
		get
		{
			return null;
		}
	}

	public static void ClearDefCache()
	{
	}

	public static BaseDef GetDef(string inDefID, bool inShowErrors = false)
	{
		return null;
	}

	public static List<string> GetAllDefIDsWithTemplate<T>()
	{
		return null;
	}

	public static List<BaseDef> GetAllDefsWithTemplate<T>()
	{
		return null;
	}

	public static T GetDefComponent<T>(string inDefID, bool inShowErrors = false) where T : DefComponent
	{
		return null;
	}

	public static List<BaseDef> GetDefs(List<string> inDefIDs, bool inShowErrors = false)
	{
		return null;
	}

	public static List<T> GetDefComponents<T>(List<string> inDefIDs, bool inShowErrors = false) where T : DefComponent
	{
		return null;
	}

	public override void LoadEntry()
	{
	}

	public override void LoadComponents()
	{
	}

	public override void OnLoaded()
	{
	}

	public static DefComponent ConstructDefComponent(string inTypeName)
	{
		return null;
	}

	public void LoadDataJSON(string inJSON)
	{
	}

	public static bool isValidDefID(string inDefID)
	{
		return default(bool);
	}

	public static bool IsValidBundleID(string inBundleID)
	{
		return default(bool);
	}

	public override bool Equals(object obj)
	{
		return default(bool);
	}

	public static bool operator ==(BaseDef a, BaseDef b)
	{
		return default(bool);
	}

	public static bool operator !=(BaseDef a, BaseDef b)
	{
		return default(bool);
	}

	public override int GetHashCode()
	{
		return default(int);
	}

	public override string ToString()
	{
		return null;
	}

	public static BaseDef FromJson(JsonData data)
	{
		return null;
	}

	public bool HasComponent<T>() where T : DefComponent
	{
		return default(bool);
	}

	public T GetComponent<T>() where T : DefComponent
	{
		return null;
	}

	public T AddComponent<T>() where T : DefComponent
	{
		return null;
	}

	public T AddComponent<T>(T inDefComponent) where T : DefComponent
	{
		return null;
	}

	public T AddComponentByTypeof<T>(T inDefComponent) where T : DefComponent
	{
		return null;
	}

	public void RemoveComponent<T>() where T : DefComponent
	{
	}

	public void ForeachComponent<T>(Action<T> action) where T : class
	{
	}
}
