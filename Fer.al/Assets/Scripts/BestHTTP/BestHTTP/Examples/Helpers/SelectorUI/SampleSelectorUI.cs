using UnityEngine;

namespace BestHTTP.Examples.Helpers.SelectorUI
{
	public class SampleSelectorUI : MonoBehaviour
	{
		[SerializeField]
		private Category _categoryListItemPrefab;

		[SerializeField]
		private ExampleListItem _exampleListItemPrefab;

		[SerializeField]
		private ExampleInfo _exampleInfoPrefab;

		[SerializeField]
		private RectTransform _listRoot;

		[SerializeField]
		private RectTransform _dyncamicContentRoot;

		private SampleRoot sampleSelector;

		private ExampleListItem selectedSample;

		private GameObject dynamicContent;

		private void Start()
		{
		}

		private void DisplayExamples()
		{
		}

		public void SelectSample(ExampleListItem item)
		{
		}

		public void ExecuteExample(SampleBase example)
		{
		}
	}
}
