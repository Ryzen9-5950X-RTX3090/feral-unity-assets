using ThisOtherThing.UI.Shapes;
using UnityEngine;
using UnityEngine.UI;

public class UI_DecalItem : MonoBehaviour
{
	[SerializeField]
	private Rectangle _decalIconImage;

	[SerializeField]
	private FeralButton _button;

	private BaseDef _decalDef;

	public FeralButton Button
	{
		get
		{
			return null;
		}
	}

	public BaseDef DecalDef
	{
		get
		{
			return null;
		}
	}

	public void Setup(BaseDef inDecalDef)
	{
	}
}
