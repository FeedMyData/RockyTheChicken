using UnityEngine;
using System.Collections;

public class grounded_detection : MonoBehaviour {

	public Animator animator;
	public bool IsGrounded;
	public bool envol;
	
	void OnCollisionStay (Collision collisionInfo)
	{
		IsGrounded = true;
	}
	
	void OnCollisionExit (Collision collisionInfo)
	{
		IsGrounded = false;
	}


	void Update()
	{
		if (IsGrounded) 
		{
			animator.SetBool ("vol", false);
		}
		 
		else 
		{
			animator.SetBool ("vol", true);
		}
	}
	


}
