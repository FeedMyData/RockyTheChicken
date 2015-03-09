using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	private bool canJump = true;
	private bool jumping = false;
	private Transform head;
	public float speedmove = 60;
	public float jumpheight = 20;
	public Camera mainCam ;
	
	// Use this for initialization
	void Start () {
		head = transform.Find("Corps");
	}
	
	
	// Update is called once per frame
	void Update () {
		Vector3 speed = GetComponent<Rigidbody>().velocity;
		speed.y = 0;
		GetComponent<Animator> ().SetFloat ("Speed", speed.magnitude);

	}
	
	// Modifs physiques
	void FixedUpdate()
	{
		Vector3 direction = new Vector3();
		direction += Input.GetAxis("Horizontal") * mainCam.transform.right;
		direction += Input.GetAxis("Vertical") * mainCam.transform.forward;
		direction.y = 0;
		
		Vector3 newVelocity = direction * speedmove;
		newVelocity.y = GetComponent<Rigidbody>().velocity.y;
		GetComponent<Rigidbody>().velocity = newVelocity;
		transform.LookAt(transform.position + direction);
		GetComponent<Rigidbody>().angularVelocity = new Vector3();
		
		Vector3 dirGaze = mainCam.transform.forward;
		dirGaze.y = 0;
 		//head.LookAt(head.position + dirGaze);
		
		
		if (Input.GetButtonDown("Jump") && canJump)
		{
			GetComponent<Rigidbody>().AddForce(Vector3.up * jumpheight, ForceMode.Impulse);
			canJump = false;
			jumping = true;
			GetComponent<Animator> ().SetTrigger ("JumpStart");
		}
	}
	
	void OnCollisionEnter(Collision col)
	{
		if (col.contacts[0].normal.y > 0.3f)
			canJump = true; 

		jumping = false;
	}
}
