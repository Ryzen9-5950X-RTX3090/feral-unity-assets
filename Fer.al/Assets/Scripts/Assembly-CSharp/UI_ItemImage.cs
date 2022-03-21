using System;
using System.Runtime.InteropServices;
using DG.DeInspektor.Attributes;
using UnityEngine;
using UnityEngine.UI;
using WW.Waiters;

public class UI_ItemImage : MonoBehaviour
{
	[SerializeField]
	private RawImage _iconImage;

	private WW.Waiters.Waiter _iconLoadWaiter;

	private Item _item;

	private BaseDef _def;

	private Icon3DAnimationType _animationType;

	private Icon3DTextureSize _textureSize;

	private bool _force3d;

	public RawImage iconImage
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Setup(Item inItem, Icon3DTextureSize inTextureSize = Icon3DTextureSize.Medium, Icon3DAnimationType inAnimationType = Icon3DAnimationType.None, [Optional] Action aAssigned, bool inForce3D = false)
	{
	}

	public void Setup(BaseDef inDef, Icon3DTextureSize inTextureSize = Icon3DTextureSize.Medium, Icon3DAnimationType inAnimationType = Icon3DAnimationType.None, [Optional] Action aAssigned, bool inForce3D = false)
	{
	}

	private void OnItemDyed(ItemDyeResponse inMessage)
	{
	}

	private void OnDisable()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	public void DebugAssignIcon()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	public void DebugReleaseIcon()
	{
	}
}
