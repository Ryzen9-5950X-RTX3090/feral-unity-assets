using UnityEngine;
using UnityEngine.UI;

namespace FancyScrollView
{
	public class Example04Scene : MonoBehaviour
	{
		[SerializeField]
		private Example04ScrollView scrollView;

		[SerializeField]
		private Button prevCellButton;

		[SerializeField]
		private Button nextCellButton;

		[SerializeField]
		private Text selectedItemInfo;

		private void Start()
		{
		}

		private void HandleSelectedIndexChanged(int index)
		{
		}
	}
}
