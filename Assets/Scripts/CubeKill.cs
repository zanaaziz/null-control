using UnityEngine;
using System.Collections;

public class CubeKill : MonoBehaviour {
		
	public AudioClip[] BrickSFX;
	static int numBricks = 0;
	
	void Start(){
		numBricks++;
	}

	void OnCollisionEnter(Collision col){
		
		Destroy(gameObject);
		AudioSource.PlayClipAtPoint(BrickSFX[0], transform.position);
		
		numBricks--;
		
		if(numBricks == 0 && Application.loadedLevel == 2){
			Application.LoadLevel(6);
		}
				
		else if(numBricks == 0 && Application.loadedLevel == 6){
			Application.LoadLevel(7);
		}
		
		else if(numBricks == 0 && Application.loadedLevel == 7){
			Application.LoadLevel(4);
		}
	}
}