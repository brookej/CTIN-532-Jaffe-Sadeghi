﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scream : MonoBehaviour
{
    public AudioSource Scream1;
    public AudioClip Scream1clip;
    public GameObject head;
    public GameObject FacePanic;
    public GameObject FaceNormal;
    public GameObject Hat;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == head)
        {
            FaceNormal.SetActive(false);
            FacePanic.SetActive(true);
            Hat.SetActive(false);
            Scream1.PlayOneShot(Scream1clip);
            
        }

       // else if (other.gameObject == FacePanic)
        //{

            //FaceNormal.SetActive(true);
            //FacePanic.SetActive(false);

        //}
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == head)
        {
            FaceNormal.SetActive(true);
            FacePanic.SetActive(false);
            Hat.SetActive(true);
        }
    }
}
