using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace World_Challenge.Casual_Game.Terra_Farming
{
	public class TerrafarmingBlock : ManagedBehaviour
	{
		[Header("Tarrafarming Block")]
		public Renderer faceRenderer;

		public Renderer[] sideRenderers;

		public CanvasGroup uiCanvasGroup;

		public Text faceText;

		public RawImage faceImage;

		public float particleToScoreTime;

		public float particleUpDist;

		internal bool isOccupied;

		internal int blockColorIndex;

		internal int rowIndex;

		internal int columnIndex;

		internal int blockValue;

		internal int gridBlockGroupIndex;

		internal bool isCollector;

		internal int pulseIndex;

		internal TerrafarmingBlock hoverBlock;

		internal TerrafarmingBlock gridBlock;

		[SerializeField]
		[HideInInspector]
		internal TerraFarming game;

		public override void MStart()
		{
		}

		internal void ReSetColor(Color inFaceColor, Color inSideColor, bool inClearFace)
		{
		}

		[IteratorStateMachine(typeof(<PulseForScoring>d__20))]
		internal IEnumerator PulseForScoring(bool inPlayScoreBurst)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<PulseForCollecting>d__21))]
		internal IEnumerator PulseForCollecting(TerrafarmingBlock inColloectorBlock)
		{
			return null;
		}
	}
}
