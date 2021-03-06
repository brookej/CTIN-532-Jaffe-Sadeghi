﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//enumerator which defines the different trash types
public enum TrashType
{
    Apple,
    Sandwich
}

public class TrashBehavior : MonoBehaviour
{
    public AudioSource collectSound;
    public AudioClip collect;
    GameObject raccoonArm;
    float distanceToHand;
    public GameObject TrashRespawn;
    public float reachRange;
    public TrashSpawn spawn;
    public int scoreValue;
    public TrashType myType; //the type of this trash

    public Scorekeeper scorekeeper;

    void Start()
    {
        collectSound = GetComponent<AudioSource>();
        raccoonArm = GameObject.Find("ClawArm");
        scorekeeper = GameObject.Find("MasterScorekeeper").GetComponent<Scorekeeper>();
    }

    private void Update()
    {
        distanceToHand = Vector3.Distance(raccoonArm.transform.position, transform.position);
        if (distanceToHand < reachRange)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {

                CollectTrash();
                DeactivateTrash();
                scorekeeper.addScore(scoreValue);
               

                //add to the trash collected per type table
                if (scorekeeper.trashCollected.ContainsKey(myType)) //does the table already contain data for my trash type?
                {
                    //if yes, add to the type's record
                    scorekeeper.trashCollected[myType] += 1;
                }else{
                    //if no, add the key to the record and initialize with 1
                    scorekeeper.trashCollected.Add(myType, 1);
                }
            }
        }
    }

    void CollectTrash()
    {
        collectSound.PlayOneShot(collect);
    } 

    void DeactivateTrash()
    {
        this.gameObject.SetActive(false);
        //need to change 
    }
}