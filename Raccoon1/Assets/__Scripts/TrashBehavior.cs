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
    public int scoreValue;

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
        //need to change 
    }
}