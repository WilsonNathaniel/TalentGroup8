using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSwitch : MonoBehaviour
{
    public bool isSwitched = false;
    private bool isPressed = false;
    private bool isOpened = false;


    private SpriteRenderer sr;
    public Sprite newSprite;

    private AudioSource audioSource;
    public AudioClip clip;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
     
        if (Input.GetKey(KeyCode.Q))
        {
            isPressed = true;
     //       Debug.Log("q pressed");
        }

        if (collision.gameObject.tag == "Player" && isPressed == true)
        {
            //play sound door switched off

            isSwitched = true;

            sr.sprite = newSprite;
            if(!audioSource.isPlaying && isOpened == false)
            {
                audioSource.PlayOneShot(clip);
                isOpened = true;
            }
            
            
        }
    }
}
