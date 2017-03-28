using UnityEngine;
using System.Collections;

public class SurvivalBall : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void die(){
		Destroy(gameObject);
		GameObject PlayerObject = GameObject.FindGameObjectWithTag("Player");
		SurvivalPlayer player = PlayerObject.GetComponent<SurvivalPlayer>();
		player.spawnBall();
	}
}
