using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class IconManager : SingletonManagerBase<IconManager>
{
	private enum IconManagerEntryType
	{
		Texture,
		Model
	}

	[Serializable]
	private class IconManagerEntry
	{
		public IconManagerEntryType entryType;

		public bool refresh;

		public bool released;

		public RawImage ownerImage;

		public RawImage spiralImage;

		public QRoutine downloadRoutine;

		public bool finishedDownloadAndSetup;

		public GameObject bundleReferenceObject;

		public Texture2D iconTexture;

		public Icon3DAnimationType animationType;

		public GameObject iconParent;

		public GameObject iconObject;

		public UI_SpinWithMouse iconSpinWithMouse;

		public Icon3DDefComponent icon3DDefComponent;

		public Camera iconObjectRenderCamera;

		public RenderTexture iconObjectRenderTex;

		public int iconXPosition;

		public List<string> iconObjectCameraFocusNames;

		public IconManagerEntry(RawImage inOwnerImage, Icon3DAnimationType inAnimationType)
		{
		}

		public void CreateSpiralTexture(Texture2D inSpiralTexture, int inFrameColumn, int inFrameRow, int inFrameColumnMax)
		{
		}

		public void UpdateSpiralTexture(int inFrameColumn, int inFrameRow, int inFrameColumnMax)
		{
		}

		public void StopSpiralTexture()
		{
		}

		public void FadeInOwnerImage()
		{
		}

		public void SetIconTexture(Texture2D inTexture)
		{
		}

		public void SetIconModel(GameObject inGameObject, Icon3DDefComponent inIconDefComponent, Stack<int> inFreeXPositions, Icon3DTextureSize inIcon3DTextureSize = Icon3DTextureSize.Medium, [Optional] List<string> inFocusNames)
		{
		}

		public void RenderModel(bool inFocus = true, bool inSetRotation = true)
		{
		}

		public void Destroy(Stack<int> inFreeXPositions)
		{
		}
	}

	private Shader _particleShader;

	private float _lastClearAssetsTime;

	private int _spiralFrameColumn;

	private int _spiralFrameRow;

	private int _spiralFrameColumnMax;

	private int _spiralFrameColumnLastMax;

	private int _spiralFrameRowMax;

	[SerializeField]
	private Texture2D _spiralTexture;

	private float _iconRotationDegrees;

	[SerializeField]
	private List<IconManagerEntry> _iconEntries;

	private Stack<int> _freeXPositions;

	public override void Init()
	{
	}

	private static Bounds CalculateBounds(GameObject inGameObject, List<string> inFocusNames)
	{
		return default(Bounds);
	}

	public override void MUpdate()
	{
	}

	private bool Assign2DIconToRawImage(IconManagerEntry inEntry, Item inItem, BaseDef inDef, BaseInfo inInfo, Action inFailureCallback)
	{
		return default(bool);
	}

	private bool Assign3DIconToRawImage(IconManagerEntry inEntry, Item inItem, BaseDef inDef, BaseInfo inInfo, Icon3DTextureSize inIcon3DTextureSize, List<string> inFocusNames, Action inFailureCallback)
	{
		return default(bool);
	}

	public void AssignIconToRawImage(Item inItem, BaseDef inDef, BaseInfo inInfo, RawImage inImage, Icon3DTextureSize inIcon3DTextureSize = Icon3DTextureSize.Medium, Icon3DAnimationType in3DAnimationType = Icon3DAnimationType.Updating, bool inForce3D = false, [Optional] List<string> inFocusNames)
	{
	}

	public void ReleaseIconFromRawImage(RawImage inImage)
	{
	}

	public void RefreshIconFromRawImage(RawImage inImage)
	{
	}

	public Transform GetIconTargetFromRawImage(RawImage inImage)
	{
		return null;
	}

	public Camera GetRenderCameraFromRawImage(RawImage inImage)
	{
		return null;
	}

	private void ReleaseIconEntry(IconManagerEntry inEntry)
	{
	}

	private void RefreshIconEntry(IconManagerEntry inEntry)
	{
	}
}
