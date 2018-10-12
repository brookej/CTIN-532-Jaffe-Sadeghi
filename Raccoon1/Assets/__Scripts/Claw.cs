using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Claw : MonoBehaviour {
    public AudioSource clack;
    public AudioClip clackclip;
    public GameObject clawR;
    public GameObject clawL;
    public GameObject closedClaw;

	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            clawR.SetActive(false);
            clawL.SetActive(false);
            closedClaw.SetActive(true);
            clack.PlayOneShot(clackclip);
        }
        else if(Input.GetKeyUp(KeyCode.Space))
        {
            clawR.SetActive(true);
            clawL.SetActive(true);
            closedClaw.SetActive(false);
        }
     }
}
