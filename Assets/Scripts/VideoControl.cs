﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RenderHeads.Media.AVProVideo;
using Gvr.Internal;

public class VideoControl : MonoBehaviour {

//	private UnityEngine.Video.VideoPlayer videoPlayer;


//	[SerializeField]
//	private AudioSource audioSource;
	public GameObject camera;
	public Text videoChosen; 
	public MediaPlayer video1;
	public MediaPlayer video2;
	public MediaPlayer videoPlayer;
	public GvrAudioSource audioSource;
	public GameObject videoSphere;
	private MediaPlayer currentVideo;

	void Start () {
		audioSource = GameObject.FindGameObjectWithTag ("Audio").GetComponent<GvrAudioSource>();
	}

	//Check if input keys have been pressed and call methods accordingly.
	void Update(){
		if (videoPlayer && videoPlayer.Control.IsFinished ()) {
			GoToPanel ("Credits");
		}
	}

	private void toggleParticleSystem(GameObject videoPlayer, bool visible) {
		ParticleSystem particles = videoPlayer.GetComponent<ParticleSystem> ();
		var emission = particles.emission;
		emission.enabled = visible;
	}

	public void Pause() {
		videoPlayer.Control.Pause ();
	}


	public void Play() {
		GameObject videoPlayerObj = GameObject.Find (videoChosen.text + "VideoPlayer");
		GameObject videoPlayerWrapper = GameObject.Find (videoChosen.text);
		Vector3 position = videoPlayerObj.transform.position;
		toggleParticleSystem (videoPlayerWrapper, false);
		position.z -= 3;
		camera.transform.position = position;
		audioSource.Pause ();

		if (videoChosen.text == "Iceland") {
			video1.Control.Play ();
		} else {
			video2.Control.Play ();
		}
	}


	public void PlayBtn() {
		videoPlayer.Control.Play ();
	}

	public void Restart() {
		videoPlayer.Control.Seek (0.0f);
	}

	public void GoToPanel(string tag) {
		if (videoChosen) {
			GameObject mainMenu = GameObject.FindGameObjectWithTag (tag);
			GameObject videoPlayerWrapper = GameObject.Find (videoChosen.text);
			Vector3 position = mainMenu.transform.position;
			toggleParticleSystem (videoPlayerWrapper, true);
			position.z -= 3;
			camera.transform.position = position;
			if (videoPlayer) {
				videoPlayer.Control.Pause ();
				videoPlayer.Control.Seek (0.0f);
			}
			audioSource.Play ();
		}
	}

	public void BackToControls() {
		GoToPanel ("Controls");

	}

	public void goToMainMenu() {
		GoToPanel ("MainMenu");
	}

	public void VideoPlayerEvents() {

	}
}