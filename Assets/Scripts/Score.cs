using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	
	public float score = 0;
	public static int IntScore = 0;
	
	void Awake(){
		IntScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(SurvivalPlayer.attachedBall){
			return;
			
		}else{
			score = score + 10 * Time.deltaTime;
			IntScore = (int)score;
			GUIText scorer = GameObject.Find("Score").GetComponent<GUIText>();
			scorer.text = "Score: " +IntScore.ToString();
		}
	}
}