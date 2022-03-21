using System.Runtime.CompilerServices;
using UnityEngine;

public class FX_P_Ember_Script : MonoBehaviour
{
	public delegate void OnVariableChangeDelegate(float newVal);

	[SerializeField]
	private float _emberSize;

	public float EmberSize
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public event OnVariableChangeDelegate OnVariableChange
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Start()
	{
	}

	public void VariableChangeHandler(float newVal)
	{
	}

	private void Update()
	{
	}
}
