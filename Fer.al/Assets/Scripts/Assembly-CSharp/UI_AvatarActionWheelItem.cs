using UnityEngine;
using UnityEngine.UI;

public class UI_AvatarActionWheelItem : MonoBehaviour
{
	[SerializeField]
	private FeralButton _button;

	[SerializeField]
	private WWImage _iconImage;

	[SerializeField]
	private UI_Tooltip _tooltip;

	private AvatarActionDefComponent _avatarAction;

	public void Setup(AvatarActionDefComponent inAvatarAction)
	{
	}

	public void BtnClicked_Emote()
	{
	}
}
