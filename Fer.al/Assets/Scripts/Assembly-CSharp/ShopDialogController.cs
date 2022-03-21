using NodeCanvas.DialogueTrees;
using UnityEngine;

public class ShopDialogController : MonoBehaviour
{
	[SerializeField]
	[RootSelector("NPC Name", "LocalizationChartData", false, false)]
	private string _nameDefId;

	[SerializeField]
	[RootSelector("NPC Icon", "ImageChartData", false, false)]
	private string _iconDefId;

	[SerializeField]
	private DialogueTreeController _introController;

	[SerializeField]
	private DialogueTreeController _craftedController;

	private void OnEnable()
	{
	}

	public void ShowIntroDialog()
	{
	}

	public void ShowCraftedDialog()
	{
	}
}
