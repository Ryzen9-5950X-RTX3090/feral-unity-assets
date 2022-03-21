using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace World_Challenge.Casual_Game.Terra_Farming
{
	public class TerrafarmingBlockGroup : ManagedBehaviour
	{
		internal enum EBlockGroupType
		{
			NONE,
			COLLECT,
			SINGLE,
			DOUBLE_VERTICAL,
			DOUBLE_SLANT_UP,
			DOUBLE_SLANT_DOWN,
			TRIPLE_VERTICAL,
			TRIPLE_SLANT_UP,
			TRIPLE_SLANT_DOWN,
			TRIPLE_ARCH_TOP,
			TRIPLE_ARCH_BOTTOM,
			TRIPLE_ARCH_TR,
			TRIPLE_ARCH_TL,
			TRIPLE_ARCH_BR,
			TRIPLE_ARCH_BL,
			TRIPLE_LEFT,
			TRIPLE_RIGHT
		}

		private enum EDirections
		{
			VERTICAL_UP,
			VERTICAL_DOWN,
			SLANT_UP,
			SLANT_DOWN
		}

		[SerializeField]
		internal TerraFarming game;

		[SerializeField]
		internal List<TerrafarmingBlock> blocks;

		internal int spawnIndex;

		internal bool canDrop;

		internal bool canClick;

		[SerializeField]
		internal EBlockGroupType blockGroupType;

		private bool _canToggle;

		[SerializeField]
		private TerrafarmingGrid _grid;

		private HashSet<string> _activeGrids;

		internal void CreateBlockGroup()
		{
		}

		internal void Colorize(int inCollectorColor = -1)
		{
		}

		private void CreateSingle()
		{
		}

		private void CreateDouble()
		{
		}

		private void CreateTriple()
		{
		}

		private Vector3 GetPos(Vector3 inStart, EDirections inDir)
		{
			return default(Vector3);
		}

		[IteratorStateMachine(typeof(<ToggleColor>d__17))]
		private IEnumerator ToggleColor(int inBlockIndex, Vector3 inEndPos)
		{
			return null;
		}

		internal void ToggleColors()
		{
		}

		internal void CanDrop(bool inCanDrop)
		{
		}

		private void OnMouseDown()
		{
		}

		private void OnMouseUp()
		{
		}
	}
}
