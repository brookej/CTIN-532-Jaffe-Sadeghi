// Destroy everything that enters the trigger

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class DestroyByContact : MonoBehaviour
{
    public GameObject Hat;
    public Rigidbody Pos;

    public GameObject appleRigidbody;
    public GameObject sandwichRigidbody;

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

            // Iterate through the list of collected trash types
            foreach (KeyValuePair<TrashType,int> keyValue in FindObjectOfType<Scorekeeper>().trashCollected)
            {
                GameObject spawnedTrash = null;
                //spawn different prefabs based on the trash type
                switch (keyValue.Key)
                {
                    case TrashType.Apple:
                        spawnedTrash = Instantiate(appleRigidbody, transform.position, transform.rotation);
                        break;
                    case TrashType.Sandwich:
                        spawnedTrash = Instantiate(sandwichRigidbody, transform.position, transform.rotation);
                        break;
                }

                if (spawnedTrash != null) //if trash is spawned successfully...
                {
                    //launch in a random direction
                    spawnedTrash.GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle * 10;
                }

            }


            Cursor.visible = true;

            //Ask about the delay for explosion 
        }
    }
}