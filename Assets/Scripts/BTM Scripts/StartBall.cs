using UnityEngine;
using System.Collections;

public class StartBall : MonoBehaviour {
	
	private Transform MyTransform;
	
	void Awake(){
		MyTransform = transform;
	}

	// Use this for initialization
	void Start () {
		
		MyTransform.position = new Vector3(0, 0, -1.279986f);
		Physics.gravity = new Vector3(0, -8, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
