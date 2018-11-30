using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementController2 : MonoBehaviour

{
	public float thrust;
    public Rigidbody2D rb;
    public bool controlEnabled;

	private void Start()

	{
		rb=GetComponent<Rigidbody2D>();
        MetricManagerScript.instance.LogTime("starttime");
	}



	void FixedUpdate()

	{

		if (Input.GetKey(KeyCode.L))

		{
			Vector2 vec = new Vector2 (1, 0) * thrust;
			rb.AddForce(vec,0);

		}



		if (Input.GetKey(KeyCode.J))

		{
			Vector2 vec = new Vector2 (-1, 0) * thrust;
			rb.AddForce(vec,0);

		}



		if (Input.GetKeyUp(KeyCode.L))

		{

			rb.velocity = new Vector2(0,0);

		}



		if (Input.GetKeyUp(KeyCode.J))

		{

			rb.velocity = new Vector2(0,0);

		}

	}

}