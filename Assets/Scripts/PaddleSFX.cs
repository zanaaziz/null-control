using UnityEngine;
using System.Collections;

public class PaddleSFX : MonoBehaviour {
	
	public AudioClip[] sfx;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision collision){
		AudioSource.PlayClipAtPoint(sfx[0], transform.position);
	}
}
