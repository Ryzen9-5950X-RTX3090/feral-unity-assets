using System.Collections.Generic;
using ThisOtherThing.UI.Shapes;
using UnityEngine;

public class UI_WorldMapQuestSubIcons : MonoBehaviour
{
	[SerializeField]
	private Rectangle rectangle;

	[SerializeField]
	private GameObject _worldMapQuestSubIcon;

	[SerializeField]
	private Transform _subIconLocator;

	[SerializeField]
	private float _distanceBetweenSubIcons;

	[SerializeField]
	private float _overlayScalingValue;

	private List<UI_WorldMapQuestSubIcon> worldMapQuestSubIcons;

	private float _originalRectangleScale;

	private float _originalScale;

	internal float originalScale
	{
		get
		{
			return default(float);
		}
	}

	private void Awake()
	{
	}

	internal void AddIcon(string inQuestName, string inIconDefID)
	{
	}

	internal void CalculatePositions()
	{
	}
}
