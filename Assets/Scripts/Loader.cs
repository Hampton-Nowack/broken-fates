﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//TODO: REMOVE THIS. THIS IS JUST FOR TESTING
using DungeonFloor; using SpecialDungeonRooms;

public class Loader : MonoBehaviour {

	public GameObject gameManager;
	public Text subNameText;
	public Text subDialogueText;

	// Use this for initialization
	void Awake () {
		if (GameManager.instance == null) {
			Instantiate (gameManager);

			//gameController.GetComponent<DialogueManager>().nameText = subNameText;
			//gameController.GetComponent<DialogueManager>().dialogueText = subDialogueText;
		}
	}
}
