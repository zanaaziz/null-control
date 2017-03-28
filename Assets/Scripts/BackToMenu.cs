using UnityEngine;
using System.Collections;

public class BackToMenu : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("escape")){
			Application.LoadLevel(0);
		}
	}
}
