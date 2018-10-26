using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuspicionManager : UnitySingleton {
    private float currentSuspicionValue = 0;
    private int suspicionMax = 100;
    public Text suspicionLevelText;
    public int suspicionUpdateThreshold = 60;
    public GameObject movingArm;
   
    public Text GameOver;
    public GameObject TryAgain;

    public void Start()
    {
        movingArm = GameObject.Find("ArmHolder");    
    }

    public void Update()
    {
        SuspicionUpdate();
        SuspicionDisplay();

       if (currentSuspicionValue>=suspicionMax)
        {
            EndGame();
        }

    }

    public void SuspicionUpdate()
    {
        currentSuspicionValue += Time.deltaTime;
    }

    public void SuspicionDisplay()
    {
        suspicionLevelText.text = "%" + Mathf.Round(currentSuspicionValue);
    }


    public void EndGame()
    {
        Time.timeScale = 0;
        movingArm.GetComponent<FaceMouse>().enabled=false;
        GameOver.enabled = true;
        TryAgain.gameObject.SetActive(true);

        MetricManagerScript.instance.LogTime("endtime");
    }
}
