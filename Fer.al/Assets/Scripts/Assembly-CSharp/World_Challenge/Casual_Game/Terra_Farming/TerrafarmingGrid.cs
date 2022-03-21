using System.Collections.Generic;
using UnityEngine;

namespace World_Challenge.Casual_Game.Terra_Farming
{
	public class TerrafarmingGrid : MonoBehaviour
	{
		[Header("Terrafarming Grid")]
		public TerrafarmingBlock terrafarmingBlock;

		public Color gridFaceInactive;

		public Color gridFaceActive;

		public Color blockEdges;

		internal float blockZoffset_vertical;

		internal float blockZoffset_slant;

		internal float blockXoffset;

		internal TerrafarmingBlock block;

		internal List<TerrafarmingBlock> allBlocks;

		public void Start()
		{
		}

		private void CreateGrid()
		{
		}
	}
}
