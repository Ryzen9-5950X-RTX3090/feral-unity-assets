using UnityEngine;
using UnityEngine.UI;
using WW.Waiters;

public class UI_AvatarLookImage : MonoBehaviour
{
	[SerializeField]
	private RawImage _iconImage;

	[SerializeField]
	private WWImage _emptyLookImage;

	[SerializeField]
	private bool _useEmptyLookImage;

	private WW.Waiters.Waiter _iconLoadWaiter;

	private AvatarLookItemComponent _look;

	private BaseDef _def;

	public void Setup(AvatarLookItemComponent inLook)
	{
	}

	private void OnDisable()
	{
	}
}
