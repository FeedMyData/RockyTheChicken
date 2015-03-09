using UnityEngine;
using System.Collections;

public class SoundScript: MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetButtonDown( "Horizontal" ) || Input.GetButtonDown( "Vertical" ) )
			GetComponent<AudioSource>().Play();
		else if ( !Input.GetButton( "Horizontal" ) && !Input.GetButton( "Vertical" ) && GetComponent<AudioSource>().isPlaying )
			GetComponent<AudioSource>().Pause();
}
}