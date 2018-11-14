using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuccessScoreGetter : MonoBehaviour {
    public Scorekeeper keeper;
    public Text HighScoreText;
    public Text PlayerScoreText;
    private int playerScore;
    private int highScore;

    void Start()
    {
        highScore = keeper.highScore;
        playerScore = keeper.score;
        DisplayScores();
    }

    void DisplayScores()
    {
        HighScoreText.text = "" + highScore;
        PlayerScoreText.text = "" + playerScore;
    }
}
