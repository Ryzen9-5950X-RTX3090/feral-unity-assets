using System.Collections.Generic;
using UnityEngine;

namespace FancyScrollView
{
	public class Example03ScrollView : FancyScrollView<Example03CellDto, Example03ScrollViewContext>
	{
		[SerializeField]
		private ScrollPositionController scrollPositionController;

		private void Awake()
		{
		}

		public void UpdateData(List<Example03CellDto> data)
		{
		}

		private void OnPressedCell(Example03ScrollViewCell cell)
		{
		}
	}
}
