using UnityEngine;
using System.Collections;

public class BGAnimation : MonoBehaviour {
	
	public float RotationSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Rotate(0, 0, RotationSpeed * Time.deltaTime);
	}
}
