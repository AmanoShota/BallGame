using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private int frame_count;
	
	// Use this for initialization
	void Start () {
		//Debug.Log ("Ball called");
		//	frame_count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//frame_count++;
		//if(frame_count == 30){
		//	frame_count = 0;
		//	Debug.Log ("Ball called yes");
	}
	
	//		void OnCollisionEnter(Collision collision){
	//		if(colliision.gameObject
	
	void OnBecameInvisible()
	{
		Destroy (this.gameObject);
	}
}