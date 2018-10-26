using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour {
    public string desiredScene;
    public AudioSource buttonSource;
    public AudioClip buttonSound;
    public float vol;


    void Start()
    {
        buttonSource = this.GetComponent<AudioSource>();
        buttonSound = buttonSource.GetComponent<AudioClip>();
    }

    public void NextScene()
    {
        buttonSource.PlayOneShot(buttonSound, vol);
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(1.25f);
        SceneManager.LoadScene(desiredScene);
    }
}
