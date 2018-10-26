// Destroy everything that enters the trigger

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DestroyByContact : MonoBehaviour
{
    public GameObject Hat;

    void OnTriggerEnter2D(Collider2D other)
	{
        Cursor.visible = true;
		if (other.gameObject == Hat) {

            //Player.gameObject.SetActive(false);
            //GameOver.gameObject.SetActive (true);
            ((SuspicionManager)SuspicionManager.Instance).EndGame();
        }
    }
}

