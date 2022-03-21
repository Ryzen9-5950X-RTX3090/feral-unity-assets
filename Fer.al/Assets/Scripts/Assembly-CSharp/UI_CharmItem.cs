using UnityEngine;
using UnityEngine.UI;

public class UI_CharmItem : MonoBehaviour
{
	[SerializeField]
	private FeralButton _button;

	[SerializeField]
	private WWImage _slotIconImage;

	[SerializeField]
	private WWImage _gemIconImage;

	[SerializeField]
	private WWImage _starIconImage;

	private bool _isEquipped;

	private bool _isSpecial;

	public FeralButton Button
	{
		get
		{
			return null;
		}
	}

	public bool IsEquipped
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsSpecial
	{
		get
		{
			return default(bool);
		}
	}

	private void Reset()
	{
	}

	public void Setup(UI_CharmList inCharmList, bool inIsSpecial, bool inIsEquipped)
	{
	}
}
