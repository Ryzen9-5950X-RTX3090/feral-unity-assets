using System.Collections.Generic;
using UnityEngine;

namespace Prototype.QuickGames.CatchThrownItems
{
	public class CatchThrownItemsDragTarget : UnityEngine.MonoBehaviour
	{
		public CircleCollider2D moverCollider;

		public BoxCollider2D catcherCollider;

		public TargetJoint2D moverTargetJoint;

		public LayerMask dragLayers;

		public bool drawDragLine;

		public Color color;

		public float maxY;

		public float minY;

		public float maxX;

		public Transform catchPoints;

		internal List<Transform> allCatchPoints;

		internal CatchThrownItems game;

		internal RectTransform rectTrans;

		private int _caughtPositionIndex;

		private RectTransform _hudRect;

		private Vector3 _mouseWorldPosition;

		private bool _moverSelected;

		private float _maxYworld;

		private float _minYworld;

		private float _maxXworld;

		private float _minXworld;

		internal void Init()
		{
		}

		internal void DragTargetUpdate()
		{
		}

		internal int GetCaughtPosIndex()
		{
			return default(int);
		}
	}
}
