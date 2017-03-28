using UnityEngine;
using System.Collections;

public class Thanks : MonoBehaviour {
	
	float delay;
	
	// Update is called once per frame
	void Update () {
	delay = delay + 1 * Time.deltaTime;
	int iDelay = (int)delay;
		
	if(iDelay == 5){
			Application.LoadLevel(0);;
		}
	}
}
