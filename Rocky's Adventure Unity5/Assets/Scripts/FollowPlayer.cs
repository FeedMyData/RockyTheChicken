using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {
	
	public Transform trackedObject;
	private Vector3 lastPosition;
	
	// Use this for initialization
	void Start () {
		lastPosition = trackedObject.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position += trackedObject.position - lastPosition;
		lastPosition = trackedObject.position;
		transform.RotateAround(trackedObject.position, Vector3.up, Input.GetAxis("Horizontal")*3);
		/* transform.RotateAround(trackedObject.position, trackedObject.right, Input.GetAxis("Vertical") * 3); */
		transform.LookAt(trackedObject.position,Vector3.up); 
	}
}