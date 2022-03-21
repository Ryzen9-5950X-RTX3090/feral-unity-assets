using UnityEngine;

[ChartComponent("Season Pass")]
public class SeasonPassDefComponent : DefComponent
{
	[ChartList]
	public ChartDefList tiers;

	[ChartList]
	public ChartDefList challenges;

	[SerializeField]
	[ChartDef("BundlePack", new string[] { })]
	private string _purchaseableDef;

	public BaseDef PurchaseableDef
	{
		get
		{
			return null;
		}
	}
}
