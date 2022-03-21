using UnityEngine;
using UnityEngine.UI;
using WW.Waiters;

public class UI_SanctuaryLookImage : MonoBehaviour
{
	[SerializeField]
	private RawImage _iconImage;

	[SerializeField]
	private WWImage _emptyLookImage;

	[SerializeField]
	private bool _useEmptyLookImage;

	private WW.Waiters.Waiter _iconLoadWaiter;

	private SanctuaryLookItemComponent _look;

	private BaseDef _def;

	public void Setup(SanctuaryLookItemComponent inLook)
	{
	}

	private void OnDisable()
	{
	}
}
