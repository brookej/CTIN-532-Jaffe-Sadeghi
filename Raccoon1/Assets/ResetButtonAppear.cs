using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButtonAppear : MonoBehaviour
{
    public GameObject head;
    public GameObject resetButton;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == head)
        {
            resetButton.SetActive(true);
        }
    }

}
