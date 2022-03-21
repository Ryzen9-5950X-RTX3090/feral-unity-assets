using System;
using UnityEngine;

public class GlobalChartRefEnabler : ManagedBehaviour
{
	public enum EDataType
	{
		BOOL,
		FLOAT,
		STRING,
		INT
	}

	public enum EComparisons
	{
		EQUAL,
		NOTEQUAL,
		GREATERTHAN,
		GREATERTHANOREQUALTO,
		LESSERTHAN,
		LESSERTHANOREQUALTO
	}

	public enum EAndOr
	{
		AND,
		OR
	}

	[Serializable]
	public class Argument
	{
		[Header("Data Type")]
		public EDataType dataType;

		[Header("Bool")]
		public EComparisons boolCompare;

		public bool boolToCheck;

		[Header("Float")]
		public EComparisons floatCompare;

		public float floatToCheck;

		[Header("String")]
		public EComparisons stringCompare;

		public string stringToCheck;

		[Header("Int")]
		public EComparisons intCompare;

		public int intToCheck;
	}

	[SerializeField]
	[Header("Chart")]
	private GlobalChartRef _globalChartRef;

	[SerializeField]
	[Header("Arguments")]
	private Argument[] _arguments;

	[SerializeField]
	private EAndOr _andOr;

	[SerializeField]
	[Header("GameObjects to Enable")]
	private GameObject[] enabledOnAvailable;

	[SerializeField]
	private GameObject[] enabledOnUnAvailable;

	public override void MStart()
	{
	}

	private bool Compare(Argument inArgument)
	{
		return default(bool);
	}

	private bool BoolCompare(Argument inArgument)
	{
		return default(bool);
	}

	private bool StringCompare(Argument inArgument)
	{
		return default(bool);
	}

	private bool FloatCompare(Argument inArgument)
	{
		return default(bool);
	}

	private bool IntCompare(Argument inArgument)
	{
		return default(bool);
	}
}
