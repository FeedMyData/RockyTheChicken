using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {
	public Transform cubeporte;

	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){
		Debug.Log ("Test"  + col.gameObject);
		cubeporte.GetComponent<Animator> ().SetBool("Ouvert", true);
	
	}

}
