using UnityEngine;
using System.Collections;

public class PlayerClamp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	float x_clamp = Mathf.Clamp(transform.position.x, -6.821734f, 6.821734f);
		transform.position = new Vector3(x_clamp, -5f, -1.20f);
	}
}
