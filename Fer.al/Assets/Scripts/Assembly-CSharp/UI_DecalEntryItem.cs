using Coffee.UIExtensions;
using UnityEngine;
using UnityEngine.UI;

public class UI_DecalEntryItem : MonoBehaviour
{
	[SerializeField]
	private WWImage _decalIconImage;

	[SerializeField]
	private WWImage _decalIconHighlightImage;

	[SerializeField]
	private UIHsvModifier _iconHSVModifier;

	[SerializeField]
	private FeralButton _button;

	[SerializeField]
	private FeralButton _isVisible;

	private ActorInfoDecalEntry _decalEntry;

	public FeralButton Button
	{
		get
		{
			return null;
		}
	}

	public ActorInfoDecalEntry DecalEntry
	{
		get
		{
			return null;
		}
	}

	public void Setup(ActorInfoDecalEntry inDecalEntry)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDecalVisibilityChanged(bool inIsVisible)
	{
	}

	public void RefreshIcon()
	{
	}

	public void RefreshIconColor()
	{
	}
}
