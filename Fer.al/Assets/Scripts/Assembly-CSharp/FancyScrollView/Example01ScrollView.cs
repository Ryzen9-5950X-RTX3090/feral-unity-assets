using System.Collections.Generic;
using UnityEngine;

namespace FancyScrollView
{
	public class Example01ScrollView : FancyScrollView<Example01CellDto>
	{
		[SerializeField]
		private ScrollPositionController scrollPositionController;

		private void Awake()
		{
		}

		public void UpdateData(List<Example01CellDto> data)
		{
		}
	}
}
