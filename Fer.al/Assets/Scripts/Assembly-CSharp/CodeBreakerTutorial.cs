using System.Collections.Generic;
using UnityEngine;

public class CodeBreakerTutorial : MonoBehaviour
{
	public CodeBreakerGame game;

	public CodeBreakerDialogPopup tutorialDialog;

	public List<CodeBreakerTutorialStep> tutorialSteps;

	public GameObject tutorialButton;

	public GameObject quitButton;

	private int _tutorialState;

	private bool _showingQuitConfirmation;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void Restart()
	{
	}

	private void OnIngredientSelected(IngredientSelectedMessage inMessage)
	{
	}

	private void OnIngredientDropped(IngredientDropMessage inMessage)
	{
	}

	private void Update()
	{
	}

	private void GoToState(int inState)
	{
	}

	private void HandleStateLeave(int leaveState)
	{
	}

	private void HandleStateEnter(int enterState)
	{
	}

	private void HandleStateUpdate(int inState)
	{
	}

	public void BtnClicked_TutorialDrop()
	{
	}

	public void BtnClicked_TutorialMix()
	{
	}

	public void BtnClicked_TutorialQuitPopup()
	{
	}

	public void QuitPopupClosed()
	{
	}

	public void BtnClicked_TutorialPopup()
	{
	}

	public void TutorialPopupClosed()
	{
	}
}
