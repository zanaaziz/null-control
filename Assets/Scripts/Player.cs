using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public GameObject ballPrefab;
	GameObject attachedBall = null;

	// Use this for initialization
	void Start () {
	spawnBall();
	}
	
	public void spawnBall(){
		if(ballPrefab == null){
			Debug.Log("No ball conected.");
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
			attachedBall.rigidbody.AddForce(300f * Input.GetAxis("Horizontal"), 400f, 0);
			attachedBall = null;
			}
		}
	}
}