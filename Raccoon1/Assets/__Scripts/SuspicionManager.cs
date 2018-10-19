using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuspicionManager : MonoBehaviour {
    private int currentSuspicionValue = 0;
    private int suspicionMax = 100;
    public Text suspicionLevelText;
    public int suspicionUpdateThreshold = 60;
    public int suspicionDecreaseWithPose;


    public void Update()
    {
        SuspicionUpdate();
        SuspicionDisplay();

        if (Input.GetKey(KeyCode.R)&&Input.GetKey(KeyCode.Y))
        {
            TotallyCasualNotSuspicious();
        }

        if (currentSuspicionValue>=suspicionMax)
        {
            //end
        }

    }

    public void SuspicionUpdate()
    {
        for (int i = 0; i < suspicionUpdateThreshold; i++)
        {
            if (i<suspicionUpdateThreshold)
            {
                i++;
            }
            else if (i==suspicionUpdateThreshold)
            {
                i = 0;
                currentSuspicionValue++;
            }
        }
    }

    public void SuspicionDisplay()
    {
        suspicionLevelText.text = "" + currentSuspicionValue;
    }

    public void TotallyCasualNotSuspicious()
    {
        //pose character
            //deactivate current sprites
            //activate fluster sprite as intermediary
                //Time that so it has a few frames to read
            //deactivate fluster sprite
            //activate casual pose sprite
            //play casual whistling sound
        //decrease suspicion value
        currentSuspicionValue = currentSuspicionValue - suspicionDecreaseWithPose;
        //while posed, players can't move
    }
	
}
