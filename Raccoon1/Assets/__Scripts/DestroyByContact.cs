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

            // Instantiate the projectile at the position and rotation of this transform
            Rigidbody clone;
            //clone = Instantiate(Pos, transform.position, transform.rotation);

            // Give the cloned object an initial velocity along the current
            // object's Z axis
            //clone.velocity = transform.TransformDirection(Vector2.right * 10);

            // Iterate through the list of collected trash types
            Scorekeeper sk = FindObjectOfType<Scorekeeper>();
            if (!sk.exploded)
            {
                Debug.Log("spawning trashes");
                GameObject spawnedTrash = null;

                Debug.Log(sk.trashCollected[TrashType.Apple]);
                for (int i = 0; i < sk.trashCollected[TrashType.Apple]; i++)
                {
                    Debug.Log("spawn apple");
                    spawnedTrash = Instantiate(appleRigidbody, other.transform.position, transform.rotation);
                    if (spawnedTrash != null) //if trash is spawned successfully...
                    {
                        //launch in a random direction
                        spawnedTrash.GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle * 10;
                    }
                }

                for (int j = 0; j < sk.trashCollected[TrashType.Sandwich]; j++)
                {
                    spawnedTrash = Instantiate(sandwichRigidbody, other.transform.position, transform.rotation);
                    if (spawnedTrash != null) //if trash is spawned successfully...
                    {
                        //launch in a random direction
                        spawnedTrash.GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle * 10;
                    }
                }

                sk.exploded = true;
            }


            ((SuspicionManager)(SuspicionManager.Instance)).EndGame();

            Cursor.visible = true;

            //Ask about the delay for explosion 
        }
    }
}