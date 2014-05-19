using UnityEngine;
using System.Collections;

public class JumpeBottun : MonoBehaviour {
	public bool is_landing;
	
	// Use this for initialization
	void Start () {
		is_landing = true;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (is_landing) {
			if (Input.GetMouseButtonDown (0)) {
				this.rigidbody.velocity = Vector3.up * 10.0f; 
				is_landing = false;
			}
		}
		
		
	}
	void OnCollisionEnter( Collision collision ){
		if (collision.gameObject.tag == "Floor") {
			is_landing = true;
		}
	}
	
}