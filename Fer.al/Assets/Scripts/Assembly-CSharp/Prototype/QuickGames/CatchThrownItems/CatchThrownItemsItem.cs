using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames.CatchThrownItems
{
	public class CatchThrownItemsItem : UnityEngine.MonoBehaviour
	{
		internal enum EState
		{
			SCALING,
			THROW,
			LAUNCH,
			INAIR,
			LANDED,
			CAUGHT,
			INBASKET
		}

		public RawImage rawimage;

		public float shadowScale;

		internal EState state;

		internal int archDir;

		internal CatchThrownItems game;

		internal float spawnTime;

		internal bool isRare;

		private Vector3 _caughtPos;

		private Vector3 _startScale;

		private int _itemPosIndex;

		private Transform _shadow;

		private bool _isScaled;

		private bool _hasLanded;

		private float _currentTime;

		private Vector3 _launchPoint;

		private Vector3 _landPoint;

		private List<Vector3> _pointList;

		private Vector2 _mousePos;

		private Vector3 _shadowScale;

		internal void ItemUpdate()
		{
		}

		internal void Init()
		{
		}

		private void GetImage(RawImage inRawImage, QuickGamesBase.WinIngredient inWinIngredient)
		{
		}
	}
}
