using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {
	
	int Lives = 3;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other){
		Ball ball = other.GetComponent<Ball>();
		
		if(ball){
			ball.die();
		}
		
		Lives = Lives - 1;
		
		if(Lives == 0){
			Lives = 3;
			Application.LoadLevel(0);
		}
		
		GUIText life = GameObject.Find("GUIText").GetComponent<GUIText>();
		life.text = "Balls: " +Lives;
	}
}