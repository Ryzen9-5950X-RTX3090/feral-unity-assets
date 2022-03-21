using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype
{
	public class InteractionCorpus : Interactable
	{
		[SerializeField]
		private AudioClip _audioClip;

		private AudioClip _priorClip;

		private Animator _animator;

		private SkinnedMeshRenderer[] _playerRenderers;

		[SerializeField]
		private bool _useColorChangeAction;

		[SerializeField]
		private Color _colorChangeRed;

		[SerializeField]
		private Color _colorChangeGreen;

		[SerializeField]
		private Color _colorChangeBlue;

		private GameObject _model;

		private Vector3 _moveDirection;

		private Vector3 _moveVector;

		private float _rotate;

		private bool _shaking;

		public string uniqueActionName;

		public string uniqueActionAnimation;

		public Texture uniqueActionTexture;

		[RootSelector("UniqueAction CraftableItem", "CraftableItemChartData", false, false)]
		public string uniqueActionCraftableItemId;

		private bool _collectedUniqueActionCraftableItem;

		public static InteractionCorpus currentCorpus
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CharacterController controller
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ActorMoverNavType playerNavType
		{
			[CompilerGenerated]
			get
			{
				return default(ActorMoverNavType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}
	}
}
