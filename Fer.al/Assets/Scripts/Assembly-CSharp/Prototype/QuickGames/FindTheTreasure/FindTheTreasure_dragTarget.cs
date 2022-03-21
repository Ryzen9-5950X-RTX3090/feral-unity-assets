using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames.FindTheTreasure
{
	public class FindTheTreasure_dragTarget : UnityEngine.MonoBehaviour
	{
		public Transform spotLight;

		public CircleCollider2D moverCollider;

		public Rigidbody2D moverRigidBody;

		public TargetJoint2D moverTargetJoint;

		public RawImage rawImage;

		public Canvas canvas;

		public LayerMask dragLayers;

		public bool drawDragLine;

		public Color color;

		public float spotlightSmooth;

		public float maxSpotliteRotate;

		public float maxSpotlightSpeed;

		public float maxY;

		public float minY;

		public float maxXmin;

		public float maxXmax;

		public float UImaxX;

		public bool tiltSpotLight;

		public RectTransform BG_back;

		public RectTransform BG_mid;

		public RectTransform BG_fore;

		public float BGspeed_back;

		public float BGspeed_mid;

		public float BGspeed_fore;

		internal FindTheTreasure Game;

		internal RectTransform rectTrans;

		private RectTransform _hudRect;

		private Vector2 _mouseLocalPosition;

		private Quaternion _spotlightRotate;

		private TargetJoint2D _targetJoint;

		private Vector3 _mouseWorldPosition;

		private Camera _cam;

		private Rect _facingRect;

		private bool _moverSelected;

		private Vector2 _moveDir;

		private float _maxXrange;

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
	}
}
