﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class PlayerController : MonoBehaviour {
    private Rigidbody m_rb;
	// Use this for initialization
	void Start () {
        m_rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void FixedUpdate()
    {
        // get user input to add left right force to our player object

        float movement = Input.GetAxis("Horizontal");

        m_rb.AddForce(new Vector3(movement, 0.0F, 0.0F));

    }
}
