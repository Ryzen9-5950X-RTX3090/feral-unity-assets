using UnityEngine;
using UnityEngine.UI;

namespace BestHTTP.Examples.Helpers.SelectorUI
{
	public sealed class ExampleInfo : MonoBehaviour
	{
		[SerializeField]
		private Text _header;

		[SerializeField]
		private Text _description;

		private SampleSelectorUI _parentUI;

		private SampleBase _example;

		public void Setup(SampleSelectorUI parentUI, SampleBase example)
		{
		}

		public void OnExecuteExample()
		{
		}
	}
}
