﻿using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

    public float speed = 10;
    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	
	}
	
	// Update is called once per frame

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
       rb.velocity = movement * speed;

    }
	void Update () {
	
	}
}
