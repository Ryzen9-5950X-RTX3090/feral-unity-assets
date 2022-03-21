using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	[AddComponentMenu("UI/UIEffect/UIShiny", 2)]
	public class UIShiny : UIEffectBase
	{
		public const string shaderName = "UI/Hidden/UI-Effect-Shiny";

		private static readonly ParameterTexture _ptex;

		[SerializeField]
		[Tooltip("Location for shiny effect.")]
		[FormerlySerializedAs("m_Location")]
		[Range(0f, 1f)]
		private float m_EffectFactor;

		[SerializeField]
		[Tooltip("Width for shiny effect.")]
		[Range(0f, 1f)]
		private float m_Width;

		[SerializeField]
		[Tooltip("Rotation for shiny effect.")]
		[Range(-180f, 180f)]
		private float m_Rotation;

		[SerializeField]
		[Tooltip("Softness for shiny effect.")]
		[Range(0.01f, 1f)]
		private float m_Softness;

		[SerializeField]
		[Tooltip("Brightness for shiny effect.")]
		[FormerlySerializedAs("m_Alpha")]
		[Range(0f, 1f)]
		private float m_Brightness;

		[SerializeField]
		[Tooltip("Gloss factor for shiny effect.")]
		[FormerlySerializedAs("m_Highlight")]
		[Range(0f, 1f)]
		private float m_Gloss;

		[SerializeField]
		[Tooltip("The area for effect.")]
		protected EffectArea m_EffectArea;

		[SerializeField]
		private EffectPlayer m_Player;

		[Obsolete]
		[HideInInspector]
		[SerializeField]
		private bool m_Play;

		[Obsolete]
		[HideInInspector]
		[SerializeField]
		private bool m_Loop;

		[Obsolete]
		[HideInInspector]
		[SerializeField]
		[Range(0.1f, 10f)]
		private float m_Duration;

		[Obsolete]
		[HideInInspector]
		[SerializeField]
		[Range(0f, 10f)]
		private float m_LoopDelay;

		[Obsolete]
		[HideInInspector]
		[SerializeField]
		private AnimatorUpdateMode m_UpdateMode;

		private float _lastRotation;

		[Obsolete]
		public float location
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float effectFactor
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float width
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float softness
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		[Obsolete]
		public float alpha
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float brightness
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		[Obsolete]
		public float highlight
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float gloss
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float rotation
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public EffectArea effectArea
		{
			get
			{
				return default(EffectArea);
			}
			set
			{
			}
		}

		public bool play
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool loop
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float duration
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float loopDelay
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public AnimatorUpdateMode updateMode
		{
			get
			{
				return default(AnimatorUpdateMode);
			}
			set
			{
			}
		}

		public override ParameterTexture ptex
		{
			get
			{
				return null;
			}
		}

		private EffectPlayer _player
		{
			get
			{
				return null;
			}
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		public void Play()
		{
		}

		public void Stop()
		{
		}

		protected override void SetDirty()
		{
		}
	}
}
