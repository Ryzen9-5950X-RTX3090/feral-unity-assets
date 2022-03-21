using UnityEngine;

namespace Crosstales.Common.Util
{
	[DisallowMultipleComponent]
	public class TakeScreenshot : MonoBehaviour
	{
		[Tooltip("Prefix for the generate file names.")]
		public string Prefix;

		[Tooltip("Factor by which to increase resolution (default: 1).")]
		public int Scale;

		[Tooltip("Key-press to capture the screen (default: F8).")]
		public KeyCode KeyCode;

		[Tooltip("Show file location (default: true).")]
		public bool ShowFileLocation;

		private Texture2D texture;

		private bool locationShown;

		public void Start()
		{
		}

		public void Update()
		{
		}

		public void Capture()
		{
		}
	}
}
