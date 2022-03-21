using System.Runtime.CompilerServices;
using UnityEngine;

public class FeralCursor : MonoBehaviour
{
	[SerializeField]
	[Header("Cursor")]
	private Texture2D _cursor;

	[SerializeField]
	private Vector2 _cursorHotSpot;

	[SerializeField]
	[Header("Cursor Click")]
	private Texture2D _cursorClick;

	[SerializeField]
	private Vector2 _cursorClickHotSpot;

	private bool _override;

	private Texture2D _overrideCursor;

	private Vector2 _overrideCursorHotSpot;

	public static FeralCursor instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private void Awake()
	{
	}

	public void SetOverrideCursor(Texture2D inTexture, Vector2 inHotSpot)
	{
	}

	public void ResetOverrideCursor()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	private void SetCursor()
	{
	}
}
