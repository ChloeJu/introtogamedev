using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

	public Transform target;

    public float speed = 10;
    Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();


	}
	
	// Update is called once per frame

 /*   void FixedUpdate()
    {
		transform.LookAt(target);
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical);
		//rb.AddForce (movement * speed);
		rb.velocity = movement * speed;

    }*/
	void Update () {
		if(Input.GetAxisRaw("Horizontal")>0.5f||Input.GetAxisRaw("Horizontal")<-0.5f){
			transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal")*speed*Time.deltaTime,0f,0f));
				}
		if(Input.GetAxisRaw("Vertical")>0.5f||Input.GetAxisRaw("Vertical")<-0.5f){
			transform.Translate(new Vector3(0f,0f,Input.GetAxisRaw("Vertical")*speed*Time.deltaTime));
		}





	}
}
