using UnityEngine;
using System.Collections;

public class SurvivalPlayer : MonoBehaviour {
	
	public GameObject ballPrefab;
	public static GameObject attachedBall = null;

	// Use this for initialization
	void Start () {
	spawnBall();
	}
	
	public void spawnBall(){
		if(ballPrefab == null){
			return;
		}
		
		attachedBall = (GameObject)Instantiate(ballPrefab,  transform.position + new Vector3(0, .5f, 0), Quaternion.identity);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	void LateUpdate(){
		if(attachedBall){
			Rigidbody ballRigidBody = attachedBall.rigidbody;

			ballRigidBody.position = transform.position + new Vector3(0, .5f, 0);
			
			if(Input.GetButtonDown("Jump")){
				
			attachedBall.rigidbody.isKinematic = false;
			attachedBall.rigidbody.AddForce(300f * Input.GetAxis("Horizontal"), 800f, 0);
			attachedBall = null;
				
			}
		}
	}
	
	void OnCollisionEnter(Collision col){
		Physics.gravity = new Vector3(0, 0, 0);
	}
}