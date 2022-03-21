using System.Collections.Generic;
using UnityEngine;

public class HintCube : MonoBehaviour
{
	public int codeHintIndex;

	public CodeHintType currentHint;

	public Renderer hintRenderer;

	[EnumList(typeof(CodeHintType), 0.35f)]
	public List<Material> hintTypeMaterials;

	private void Start()
	{
	}

	public void SetHintType(CodeHintType inHint)
	{
	}

	private void OnValidate()
	{
	}
}
