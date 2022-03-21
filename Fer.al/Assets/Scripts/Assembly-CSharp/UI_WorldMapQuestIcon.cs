using UnityEngine;
using UnityEngine.UI;

public class UI_WorldMapQuestIcon : MonoBehaviour
{
	[SerializeField]
	private WWImage _iconImage;

	[SerializeField]
	private UI_Tooltip _tooltip;

	private float _originalScale;

	internal float originalScale
	{
		get
		{
			return default(float);
		}
	}

	internal WWImage iconImage
	{
		get
		{
			return null;
		}
	}

	internal UI_Tooltip tooltip
	{
		get
		{
			return null;
		}
	}

	private void Start()
	{
	}
}
