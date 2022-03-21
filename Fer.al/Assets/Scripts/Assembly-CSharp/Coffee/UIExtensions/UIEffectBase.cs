using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Graphic))]
	public abstract class UIEffectBase : BaseMeshEffect, IParameterTexture
	{
		protected static readonly Vector2[] splitedCharacterPosition;

		protected static readonly List<UIVertex> tempVerts;

		[HideInInspector]
		[SerializeField]
		private int m_Version;

		[SerializeField]
		protected Material m_EffectMaterial;

		public int parameterIndex
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual ParameterTexture ptex
		{
			get
			{
				return null;
			}
		}

		public Graphic targetGraphic
		{
			get
			{
				return null;
			}
		}

		public Material effectMaterial
		{
			get
			{
				return null;
			}
		}

		public virtual void ModifyMaterial()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected virtual void SetDirty()
		{
		}

		protected override void OnDidApplyAnimationProperties()
		{
		}
	}
}
