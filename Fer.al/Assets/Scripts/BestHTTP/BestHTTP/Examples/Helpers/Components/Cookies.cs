using BestHTTP.Core;
using UnityEngine;
using UnityEngine.UI;

namespace BestHTTP.Examples.Helpers.Components
{
	public class Cookies : MonoBehaviour
	{
		[SerializeField]
		private Text _count;

		[SerializeField]
		private Text _size;

		[SerializeField]
		private Button _clear;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnPluginEvent(PluginEventInfo @event)
		{
		}

		private void UpdateLabels()
		{
		}

		public void OnClearButtonClicked()
		{
		}
	}
}
