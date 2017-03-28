using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void die(){
		Destroy(gameObject);
		GameObject PlayerObject = GameObject.FindGameObjectWithTag("Player");
		Player player = PlayerObject.GetComponent<Player>();
		player.spawnBall();
	}
}
