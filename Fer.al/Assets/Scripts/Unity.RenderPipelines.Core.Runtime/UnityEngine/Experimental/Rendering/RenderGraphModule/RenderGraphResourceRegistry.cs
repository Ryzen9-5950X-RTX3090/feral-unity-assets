using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	internal class RenderGraphResourceRegistry
	{
		private class IRenderGraphResource
		{
			public bool imported;

			public int cachedHash;

			public int transientPassIndex;

			public uint writeCount;

			public bool wasReleased;

			public bool requestFallBack;

			public virtual void Reset()
			{
			}

			public virtual string GetName()
			{
				return null;
			}

			public virtual bool IsCreated()
			{
				return default(bool);
			}

			public void IncrementWriteCount()
			{
			}

			public bool NeedsFallBack()
			{
				return default(bool);
			}
		}

		[DebuggerDisplay("Resource ({GetType().Name}:{GetName()})")]
		private class RenderGraphResource<DescType, ResType> : IRenderGraphResource where DescType : struct where ResType : class
		{
			public DescType desc;

			public ResType resource;

			protected RenderGraphResource()
			{
			}

			public override void Reset()
			{
			}

			public override bool IsCreated()
			{
				return default(bool);
			}
		}

		[DebuggerDisplay("TextureResource ({desc.name})")]
		private class TextureResource : RenderGraphResource<TextureDesc, RTHandle>
		{
			public override string GetName()
			{
				return null;
			}
		}

		[DebuggerDisplay("ComputeBufferResource ({desc.name})")]
		private class ComputeBufferResource : RenderGraphResource<ComputeBufferDesc, ComputeBuffer>
		{
			public override string GetName()
			{
				return null;
			}
		}

		internal struct RendererListResource
		{
			public RendererListDesc desc;

			public RendererList rendererList;

			internal RendererListResource([In] ref RendererListDesc desc)
			{
			}
		}

		private static readonly ShaderTagId s_EmptyName;

		private static RenderGraphResourceRegistry m_CurrentRegistry;

		private DynamicArray<IRenderGraphResource>[] m_Resources;

		private TexturePool m_TexturePool;

		private int m_TextureCreationIndex;

		private ComputeBufferPool m_ComputeBufferPool;

		private DynamicArray<RendererListResource> m_RendererListResources;

		private RenderGraphDebugParams m_RenderGraphDebug;

		private RenderGraphLogger m_Logger;

		private int m_CurrentFrameIndex;

		private RTHandle m_CurrentBackbuffer;

		internal static RenderGraphResourceRegistry current
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal RTHandle GetTexture([In] ref TextureHandle handle)
		{
			return null;
		}

		internal bool TextureNeedsFallback([In] ref TextureHandle handle)
		{
			return default(bool);
		}

		internal RendererList GetRendererList([In] ref RendererListHandle handle)
		{
			return default(RendererList);
		}

		internal ComputeBuffer GetComputeBuffer([In] ref ComputeBufferHandle handle)
		{
			return null;
		}

		private RenderGraphResourceRegistry()
		{
		}

		internal RenderGraphResourceRegistry(RenderGraphDebugParams renderGraphDebug, RenderGraphLogger logger)
		{
		}

		internal void BeginRender(int currentFrameIndex, int executionCount)
		{
		}

		internal void EndRender()
		{
		}

		private void CheckHandleValidity([In] ref ResourceHandle res)
		{
		}

		private void CheckHandleValidity(RenderGraphResourceType type, int index)
		{
		}

		internal void IncrementWriteCount([In] ref ResourceHandle res)
		{
		}

		internal string GetResourceName([In] ref ResourceHandle res)
		{
			return null;
		}

		internal string GetResourceName(RenderGraphResourceType type, int index)
		{
			return null;
		}

		internal bool IsResourceImported([In] ref ResourceHandle res)
		{
			return default(bool);
		}

		internal bool IsResourceCreated([In] ref ResourceHandle res)
		{
			return default(bool);
		}

		internal bool IsRendererListCreated([In] ref RendererListHandle res)
		{
			return default(bool);
		}

		internal bool IsResourceImported(RenderGraphResourceType type, int index)
		{
			return default(bool);
		}

		internal int GetResourceTransientIndex([In] ref ResourceHandle res)
		{
			return default(int);
		}

		internal TextureHandle ImportTexture(RTHandle rt)
		{
			return default(TextureHandle);
		}

		internal TextureHandle ImportBackbuffer(RenderTargetIdentifier rt)
		{
			return default(TextureHandle);
		}

		private int AddNewResource<ResType>(DynamicArray<IRenderGraphResource> resourceArray, out ResType outRes) where ResType : IRenderGraphResource, new()
		{
			return default(int);
		}

		internal TextureHandle CreateTexture([In] ref TextureDesc desc, int transientPassIndex = -1)
		{
			return default(TextureHandle);
		}

		internal int GetTextureResourceCount()
		{
			return default(int);
		}

		private TextureResource GetTextureResource([In] ref ResourceHandle handle)
		{
			return null;
		}

		internal TextureDesc GetTextureResourceDesc([In] ref ResourceHandle handle)
		{
			return default(TextureDesc);
		}

		internal RendererListHandle CreateRendererList([In] ref RendererListDesc desc)
		{
			return default(RendererListHandle);
		}

		internal ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer)
		{
			return default(ComputeBufferHandle);
		}

		internal ComputeBufferHandle CreateComputeBuffer([In] ref ComputeBufferDesc desc, int transientPassIndex = -1)
		{
			return default(ComputeBufferHandle);
		}

		internal ComputeBufferDesc GetComputeBufferResourceDesc([In] ref ResourceHandle handle)
		{
			return default(ComputeBufferDesc);
		}

		internal int GetComputeBufferResourceCount()
		{
			return default(int);
		}

		private ComputeBufferResource GetComputeBufferResource([In] ref ResourceHandle handle)
		{
			return null;
		}

		internal void CreateAndClearTexture(RenderGraphContext rgContext, int index)
		{
		}

		internal void CreateComputeBuffer(RenderGraphContext rgContext, int index)
		{
		}

		internal void ReleaseTexture(RenderGraphContext rgContext, int index)
		{
		}

		internal void ReleaseComputeBuffer(RenderGraphContext rgContext, int index)
		{
		}

		private void ValidateTextureDesc([In] ref TextureDesc desc)
		{
		}

		private void ValidateRendererListDesc([In] ref RendererListDesc desc)
		{
		}

		private void ValidateComputeBufferDesc([In] ref ComputeBufferDesc desc)
		{
		}

		internal void CreateRendererLists(List<RendererListHandle> rendererLists)
		{
		}

		internal void Clear(bool onException)
		{
		}

		internal void PurgeUnusedResources()
		{
		}

		internal void Cleanup()
		{
		}

		private void LogTextureCreation(TextureResource rt)
		{
		}

		private void LogTextureRelease(TextureResource rt)
		{
		}

		private void LogComputeBufferCreation(ComputeBufferResource buffer)
		{
		}

		private void LogComputeBufferRelease(ComputeBufferResource buffer)
		{
		}

		private void LogResources()
		{
		}
	}
}
