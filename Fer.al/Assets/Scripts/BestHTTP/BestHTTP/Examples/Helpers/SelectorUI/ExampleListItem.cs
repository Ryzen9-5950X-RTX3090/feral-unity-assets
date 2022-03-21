using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace BestHTTP.Examples.Helpers.SelectorUI
{
	public sealed class ExampleListItem : MonoBehaviour
	{
		[SerializeField]
		private Text _text;

		public SampleSelectorUI ParentUI
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public SampleBase ExamplePrefab
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Setup(SampleSelectorUI parentUI, SampleBase prefab)
		{
		}

		public void OnButton()
		{
		}
	}
}
