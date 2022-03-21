using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine.Rendering.PostProcessing
{
	public static class RuntimeUtilities
	{
		private static Texture2D m_WhiteTexture;

		private static Texture3D m_WhiteTexture3D;

		private static Texture2D m_BlackTexture;

		private static Texture3D m_BlackTexture3D;

		private static Texture2D m_TransparentTexture;

		private static Texture3D m_TransparentTexture3D;

		private static Dictionary<int, Texture2D> m_LutStrips;

		private static PostProcessResources s_Resources;

		private static Mesh s_FullscreenTriangle;

		private static Material s_CopyStdMaterial;

		private static Material s_CopyStdFromDoubleWideMaterial;

		private static Material s_CopyMaterial;

		private static Material s_CopyFromTexArrayMaterial;

		private static PropertySheet s_CopySheet;

		private static PropertySheet s_CopyFromTexArraySheet;

		private static IEnumerable<Type> m_AssemblyTypes;

		public static Texture2D whiteTexture
		{
			get
			{
				return null;
			}
		}

		public static Texture3D whiteTexture3D
		{
			get
			{
				return null;
			}
		}

		public static Texture2D blackTexture
		{
			get
			{
				return null;
			}
		}

		public static Texture3D blackTexture3D
		{
			get
			{
				return null;
			}
		}

		public static Texture2D transparentTexture
		{
			get
			{
				return null;
			}
		}

		public static Texture3D transparentTexture3D
		{
			get
			{
				return null;
			}
		}

		public static Mesh fullscreenTriangle
		{
			get
			{
				return null;
			}
		}

		public static Material copyStdMaterial
		{
			get
			{
				return null;
			}
		}

		public static Material copyStdFromDoubleWideMaterial
		{
			get
			{
				return null;
			}
		}

		public static Material copyMaterial
		{
			get
			{
				return null;
			}
		}

		public static Material copyFromTexArrayMaterial
		{
			get
			{
				return null;
			}
		}

		public static PropertySheet copySheet
		{
			get
			{
				return null;
			}
		}

		public static PropertySheet copyFromTexArraySheet
		{
			get
			{
				return null;
			}
		}

		public static bool scriptableRenderPipelineActive
		{
			get
			{
				return default(bool);
			}
		}

		public static bool supportsDeferredShading
		{
			get
			{
				return default(bool);
			}
		}

		public static bool supportsDepthNormals
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isSinglePassStereoEnabled
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isVREnabled
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isAndroidOpenGL
		{
			get
			{
				return default(bool);
			}
		}

		public static RenderTextureFormat defaultHDRRenderTextureFormat
		{
			get
			{
				return default(RenderTextureFormat);
			}
		}

		public static bool isLinearColorSpace
		{
			get
			{
				return default(bool);
			}
		}

		public static Texture2D GetLutStrip(int size)
		{
			return null;
		}

		internal static void UpdateResources(PostProcessResources resources)
		{
		}

		public static void SetRenderTargetWithLoadStoreAction(this CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction)
		{
		}

		public static void SetRenderTargetWithLoadStoreAction(this CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
		{
		}

		public static void SetRenderTargetWithLoadStoreAction(this CommandBuffer cmd, RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
		{
		}

		public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, bool clear = false, [Optional] Rect? viewport, bool preserveDepth = false)
		{
		}

		public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, RenderBufferLoadAction loadAction, [Optional] Rect? viewport, bool preserveDepth = false)
		{
		}

		public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, [Optional] Rect? viewport, bool preserveDepth = false)
		{
		}

		public static void BlitFullscreenTriangleFromDoubleWide(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass, int eye)
		{
		}

		public static void BlitFullscreenTriangleToDoubleWide(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, int eye)
		{
		}

		public static void BlitFullscreenTriangleFromTexArray(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1)
		{
		}

		public static void BlitFullscreenTriangleToTexArray(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1)
		{
		}

		public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, [Optional] Rect? viewport)
		{
		}

		public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, [Optional] Rect? viewport)
		{
		}

		public static void BuiltinBlit(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination)
		{
		}

		public static void BuiltinBlit(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material mat, int pass = 0)
		{
		}

		public static void CopyTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination)
		{
		}

		public static bool isFloatingPointFormat(RenderTextureFormat format)
		{
			return default(bool);
		}

		public static void Destroy(Object obj)
		{
		}

		public static bool IsResolvedDepthAvailable(Camera camera)
		{
			return default(bool);
		}

		public static void DestroyProfile(PostProcessProfile profile, bool destroyEffects)
		{
		}

		public static void DestroyVolume(PostProcessVolume volume, bool destroyProfile, bool destroyGameObject = false)
		{
		}

		public static bool IsPostProcessingActive(PostProcessLayer layer)
		{
			return default(bool);
		}

		public static bool IsTemporalAntialiasingActive(PostProcessLayer layer)
		{
			return default(bool);
		}

		[IteratorStateMachine(typeof(<GetAllSceneObjects>d__81<>))]
		public static IEnumerable<T> GetAllSceneObjects<T>() where T : Component
		{
			return null;
		}

		public static void CreateIfNull<T>(ref T obj) where T : class, new()
		{
		}

		public static float Exp2(float x)
		{
			return default(float);
		}

		public static Matrix4x4 GetJitteredPerspectiveProjectionMatrix(Camera camera, Vector2 offset)
		{
			return default(Matrix4x4);
		}

		public static Matrix4x4 GetJitteredOrthographicProjectionMatrix(Camera camera, Vector2 offset)
		{
			return default(Matrix4x4);
		}

		public static Matrix4x4 GenerateJitteredProjectionMatrixFromOriginal(PostProcessRenderContext context, Matrix4x4 origProj, Vector2 jitter)
		{
			return default(Matrix4x4);
		}

		public static IEnumerable<Type> GetAllAssemblyTypes()
		{
			return null;
		}

		public static IEnumerable<Type> GetAllTypesDerivedFrom<T>()
		{
			return null;
		}

		public static T GetAttribute<T>(this Type type) where T : Attribute
		{
			return null;
		}

		public static Attribute[] GetMemberAttributes<TType, TValue>(Expression<Func<TType, TValue>> expr)
		{
			return null;
		}

		public static string GetFieldPath<TType, TValue>(Expression<Func<TType, TValue>> expr)
		{
			return null;
		}
	}
}
