using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuspicionManager : UnitySingleton {
    public float TimeLeft = 100;
    private int TimeUp = 0;
    public Text timerText;
    public GameObject movingArm;
    public GameObject clawArmWithSound;

    public GameObject successScreen;
   
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
        
       if (TimeLeft<=TimeUp && endtime == false)
        {
            endtime = true;
            TimeIsUp();
        } 
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
        Time.timeScale = 0.4f;
        movingArm.GetComponent<FaceMouse>().enabled=false;

        GameOver.SetActive(true);
        TryAgain.gameObject.SetActive(true);

        clawArmWithSound.GetComponent<AudioSource>().enabled = false;

        Cursor.visible = true;

        MetricManagerScript.instance.LogTime("endtime");
        StopTimeOnFall();
    }

    public void StopTimeOnFall()
    {
        StartCoroutine(EndGameWait()); 
    }

    public void TimeIsUp()
    {
        successScreen.SetActive(true);
        Time.timeScale = 0f;
        movingArm.GetComponent<FaceMouse>().enabled = false;
        MetricManagerScript.instance.LogTime("TimeOutTime");

        clawArmWithSound.GetComponent<AudioSource>().enabled = false;

        Cursor.visible = true;
    }

    IEnumerator EndGameWait()
    {
        yield return new WaitForSecondsRealtime(3);
        Time.timeScale = 0.0f;
    }

}
