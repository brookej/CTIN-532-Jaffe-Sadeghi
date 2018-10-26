using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabMenuPopUp : MonoBehaviour {
    public GameObject popUp;
	
	void Start () {

	}

	void Update () {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            popUp.gameObject.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            popUp.gameObject.SetActive(false);
        }
    }
}