using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class TextureCurve : IDisposable
	{
		private const int k_Precision = 128;

		private const float k_Step = 1f / 128f;

		[SerializeField]
		private bool m_Loop;

		[SerializeField]
		private float m_ZeroValue;

		[SerializeField]
		private float m_Range;

		[SerializeField]
		private AnimationCurve m_Curve;

		private AnimationCurve m_LoopingCurve;

		private Texture2D m_Texture;

		private bool m_IsCurveDirty;

		private bool m_IsTextureDirty;

		public int length
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

		public Keyframe this[int index]
		{
			get
			{
				return default(Keyframe);
			}
		}

		public TextureCurve(AnimationCurve baseCurve, float zeroValue, bool loop, [In] ref Vector2 bounds)
		{
		}

		public TextureCurve(Keyframe[] keys, float zeroValue, bool loop, [In] ref Vector2 bounds)
		{
		}

		~TextureCurve()
		{
		}

		[Obsolete]
		public void Dispose()
		{
		}

		public void Release()
		{
		}

		public void SetDirty()
		{
		}

		private static TextureFormat GetTextureFormat()
		{
			return default(TextureFormat);
		}

		public Texture2D GetTexture()
		{
			return null;
		}

		public float Evaluate(float time)
		{
			return default(float);
		}

		public int AddKey(float time, float value)
		{
			return default(int);
		}

		public int MoveKey(int index, [In] ref Keyframe key)
		{
			return default(int);
		}

		public void RemoveKey(int index)
		{
		}

		public void SmoothTangents(int index, float weight)
		{
		}
	}
}
