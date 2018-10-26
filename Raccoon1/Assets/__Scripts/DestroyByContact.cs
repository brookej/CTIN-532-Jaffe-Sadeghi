// Destroy everything that enters the trigger

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DestroyByContact : MonoBehaviour
{
	public GameObject Player;
	public GameObject Hat;
	public Text GameOver;
    public GameObject TryAgain;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject == Hat) {

            //Player.gameObject.SetActive(false);
            //GameOver.gameObject.SetActive (true);
            Time.timeScale = 0;
			GameOver.enabled = true;
            TryAgain.gameObject.SetActive(true);

            MetricManagerScript.instance.LogTime("endtime");
        }


    }
}

