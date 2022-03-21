using System.Collections.Generic;
using TMPro;
using Unitilities.Tuples;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class UI_Themer : ScriptableObject
{
	private static UI_Themer _instance;

	[SerializeField]
	private int _currentThemeIndex;

	[SerializeField]
	private List<UI_Theme> _themes;

	[SerializeField]
	private List<StringTuple> _imgManifest;

	[SerializeField]
	private List<StringTuple> _txtManifest;

	[SerializeField]
	private List<StringTuple> _btnManifest;

	public static UI_Themer instance
	{
		get
		{
			return null;
		}
	}

	private UI_Theme CurrentTheme
	{
		get
		{
			return null;
		}
	}

	public void SetTheme(int inThemeIndex)
	{
	}

	private void Init()
	{
	}

	public List<StringTuple> GetImageDataOptions()
	{
		return null;
	}

	public UI_ImageThemeData GetImageThemeData(string inId)
	{
		return null;
	}

	public bool UpdateImageThemeDataFromSrc(string inId, string inName, WWImage inSrc)
	{
		return default(bool);
	}

	public bool AddImageThemeDataFromSrc(string inName, WWImage inSrc)
	{
		return default(bool);
	}

	public List<StringTuple> GetTextDataOptions()
	{
		return null;
	}

	public UI_TextThemeData GetTextThemeData(string inId)
	{
		return null;
	}

	public bool UpdateTextThemeDataFromSrc(string inId, string inName, WWTextMeshProUGUI inSrc, bool inIgnoreSizeSettings)
	{
		return default(bool);
	}

	public bool AddTextThemeDataFromSrc(string inName, WWTextMeshProUGUI inSrc)
	{
		return default(bool);
	}

	public List<StringTuple> GetButtonDataOptions()
	{
		return null;
	}

	public UI_ButtonThemeData GetButtonThemeData(string inId)
	{
		return null;
	}

	public bool UpdateButtonThemeDataFromSrc(string inId, string inName, WWButton inSrc)
	{
		return default(bool);
	}

	public bool AddButtonThemeDataFromSrc(string inName, WWButton inSrc)
	{
		return default(bool);
	}

	public void SyncThemeContentsWithManifests()
	{
	}

	public void ReportChangedTheme()
	{
	}
}
