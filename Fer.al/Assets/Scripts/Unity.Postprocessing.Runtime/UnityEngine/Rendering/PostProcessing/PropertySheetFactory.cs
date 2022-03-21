using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering.PostProcessing
{
	public sealed class PropertySheetFactory
	{
		private readonly Dictionary<Shader, PropertySheet> m_Sheets;

		[Obsolete]
		public PropertySheet Get(string shaderName)
		{
			return null;
		}

		public PropertySheet Get(Shader shader)
		{
			return null;
		}

		public void Release()
		{
		}
	}
}
