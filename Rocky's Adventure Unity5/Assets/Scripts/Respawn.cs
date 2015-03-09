using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

	public GameObject hero;
	public GameObject respawnpoint;

		void OnCollisionEnter (Collision col) { 
			if(col.gameObject.name == "Obstacle_Water") { 
			gameObject.transform.position = respawnpoint.transform.position; 
			} 

			if(col.gameObject.name == "Obstacle_Pitfall") { 
			gameObject.transform.position = respawnpoint.transform.position; 
			} 
			if(col.gameObject.name == "Obstacle_Plane") { 
				gameObject.transform.position = respawnpoint.transform.position; 
			}
		
		} 
} 