using UnityEngine;

namespace Gaia
{
	[GaiaScriptOrder(500)]
	public class ScreenShotter : MonoBehaviour
	{
		public KeyCode m_screenShotKey;

		public GaiaConstants.StorageFormat m_imageFormat;

		public string m_targetDirectory;

		public int m_targetWidth;

		public int m_targetHeight;

		public bool m_useScreenSize;

		public Camera m_mainCamera;

		private bool m_takeShot;

		private bool m_refreshAssetDB;

		public Texture2D m_watermark;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		public Camera FindCamera()
		{
			return null;
		}

		private string ScreenShotName(int width, int height)
		{
			return null;
		}

		public void TakeHiResShot()
		{
		}

		private void LateUpdate()
		{
		}

		public Texture2D AddWatermark(Texture2D background, Texture2D watermark)
		{
			return null;
		}
	}
}
