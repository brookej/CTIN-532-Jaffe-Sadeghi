﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementController : MonoBehaviour
{
	public float thrust;
	public Rigidbody2D rb;
    public bool controlEnabled = false;

	private void Start()
	{
        Time.timeScale = 1;
        rb =GetComponent<Rigidbody2D>();
	}



	void FixedUpdate()

	{

		if (Input.GetKey(KeyCode.D))

		{
			Vector2 vec = new Vector2 (1, 0) * thrust;
			rb.AddForce(vec,0);

		}



		if (Input.GetKey(KeyCode.A))

		{
			Vector2 vec = new Vector2 (-1, 0) * thrust;
			rb.AddForce(vec,0);

		}



		if (Input.GetKeyUp(KeyCode.D))

		{

			rb.velocity = new Vector2(0,0);

		}



		if (Input.GetKeyUp(KeyCode.A))

		{

			rb.velocity = new Vector2(0,0);

		}


       
	}

}