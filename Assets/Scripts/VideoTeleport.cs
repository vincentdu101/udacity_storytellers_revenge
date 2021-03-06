﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoTeleport : MonoBehaviour {

	public GameObject camera;
	public Text videoChosen;
	public Text creditsVideoChosen;

	// Use this for initialization
	void Start () {
		camera = GameObject.FindGameObjectWithTag ("MainCameraWrapper");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void goToVideo(string choice) {
		GameObject controls = GameObject.FindGameObjectWithTag ("Controls");
		Vector3 position = controls.transform.position;
		position.z -= 3;
		camera.transform.position = position;
		videoChosen.text = choice;
		creditsVideoChosen.text = choice;
	}
}
