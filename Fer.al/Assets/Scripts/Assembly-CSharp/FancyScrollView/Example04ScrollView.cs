using System;
using System.Collections.Generic;
using UnityEngine;

namespace FancyScrollView
{
	public class Example04ScrollView : FancyScrollView<Example04CellDto, Example04ScrollViewContext>
	{
		[SerializeField]
		private ScrollPositionController scrollPositionController;

		private Action<int> onSelectedIndexChanged;

		private void Awake()
		{
		}

		public void UpdateData(List<Example04CellDto> data)
		{
		}

		public void UpdateSelection(int index)
		{
		}

		public void OnSelectedIndexChanged(Action<int> onSelectedIndexChanged)
		{
		}

		public void SelectNextCell()
		{
		}

		public void SelectPrevCell()
		{
		}

		private void HandleItemSelected(int selectedItemIndex)
		{
		}

		private void OnPressedCell(Example04ScrollViewCell cell)
		{
		}
	}
}
