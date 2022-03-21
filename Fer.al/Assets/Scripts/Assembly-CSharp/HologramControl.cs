using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HologramControl : ManagedBehaviour
{
	private Shader _hologramShader;

	private List<Material> _hologramMaterials;

	[SerializeField]
	private bool _waitForActorBase;

	[SerializeField]
	private bool _splitMaterials;

	[SerializeField]
	private bool _autoRotate;

	[SerializeField]
	private bool _removeTexture;

	[SerializeField]
	private bool _castShadows;

	[SerializeField]
	private bool _receiveShadows;

	[SerializeField]
	private bool _setColor;

	[SerializeField]
	private float _rotateTorque;

	[SerializeField]
	private float _glitchChance;

	[SerializeField]
	private float _rndMin;

	[SerializeField]
	private float _rndMax;

	[SerializeField]
	private float _rndGlowIntensityMin;

	[SerializeField]
	private float _rndGlowIntensityMax;

	[SerializeField]
	private float _rndGlitchIntensityMin;

	[SerializeField]
	private float _rndGlitchIntensityMax;

	[SerializeField]
	private float _glitchLoopWait;

	[SerializeField]
	private Color _hologramColor;

	[SerializeField]
	private Texture _alphaMask;

	private WaitForSeconds _glitchWait;

	public override void MStart()
	{
	}

	[IteratorStateMachine(typeof(<Init>d__21))]
	private IEnumerator Init()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<Glitch>d__23))]
	private IEnumerator Glitch(Material inMaterial)
	{
		return null;
	}
}
