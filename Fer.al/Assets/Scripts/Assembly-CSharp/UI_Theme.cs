using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class UI_Theme : ScriptableObject
{
	[SerializeField]
	private List<UI_ImageThemeData> _imageThemeData;

	[SerializeField]
	private List<UI_TextThemeData> _textThemeData;

	[SerializeField]
	private List<UI_ButtonThemeData> _buttonThemeData;

	public List<UI_ImageThemeData> ImageThemeData
	{
		get
		{
			return null;
		}
	}

	public List<UI_TextThemeData> TextThemeData
	{
		get
		{
			return null;
		}
	}

	public List<UI_ButtonThemeData> ButtonThemeData
	{
		get
		{
			return null;
		}
	}

	public UI_ImageThemeData GetImageThemeData(string inId)
	{
		return null;
	}

	public UI_TextThemeData GetTextThemeData(string inId)
	{
		return null;
	}

	public UI_ButtonThemeData GetButtonThemeData(string inId)
	{
		return null;
	}
}
