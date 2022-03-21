using System;
using UnityEngine;

public class BuildersFollyResource : ScriptableObject
{
	public enum EResourceOption
	{
		_1,
		_2,
		_3
	}

	public enum EResourceColor
	{
		White,
		Red,
		Blue,
		Green,
		Yellow,
		Mixed
	}

	public Sprite resourceImage;

	[RootSelector("Resource Name", "LocalizationChartData", false, false)]
	public string Resource_Name;

	[RootSelector("Resource Description", "LocalizationChartData", false, false)]
	public string Resource_Description;

	public BuildersFollyData.EStationType requiredStation;

	[Header("Base Resources Only")]
	public GameObject tilePrefab;

	[NonSerialized]
	internal EResourceColor resourceColor;

	public EResourceOption resourceOption;

	public BuildersFollyResource[] input;

	public bool canBeDyed;

	internal string ResourceName
	{
		get
		{
			return null;
		}
	}
}
