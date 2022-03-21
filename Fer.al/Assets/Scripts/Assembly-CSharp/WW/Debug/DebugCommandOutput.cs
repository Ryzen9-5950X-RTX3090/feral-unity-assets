using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace WW.Debug
{
	public class DebugCommandOutput : MonoBehaviour
	{
		[SerializeField]
		private int _lineCount;

		[SerializeField]
		private Text _text;

		private StringBuilder _stringBuilder;

		private List<string> _lines;

		private void Start()
		{
		}

		public void Log(string inLogText)
		{
		}

		public void ClearLog()
		{
		}
	}
}
