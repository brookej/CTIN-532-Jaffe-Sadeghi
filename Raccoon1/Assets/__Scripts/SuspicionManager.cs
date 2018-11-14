using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuspicionManager : UnitySingleton {
    public float TimeLeft = 100;
    private int TimeUp = 0;
    public Text timerText;
    public GameObject movingArm;
   
    public GameObject GameOver;
    public GameObject TryAgain;

    bool endtime;


    public void Start()
    {
        endtime = false;
        movingArm = GameObject.Find("ArmHolder");    
    }

    public void Update()
    {
        TimerUpdate();
        TimerDisplay();

        //var end : EndGame[];
        //int end = 1;
        //I'm fucking idiot, those aren't variables

       if (TimeLeft<=TimeUp && endtime == false)
        {
            endtime = true;
            EndGame();

        } 

        //Add a boolean to reference the "endtime"

    }

    public void TimerUpdate()
    {
        TimeLeft -= Time.deltaTime;
    }

    public void TimerDisplay()
    {
        timerText.text = "" + Mathf.Round(TimeLeft);
    }


    public void EndGame()
    {
        Time.timeScale = 0;
        movingArm.GetComponent<FaceMouse>().enabled=false;

        GameOver.SetActive(true);
        TryAgain.gameObject.SetActive(true);

        Cursor.visible = true;

        MetricManagerScript.instance.LogTime("endtime");
    }
}
