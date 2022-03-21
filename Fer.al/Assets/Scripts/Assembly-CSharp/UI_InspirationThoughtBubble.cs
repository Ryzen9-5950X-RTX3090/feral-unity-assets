using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_InspirationThoughtBubble : MonoBehaviour
{
	private class ThoughtBubbleItem
	{
		private RawImage _iconImage;

		private CanvasGroup _group;

		public InspirationItemComponent inspiration;

		public RawImage IconImage
		{
			get
			{
				return null;
			}
		}

		public CanvasGroup Group
		{
			get
			{
				return null;
			}
		}

		public bool IsFull
		{
			get
			{
				return default(bool);
			}
		}

		public ThoughtBubbleItem(RawImage iconImage, CanvasGroup inGroup)
		{
		}

		public void AddInspiration(InspirationItemComponent inInspiration)
		{
		}

		public void RemoveInspiration()
		{
		}
	}

	[SerializeField]
	private float _rotationSpeed;

	[SerializeField]
	private Transform _rotationPivot;

	[SerializeField]
	private List<CanvasGroup> _inspirationGroups;

	[SerializeField]
	private List<RawImage> _inspirationIcons;

	[SerializeField]
	private RawImage _enigmaIcon;

	[SerializeField]
	private GameObject _sucessFX;

	[SerializeField]
	private GameObject _failureFX;

	private EnigmaDefComponent _enigma;

	private List<ThoughtBubbleItem> _thoughtBubbleItems;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void BtnClicked_ThoughtBubbleItem(int inIndex)
	{
	}

	public void AddInspiration(InspirationItemComponent inInspiration)
	{
	}

	public void RemoveInspiration(InspirationItemComponent inInspiration)
	{
	}

	public void SetEnigma(EnigmaDefComponent inEnigma)
	{
	}

	public float DoCombination(bool inSuccess)
	{
		return default(float);
	}

	private bool InspirationAlreadyAdded(InspirationItemComponent inInspiration)
	{
		return default(bool);
	}

	private ThoughtBubbleItem GetNextThoughtBubbleItem()
	{
		return null;
	}
}
