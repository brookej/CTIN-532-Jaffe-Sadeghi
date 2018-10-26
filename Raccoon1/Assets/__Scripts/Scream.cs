using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scream : MonoBehaviour
{
    public AudioSource Scream1;
    public AudioClip Scream1clip;
    public GameObject FacePanic;
    public GameObject FaceNormal;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject == FaceNormal)
        {

            FaceNormal.SetActive(false);
            FacePanic.SetActive(true);
            Scream1.PlayOneShot(Scream1clip);
            
        }

        else if (other.gameObject == FacePanic)
        {

            FaceNormal.SetActive(true);
            FacePanic.SetActive(false);

        }
    }
}
