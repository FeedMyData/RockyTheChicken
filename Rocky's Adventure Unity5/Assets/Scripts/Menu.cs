using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {


	public void ChangeToScene (string sceneToChange) {
		Application.LoadLevel (sceneToChange);
	}
}
