using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityflip : MonoBehaviour
{
    public CharacterController2D controller;
    public bool flipstate = false;
    private bool top = false;
    private Rigidbody2D rb;
    public AudioSource audio;
    public AudioClip gravClip;

    void Start()
    {
        controller = GetComponent<CharacterController2D>();
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && controller.m_Grounded)
        {
            if(flipstate == false)
            {
                flipstate = true;
                controller.m_JumpForce = -700f;
                rotation();
            }
            else
            {
                flipstate = false;
                controller.m_JumpForce = 700f;
                rotation();
            }

            //if(!audio.isPlaying)
            //{
                audio.Play();
            //}
        }

    }

    void FixedUpdate()
    {
        if(flipstate == false)
        {
            rb.gravityScale = 3f;
        }
        if(flipstate == true)
        {
            rb.gravityScale = -3f;
        }
    }
    void rotation()
    {
        if (top == false)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 180);
        }
        else
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        top = !top;
    }
}
