using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactionSpriteSwap : MonoBehaviour {
    public GameObject normal;
    public GameObject reaction;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            normal.SetActive(false);
            reaction.SetActive(true);
        }
    }
}
