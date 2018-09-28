using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBehavior : MonoBehaviour
{
    public AudioSource collectSound;
    GameObject raccoonArm;
    float distanceToHand;
    public GameObject TrashRespawn;
    public float reachRange;
    public TrashSpawn spawn;

    void Start()
    {
        collectSound = FindObjectOfType<AudioSource>();
        raccoonArm = GameObject.Find("ClawArm");
    }

    private void Update()
    {
        distanceToHand = Vector3.Distance(raccoonArm.transform.position, transform.position);
        if (distanceToHand < reachRange)
        {
            if (Input.GetMouseButtonDown(0))
            {
                collectSound.Play();
                spawn.SpawnTrash();
                // To do later-- add point value to score
                this.gameObject.SetActive(false);
            }
        }
    }
}