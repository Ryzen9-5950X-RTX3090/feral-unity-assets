using System;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
	int Interactions();

	float Timer();

	Transform Transform();

	Vector3 Offset();

	List<string> ActionIconDefIds();

	List<Action> InteractActions();

	void OnInteractionStart();

	void OnInteractionCancel();

	void RequestInteraction(Interactable.EInteractableMessage inInteractionType);
}
