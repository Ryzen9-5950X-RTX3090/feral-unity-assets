using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	[ExecuteInEditMode]
	public class SoftMaskable : MonoBehaviour, IMaterialModifier, ICanvasRaycastFilter, ISerializationCallbackReceiver
	{
		private const int kVisibleInside = 85;

		private const int kVisibleOutside = 170;

		[Obsolete]
		[HideInInspector]
		[SerializeField]
		[Tooltip("The graphic will be visible only in areas where no mask is present.")]
		private bool m_Inverse;

		[HideInInspector]
		[SerializeField]
		[Tooltip("The interaction for each masks.")]
		private int m_MaskInteraction;

		[SerializeField]
		[Tooltip("Use stencil for masking.")]
		private bool m_UseStencil;

		private Graphic _graphic;

		private SoftMask _softMask;

		private Material _maskMaterial;

		private static int s_SoftMaskTexId;

		private static int s_StencilCompId;

		private static int s_MaskInteractionId;

		private static int s_GameVPId;

		private static int s_GameTVPId;

		private static List<SoftMaskable> s_ActiveSoftMaskables;

		private static int[] s_Interactions;

		private static Material s_DefaultMaterial;

		public bool inverse
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Graphic graphic
		{
			get
			{
				return null;
			}
		}

		public Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return default(bool);
		}

		public void SetMaskInteraction(SpriteMaskInteraction intr)
		{
		}

		public void SetMaskInteraction(SpriteMaskInteraction layer0, SpriteMaskInteraction layer1, SpriteMaskInteraction layer2, SpriteMaskInteraction layer3)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void ReleaseMaterial(ref Material mat)
		{
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}
	}
}
