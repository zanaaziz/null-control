using UnityEngine;
using System.Collections;

public class SurvivalScore : MonoBehaviour {
	
	int Final = Score.IntScore;

	// Use this for initialization
	void Start () {
	GUIText results = GameObject.Find("Result").GetComponent<GUIText>();
		
		results.text = Final +" Points!";
		Final = 0;
	}
}