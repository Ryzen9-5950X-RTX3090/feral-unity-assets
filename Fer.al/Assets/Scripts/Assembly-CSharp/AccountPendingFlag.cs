using System;

[Serializable]
[Flags]
public enum AccountPendingFlag
{
	CustomizationCompleted = 1,
	AccountRegistered = 2,
	NewsCrew = 4,
	TradeBlocked = 8,
	NeedsFastPass = 0x10
}
