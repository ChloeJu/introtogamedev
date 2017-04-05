using UnityEngine;
using System.Collections;

public class playerAnim : MonoBehaviour {
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetFloat ("vertical", Input.GetAxisRaw ("Vertical"));
		anim.SetFloat ("horizontal", Input.GetAxisRaw ("Horizontal"));
	
	}
}
