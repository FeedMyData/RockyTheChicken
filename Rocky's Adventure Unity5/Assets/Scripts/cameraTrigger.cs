using UnityEngine;
using System.Collections;

public class cameraTrigger : MonoBehaviour {

	public Camera mainCam;
	public Camera beachCam;
	public float zoomSpeed = 20;

	// Use this for initialization
	void Start () {
		beachCam.enabled = true;
		mainCam.enabled = false;
	}
	
	void OnTriggerEnter(Collider col){

		if (beachCam.enabled = true){
			mainCam.enabled = true;
			beachCam.enabled = false;
		}

		if (beachCam.enabled = false){
			mainCam.enabled = false;
			beachCam.enabled = true ;
		} 


		}
	}

