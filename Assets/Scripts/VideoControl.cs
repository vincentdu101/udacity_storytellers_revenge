using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RenderHeads.Media.AVProVideo;

public class VideoControl : MonoBehaviour {

//	private UnityEngine.Video.VideoPlayer videoPlayer;


//	[SerializeField]
//	private AudioSource audioSource;
	public GameObject camera;
	public Text videoChosen; 
	public MediaPlayer video1;
	public MediaPlayer video2;

	private MediaPlayer currentVideo;

	void Start () {
//		videoPlayer = GetComponent<UnityEngine.Video.VideoPlayer> ();
//
//
//		if (videoPlayer.clip != null) 
//		{
//			videoPlayer.EnableAudioTrack (0, true);
//			videoPlayer.SetTargetAudioSource(0, audioSource);
//		}


	}

	//Check if input keys have been pressed and call methods accordingly.
	void Update(){
		//Play or pause the video.
//		if (Input.anyKeyDown) 
//		{
//			if (currentVideo != null && currentVideo.Control.IsPlaying()) {
//				currentVideo.Control.Pause();
//				GameObject controls = GameObject.Find ("Controls");
//				Vector3 position = controls.transform.position;
//				position.z -= 3;
//				camera.transform.position = position;
//			}
//
//		}

	}

	public void Pause() {
		GameObject controls = GameObject.Find ("Controls");
		Vector3 position = controls.transform.position;
		position.z -= 3;
		camera.transform.position = position;
	}

	public void Play() {
		GameObject videoPlayerObj = GameObject.Find (videoChosen.text + "VideoPlayer");
		Vector3 position = videoPlayerObj.transform.position;
		position.z -= 3;
		camera.transform.position = position;

		if (videoChosen.text == "Iceland") {
			video1.Control.Play ();
		} else {
			video2.Control.Play ();
		}
	}

	public void goToMainMenu() {
		GameObject mainMenu = GameObject.FindGameObjectWithTag ("MainMenu");
		Vector3 position = mainMenu.transform.position;
		position.z -= 3;
		camera.transform.position = position;
	}
}