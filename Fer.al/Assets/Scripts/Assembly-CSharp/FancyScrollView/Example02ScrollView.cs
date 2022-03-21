using System.Collections.Generic;
using UnityEngine;

namespace FancyScrollView
{
	public class Example02ScrollView : FancyScrollView<Example02CellDto, Example02ScrollViewContext>
	{
		[SerializeField]
		private ScrollPositionController scrollPositionController;

		private void Awake()
		{
		}

		public void UpdateData(List<Example02CellDto> data)
		{
		}

		private void OnPressedCell(Example02ScrollViewCell cell)
		{
		}
	}
}
