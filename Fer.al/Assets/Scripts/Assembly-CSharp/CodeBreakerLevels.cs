using System.Collections.Generic;
using DG.DeInspektor.Attributes;
using UnityEngine;

[CreateAssetMenu]
public class CodeBreakerLevels : ScriptableObject
{
	public int FirstGuessBonus;

	public int LastIngredientBonus;

	[Header("Levels")]
	public CodeBreakerLevel tutorialLevel;

	public List<CodeBreakerLevel> levels;

	[DeMethodButton(null, 0, new object[] { })]
	public void TransferDataToPropertyEditor()
	{
	}
}
