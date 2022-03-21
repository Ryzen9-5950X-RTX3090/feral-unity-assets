using ThisOtherThing.UI.Shapes;
using UnityEngine;
using UnityEngine.UI;

public class UI_FieldStatusIndicator : MonoBehaviour
{
	public enum FieldStatus
	{
		Empty,
		Verifying,
		Invalid,
		Valid
	}

	[SerializeField]
	private WWImage _statusImage;

	[SerializeField]
	private Rectangle _backgroundRectangle;

	[SerializeField]
	private Rectangle _statusBorderRectangle;

	[SerializeField]
	[Header("Sprites")]
	private Sprite _emptySprite;

	[SerializeField]
	private Sprite _verifyingSprite;

	[SerializeField]
	private Sprite _invalidSprite;

	[SerializeField]
	private Sprite _validSprite;

	[SerializeField]
	[Header("Background Colors")]
	private Color _offColor;

	[SerializeField]
	private Color _onColor;

	[SerializeField]
	[Header("Border Colors")]
	private Color _emptyColor;

	[SerializeField]
	private Color _verifyingColor;

	[SerializeField]
	private Color _invalidColor;

	[SerializeField]
	private Color _validColor;

	[SerializeField]
	[Header("Audio")]
	private FeralAudioEmitter _validSoundFX;

	[SerializeField]
	private FeralAudioEmitter _invalidSoundFX;

	[SerializeField]
	private FeralAudioEmitter _emptySoundFX;

	private FieldStatus? _currentStatus;

	private void OnEnable()
	{
	}

	private void Reset()
	{
	}

	public void SetStatus(FieldStatus inStatus, bool inPlayAudio = true)
	{
	}
}
