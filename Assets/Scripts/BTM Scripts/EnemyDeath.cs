using UnityEngine;
using System.Collections;

public class EnemyDeath : MonoBehaviour {
	
	public static int EnemyLives = 5;
	
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
		
		EnemyLives = EnemyLives - 1;
		
		if(EnemyLives == 0){
			EnemyLives = 5;
			Application.LoadLevel(4);
		}
		
		GUIText elife = GameObject.Find("Enemy Live's").GetComponent<GUIText>();
		elife.text = "Lives: " +EnemyLives;
	}
}