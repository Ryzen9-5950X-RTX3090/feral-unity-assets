using UnityEngine;

namespace Gaia
{
	public class FrameRateManager : MonoBehaviour
	{
		public bool m_showFPS;

		public bool m_showGUI;

		public bool m_autoQualityManagement;

		public float m_autoCheckInterval;

		public int m_targetFrameRate;

		public int m_fontSize;

		private float m_autoCheckTimeLeft;

		private int m_currentQuality;

		private int m_maxQuality;

		private string[] m_qualityNames;

		private float m_fpsUpdateInterval;

		private float m_fpsAccum;

		private int m_fpsFrames;

		private float m_fpsTimeLeft;

		private float m_fpsValue;

		private string m_fpsValueStr;

		private GUIStyle m_fpsStyle;

		private GUIStyle m_fpsShadowStyle;

		private Rect m_fpsLocation;

		private Rect m_fpsShadowLocation;

		private void Start()
		{
		}

		private void OnGUI()
		{
		}

		private void Update()
		{
		}

		private void UpdateQuality()
		{
		}

		private bool IncreaseQuality()
		{
			return default(bool);
		}

		private bool DecreaseQuality()
		{
			return default(bool);
		}
	}
}
