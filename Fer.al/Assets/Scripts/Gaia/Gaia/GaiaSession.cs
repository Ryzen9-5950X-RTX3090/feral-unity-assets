using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gaia
{
	[Serializable]
	public class GaiaSession : ScriptableObject, ISerializationCallbackReceiver
	{
		[TextArea]
		public string m_name;

		[TextArea]
		public string m_description;

		[HideInInspector]
		public Texture2D m_previewImage;

		public string m_dateCreated;

		public int m_terrainWidth;

		public int m_terrainDepth;

		public int m_terrainHeight;

		public float m_seaLevel;

		public bool m_isLocked;

		[HideInInspector]
		public ScriptableObjectWrapper m_defaults;

		[HideInInspector]
		public Dictionary<string, ScriptableObjectWrapper> m_resources;

		[HideInInspector]
		public List<string> m_resourcesKeys;

		[HideInInspector]
		public List<ScriptableObjectWrapper> m_resourcesValues;

		[HideInInspector]
		public byte[] m_previewImageBytes;

		[HideInInspector]
		public int m_previewImageWidth;

		[HideInInspector]
		public int m_previewImageHeight;

		[HideInInspector]
		public List<GaiaOperation> m_operations;

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public string GetSessionFileName()
		{
			return null;
		}

		public Texture2D GetPreviewImage()
		{
			return null;
		}
	}
}
