using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	
	public Transform Target;
	public float Speed;
	private Transform myPos;
	
	void Awake(){
		myPos = transform;
	}

	void Start () {
		
		// Locks onto the Ball
		
		GameObject ballObj = GameObject.FindGameObjectWithTag("BallPos");
		Target = ballObj.transform;
	}
	
	void Update () {
		// Moves with the ball.
		
		myPos.position = new Vector3(Target.position.x * Speed * Time.deltaTime, 5f, -1.364608f);
	}
}