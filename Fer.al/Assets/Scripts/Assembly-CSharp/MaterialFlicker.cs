using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MaterialFlicker : ManagedBehaviour
{
	[SerializeField]
	private GameObject[] _objects;

	[SerializeField]
	private string _colorName;

	[SerializeField]
	private string _shaderName;

	[SerializeField]
	[ColorUsage(false)]
	private Color _startingColor;

	[SerializeField]
	[Range(0f, 10f)]
	private float _startingRandomTimeMin;

	[SerializeField]
	[Range(0f, 10f)]
	private float _startingRandomTimeMax;

	[SerializeField]
	[ColorUsage(false)]
	private Color _flickerColor;

	[SerializeField]
	[Range(0f, 10f)]
	private float _flickerRandomTimeMin;

	[SerializeField]
	[Range(0f, 10f)]
	private float _flickerRandomTimeMax;

	private List<GameObject> _splitObjects;

	private List<Material> _flickerMaterials;

	public override void MStart()
	{
	}

	[IteratorStateMachine(typeof(<UpdateFlicker>d__12))]
	private IEnumerator UpdateFlicker()
	{
		return null;
	}

	private void UpdateColor(Color inColor)
	{
	}
}
