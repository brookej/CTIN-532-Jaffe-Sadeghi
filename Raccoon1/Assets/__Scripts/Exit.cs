﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour {

    public GameObject player;
    public GameObject SuccessScreen;
    public GameObject ScoreDataSource;
    public Text PlayersScore;
    public Text FinalHighScore;
    public GameObject movingArm;

    public Scorekeeper scorekeeper;

    void OnTriggerEnter2D(Collider2D other)
    {

        Cursor.visible = true;
        if (other.gameObject == player)
        {
            movingArm.GetComponent<FaceMouse>().enabled = false;
            scorekeeper.addScore(100);
            SuccessScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }
}

