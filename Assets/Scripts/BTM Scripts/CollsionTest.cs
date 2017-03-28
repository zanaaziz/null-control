using UnityEngine;
using System.Collections;

public class CollsionTest : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision wall){
		if(wall.gameObject.name == "Top Wall Collider"){
			
			transform.position = new Vector3(0,0,-1.279986f);
			rigidbody.velocity = Vector3.zero;
			rigidbody.angularVelocity = Vector3.zero;
			Physics.gravity = new Vector3(0,-8,0);
		}
		
		else if(wall.gameObject.name == "Bottom Wall Collider"){
			
			transform.position = new Vector3(0,0,-1.279986f);
			rigidbody.velocity = Vector3.zero;
			rigidbody.angularVelocity = Vector3.zero;
			Physics.gravity = new Vector3(0,-8,0);
		}
		else{
			return;
		}
	}
}
