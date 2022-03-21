using System;

[Serializable]
public struct Achievement
{
	public int achievementId;

	public int progress;

	public int count;

	public bool collectedAward;

	public string ts;

	public bool didUnlock;
}
