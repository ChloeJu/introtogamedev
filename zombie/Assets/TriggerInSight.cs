using UnityEngine;
using System.Collections;

public class TriggerInSight : MonoBehaviour {
	public GameObject indicator;
	dialogue box;
	// Use this for initialization

	public bool fk;
	void Start () {
		box = indicator.GetComponent<dialogue> ();
	
	}

	void OnTriggerStay(Collider other){
		Debug.Log ("sphere detected");
		fk = true;
	}

	void OnTriggerExit(Collider other){
		Debug.Log ("sphere leaves");
		fk = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
}
