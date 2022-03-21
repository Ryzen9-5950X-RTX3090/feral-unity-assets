using Boxophobic;
using UnityEngine;

public class ADSGlobalMotion : MonoBehaviour
{
	public enum UpdateMode
	{
		Off,
		On
	}

	[BCategory("Update")]
	public int category_Update;

	public UpdateMode realtimeUpdate;

	[BMessage("Warning", "Please note that Motion Speed, Turbulence Speed and Turbulence Scale won't work properly with contiunous realtime update!", 5f, 0f)]
	public bool message_Update;

	[BCategory("Motion")]
	public int category_Motion;

	public float motionAmplitude;

	public float motionSpeed;

	public float motionScale;

	[BCategory("Turbulence")]
	public int category_Turbulence;

	public Texture2D turbulenceTexture;

	public float turbulenceContrast;

	public float turbulenceSpeed;

	public float turbulenceScale;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void SetGlobalShaderProperties()
	{
	}
}
