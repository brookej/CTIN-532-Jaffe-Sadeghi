using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuspicionManager : UnitySingleton {
    private float currentSuspicionValue = 100;
    private int suspicionMax = 0;
    public Text suspicionLevelText;
    public int suspicionUpdateThreshold = 60;
    public GameObject movingArm;
   
    public Text GameOver;
    public GameObject TryAgain;

    bool endtime;


    public void Start()
    {
        endtime = false;
        movingArm = GameObject.Find("ArmHolder");    
    }

    public void Update()
    {
        SuspicionUpdate();
        SuspicionDisplay();

        //var end : EndGame[];
        //int end = 1;
        //I'm fucking idiot, those aren't variables

       if (currentSuspicionValue<=suspicionMax && endtime == false)
        {
            endtime = true;
            EndGame();

        } 

        //Add a boolean to reference the "endtime"

    }

    public void SuspicionUpdate()
    {
        currentSuspicionValue -= Time.deltaTime;
    }

    public void SuspicionDisplay()
    {
        suspicionLevelText.text = "⌚ " + Mathf.Round(currentSuspicionValue);
    }


    public void EndGame()
    {
        Time.timeScale = 0;
        movingArm.GetComponent<FaceMouse>().enabled=false;

        //ask about how to disable scripts like movementcontroller and claw

        GameOver.enabled = true;
        TryAgain.gameObject.SetActive(true);

        Cursor.visible = true;

        MetricManagerScript.instance.LogTime("endtime");
    }
}
