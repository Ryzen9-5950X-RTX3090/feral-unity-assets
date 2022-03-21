using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_WorldMapQuestSubIcon : MonoBehaviour
{
	[SerializeField]
	private WWImage _iconImage;

	[SerializeField]
	private WWTextMeshProUGUI _text;

	private float _originalScale;

	internal WWImage iconImage
	{
		get
		{
			return null;
		}
	}

	internal WWTextMeshProUGUI text
	{
		get
		{
			return null;
		}
	}

	internal float originalScale
	{
		get
		{
			return default(float);
		}
	}

	private void Start()
	{
	}

	internal void Init(string inQuestName, Transform inParent, Vector3 inPosition, string inIconDefID)
	{
	}
}
