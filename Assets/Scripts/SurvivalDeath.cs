using UnityEngine;
using System.Collections;

public class SurvivalDeath : MonoBehaviour {
	
	public static int Lives = 5;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other){
		SurvivalBall ball = other.GetComponent<SurvivalBall>();
		
		if(ball){
			ball.die();
		}
		
		Lives = Lives - 1;
		
		if(Lives == 0){
			Lives = 5;
			Application.LoadLevel(3);
		}
		
		GUIText life = GameObject.Find("Live's").GetComponent<GUIText>();
		life.text = "Balls: " +Lives;
	}
}