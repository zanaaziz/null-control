using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {
	
	public float speed;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 movement = new Vector3(Input.GetAxis("Default") * Time.deltaTime * speed, 0, 0);
		transform.Translate(movement);
	}
}
