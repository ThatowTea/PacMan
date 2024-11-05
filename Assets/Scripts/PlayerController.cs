﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
    public float speed;
    private Rigidbody rb;
	public scorer myScore;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
         float moveHorizontal = Input.GetAxis ("Horizontal");
         float moveVertical = Input.GetAxis ("Vertical");
         Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
         rb.AddForce (movement * speed);
     }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
			myScore.AddScore (1);
        }
    }
}
