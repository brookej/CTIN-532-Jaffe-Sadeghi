using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomMovement : MonoBehaviour
{
	public float thrust;
    public Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))

        {
            Vector2 vec = new Vector2(1, 0) * thrust;
            rb.AddForce(vec * Time.deltaTime, 0);
        }



        if (Input.GetKey(KeyCode.A))

        {
            Vector2 vec = new Vector2(-1, 0) * thrust;
            rb.AddForce(vec * Time.deltaTime, 0);
        }



        if (Input.GetKeyUp(KeyCode.D))

        {
            rb.velocity = new Vector2(0, 0);
        }



        if (Input.GetKeyUp(KeyCode.A))

        {
            rb.velocity = new Vector2(0, 0);
        }
    }
}
