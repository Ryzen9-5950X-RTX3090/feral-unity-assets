using UnityEngine;

namespace Prototype
{
	[CreateAssetMenu]
	public class ObjectiveDialogData : ScriptableObject
	{
		[Tooltip("Intro to the objective before start dialog.")]
		public DialogData objectiveIntroDialog;

		[Tooltip("Question given to player before the player accepts or denies the objective.")]
		public DialogData objectiveStartDialog;

		[Tooltip("Options for the player to accept the objective.")]
		public DialogData objectiveStartAcceptDialogOptions;

		[Tooltip("Options for the player to deny the objective.")]
		public DialogData objectiveStartDenyDialogOptions;

		[Tooltip("Response to player accepting the objective.")]
		public DialogData objectiveAcceptedDialog;

		[Tooltip("Response to player denying the objective.")]
		public DialogData objectiveDeniedDialog;

		[Tooltip("Response to player returning with objective completed.")]
		public DialogData objectiveCompleteDialog;

		[Tooltip("Response to player returning without objective completed.")]
		public DialogData objectiveInProgressDialog;

		[Tooltip("Response to player returning when the objective expires per time or fails.")]
		public DialogData objectiveFailedDialog;

		[Tooltip("All parts of objective complete.")]
		public DialogData objectiveCanCompleteDialog;

		[Tooltip("Options for the player to accept the completion of the objective.")]
		public DialogData objectiveCanCompleteAcceptDialogOptions;

		[Tooltip("Options for the player to deny the completion of the objective.")]
		public DialogData objectiveCanCompleteDenyDialogOptions;

		[Tooltip("Response to player turning in objective.")]
		public DialogData objectiveCanCompleteAcceptedDialog;

		[Tooltip("Response to player not turning in objective.")]
		public DialogData objectiveCanCompleteDeniedDialog;
	}
}
