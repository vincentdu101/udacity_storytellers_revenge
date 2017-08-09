using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoTeleport : MonoBehaviour {

	public GameObject camera;

	// Use this for initialization
	void Start () {
		camera = GameObject.FindGameObjectWithTag ("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void goToVideo(string choice) {
		GameObject videoPlayerObj = GameObject.FindGameObjectWithTag (choice + "Player");
		GameObject videoPlayer = GameObject.Find (choice + "VideoPlayer");
		Vector3 position = videoPlayerObj.transform.position;
		camera.transform.position = position;
		videoPlayer.SetActive (true);
	}
}
