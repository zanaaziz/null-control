using UnityEngine;
using System.Collections;

public class SurvivalCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter (Collision collision){
		foreach(ContactPoint contact in collision.contacts){
			if(contact.thisCollider == collider){
				// Paddles contact point
				
				float english = contact.point.x - transform.position.x;
				
				contact.otherCollider.rigidbody.AddForce(500f * english, 0, 0);
			}
		}
	}
}
