using System;

[Serializable]
public enum BundleQueue
{
	HighPriority,
	Level,
	UI,
	AvatarLocalMesh,
	AvatarLocalAnim,
	AvatarLocalAcc,
	AvatarNetworkMesh,
	AvatarNetworkAnim,
	AvatarNetworkAcc,
	DenItemData,
	DenItemMesh,
	Music,
	Sound,
	Default,
	LowPriority
}
