using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public Transform projectile;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Mathf.Abs (Input.GetAxis ("Horizontal")) > 0.2) {
			transform.Rotate (0, Input.GetAxis ("Horizontal") * 5f, 0);
		}
	
		if (Input.GetButtonDown ("Fire2")) {
			Debug.Log ("coucou");
			Transform proj = GameObject.Instantiate(projectile,transform.position + 
			                                        (transform.forward * 2.0f), 
			                                        Quaternion.identity) as Transform;
			proj.GetComponent<Rigidbody>().AddForce(transform.forward * 50f, ForceMode.Impulse);
		}
	}
}
