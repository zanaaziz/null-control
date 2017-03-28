using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	
	void Start(){
		renderer.material.color = Color.white;
	}
	
	void OnMouseEnter(){
		renderer.material.color = Color.yellow;
	}
	
	void OnMouseExit(){
		renderer.material.color = Color.white;
	}
}