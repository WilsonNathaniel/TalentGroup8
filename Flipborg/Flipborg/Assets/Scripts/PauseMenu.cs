using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public TriggerSwitch trigger;
    private AudioSource aus;

    public AudioClip bgm2;

    private bool done = false;
    void Start()
    {
        aus = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(trigger.isSwitched == true && done == false)
        {
            done = true;
            aus.clip = bgm2;
            aus.Play();
        }
    }




}
