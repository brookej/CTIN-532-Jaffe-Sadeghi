// Destroy everything that enters the trigger

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DestroyByContact : MonoBehaviour
{
    public GameObject Hat;
    public Rigidbody Pos;

    void OnTriggerEnter2D(Collider2D other)
	{
        
		if (other.gameObject == Hat) {

            //Player.gameObject.SetActive(false);
            //GameOver.gameObject.SetActive (true);
            ((SuspicionManager)(SuspicionManager.Instance)).EndGame();

            // Instantiate the projectile at the position and rotation of this transform
            Rigidbody clone;
            clone = Instantiate(Pos, transform.position, transform.rotation);

            // Give the cloned object an initial velocity along the current
            // object's Z axis
            clone.velocity = transform.TransformDirection(Vector2.right * 10);



            Cursor.visible = true;

            //Ask about the delay for explosion 
        }
    }
}