using System.Collections.Generic;
using BestHTTP.Examples.Helpers;
using UnityEngine;
using UnityEngine.UI;

namespace BestHTTP.Examples
{
	public class SampleRoot : MonoBehaviour
	{
		[Header("Common Properties")]
		public string BaseURL;

		public string CDNUrl;

		[SerializeField]
		[Header("Referencies")]
		private Text _pluginVersion;

		[SerializeField]
		private Dropdown _logLevelDropdown;

		[SerializeField]
		private Text _proxyLabel;

		[SerializeField]
		private InputField _proxyInputField;

		[SerializeField]
		public List<SampleBase> samples;

		[HideInInspector]
		public SampleBase selectedExamplePrefab;

		private void Start()
		{
		}

		public void OnLogLevelChanged(int idx)
		{
		}

		public void OnProxyEditEnd(string proxyURL)
		{
		}
	}
}
