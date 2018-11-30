using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorekeeper : MonoBehaviour {
    public Text scoreText;
    public Text highScoreText;
    public int highScore;
    public int score;

    public bool exploded { get; set; }

    //the table which tracks how many trash has been collected per type
    public Dictionary<TrashType, int> trashCollected;

    void Start () {
        trashCollected = new Dictionary<TrashType, int>(); //initiate the trash collected table (always do this for dictionaries!)
        trashCollected.Add(TrashType.Apple, 0);
        trashCollected.Add(TrashType.Sandwich, 0);
        score = 0;
        UpdateScore();
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore",0);
        highScore = PlayerPrefs.GetInt("HighScore");
        exploded = false;
	}

    public void addScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    private void Update()
    {
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            highScoreText.text = "High Score: " + highScore;
        }
    }

    void UpdateScore () {
        scoreText.text = "Score: " + score;
	}
}
