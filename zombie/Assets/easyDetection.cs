using UnityEngine;
using System.Collections;

public class easyDetection : MonoBehaviour {
	public bool detected=false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		Vector3 fwd = transform.TransformDirection (Vector3.forward);
		Debug.DrawRay (transform.position, fwd);
		if(Physics.Raycast(transform.position,fwd,100)){
			detected=true;
		}
			else{
				detected=false;}

	
	}
}
