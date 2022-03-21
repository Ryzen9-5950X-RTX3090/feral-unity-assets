using UnityEngine;
using UnityEngine.UI;

namespace Tanks.UI
{
	public class HUDMultiplayerScore : MonoBehaviour
	{
		[SerializeField]
		protected Text m_TargetValue;

		[SerializeField]
		protected GameObject[] m_ScoreParent;

		[SerializeField]
		protected Image[] m_TeamIcons;

		[SerializeField]
		protected Text[] m_TeamScores;

		protected virtual void Start()
		{
		}

		public void UpdateScoreDisplay(Color[] colours, int[] scores)
		{
		}
	}
}
