using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBehavior : MonoBehaviour
{
    public AudioSource collectSound;
    public AudioClip collect;
    GameObject raccoonArm;
    float distanceToHand;
    public GameObject TrashRespawn;
    public float reachRange;
    public TrashSpawn spawn;

    void Start()
    {
        collectSound = GetComponent<AudioSource>();
        raccoonArm = GameObject.Find("ClawArm");
    }

    private void Update()
    {
        distanceToHand = Vector3.Distance(raccoonArm.transform.position, transform.position);
        if (distanceToHand < reachRange)
        {
            if (Input.GetMouseButtonDown(0))
            {
                CollectTrash();
                DeactivateTrash();
                // To do later-- add point value to score
            }
        }
    }

    void CollectTrash()
    {
        collectSound.PlayOneShot(collect);
        spawn.trashTracker--;
    } 

    void DeactivateTrash()
    {
        this.gameObject.SetActive(false);
    }
}