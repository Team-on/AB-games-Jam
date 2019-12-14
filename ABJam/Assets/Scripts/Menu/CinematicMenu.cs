﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicMenu : MenuBase {
	public override void Show() {
		canvasGroup.interactable = canvasGroup.blocksRaycasts = true;
		LeanTween.value(gameObject, canvasGroup.alpha, 1.0f, 0.2f)
		.setOnUpdate((float a) => {
			canvasGroup.alpha = a;
		});
		OnEnter();
	}

	public override void Hide() {
		canvasGroup.interactable = canvasGroup.blocksRaycasts = false;
		LeanTween.value(gameObject, canvasGroup.alpha, 0.0f, 0.2f)
		.setOnUpdate((float a) => {
			canvasGroup.alpha = a;
		});
		OnExit();
	}

	public void ToGameMenu() {
		MenuManager.TransitTo(MenuManager.GetNeededMenu<MenuGame>());
	}
}
