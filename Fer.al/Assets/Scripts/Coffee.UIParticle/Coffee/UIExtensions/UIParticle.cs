using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	[ExecuteInEditMode]
	public class UIParticle : MaskableGraphic
	{
		[Serializable]
		public class AnimatableProperty : ISerializationCallbackReceiver
		{
			public enum ShaderPropertyType
			{
				Color,
				Vector,
				Float,
				Range,
				Texture
			}

			[SerializeField]
			private string m_Name;

			[SerializeField]
			private ShaderPropertyType m_Type;

			public int id
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public ShaderPropertyType type
			{
				get
				{
					return default(ShaderPropertyType);
				}
			}

			public void OnBeforeSerialize()
			{
			}

			public void OnAfterDeserialize()
			{
			}
		}

		private static readonly int s_IdMainTex;

		private static readonly List<Vector3> s_Vertices;

		private static readonly List<UIParticle> s_TempRelatables;

		private static readonly List<UIParticle> s_ActiveParticles;

		[SerializeField]
		[Tooltip("The ParticleSystem rendered by CanvasRenderer")]
		private ParticleSystem m_ParticleSystem;

		[SerializeField]
		[Tooltip("The UIParticle to render trail effect")]
		private UIParticle m_TrailParticle;

		[HideInInspector]
		[SerializeField]
		private bool m_IsTrail;

		[SerializeField]
		[Tooltip("Particle effect scale")]
		private float m_Scale;

		[SerializeField]
		[Tooltip("Ignore parent scale")]
		private bool m_IgnoreParent;

		[SerializeField]
		[Tooltip("Animatable material properties. Animationã\u0081§ParticleSystemã\u0081®ã\u0083\u009eã\u0083\u0086ã\u0083ªã\u0082¢ã\u0083«ã\u0083\u0097ã\u0083\u00adã\u0083\u0091ã\u0083\u0086ã\u0082£ã\u0082\u0092å¤\u0089æ\u009b\u00b4ã\u0081\u0099ã\u0082\u008bå\u00a0\u00b4å\u0090\u0088ã\u0080\u0081æ\u009c\u0089å\u008a¹ã\u0081«ã\u0081\u0097ã\u0081¦ã\u0081\u008fã\u0081\u00a0ã\u0081\u0095ã\u0081\u0084ã\u0080\u0082")]
		private AnimatableProperty[] m_AnimatableProperties;

		private static MaterialPropertyBlock s_Mpb;

		private Mesh _mesh;

		private ParticleSystemRenderer _renderer;

		private UIParticle _parent;

		private List<UIParticle> _children;

		private Matrix4x4 scaleaMatrix;

		private Vector3 _oldPos;

		private static ParticleSystem.Particle[] s_Particles;

		public override Texture mainTexture
		{
			get
			{
				return null;
			}
		}

		public override Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float scale
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool ignoreParent
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool isRoot
		{
			get
			{
				return default(bool);
			}
		}

		public override bool raycastTarget
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public ParticleSystem cachedParticleSystem
		{
			get
			{
				return null;
			}
		}

		public override Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void UpdateGeometry()
		{
		}

		protected override void OnTransformParentChanged()
		{
		}

		protected override void OnDidApplyAnimationProperties()
		{
		}

		private static void UpdateMeshes()
		{
		}

		private void UpdateMesh()
		{
		}

		private void CheckTrail()
		{
		}

		private void SetParent(UIParticle newParent)
		{
		}

		private void UpdateAnimatableMaterialProperties()
		{
		}
	}
}
