using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMusic : MonoBehaviour {
    public AudioSource bgmusic;
    
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        bgmusic.Play();
    }
}
