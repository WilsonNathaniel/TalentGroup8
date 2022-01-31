using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectgravityflip : MonoBehaviour
{
    public bool flipstate = false;
    private bool top;
    private CharacterController2D controller;
    private Rigidbody2D rb;
    public AudioSource Audio;

    public Animator anim;

    void Start()
    {
        controller = GameObject.Find("Player").GetComponent<CharacterController2D>();
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && controller.m_Grounded)
        {
            if (flipstate == false)
            {
                flipstate = true;
               // rotation();
            }
            else
            {
                flipstate = false;
               // rotation();
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Hazard")
        {
            //play sound
            Audio.Play();

            //play anim

            if(flipstate == false)
            {
                anim.SetBool("IsDestroyed", true);
            }else
            {
                anim.SetBool("IsDestroyFlip", true);
            }
            Destroy(gameObject,0.2f);


        }
    }

    void FixedUpdate()
    {
        if (flipstate == false)
        {
            rb.gravityScale = 3;
        }
        if (flipstate == true)
        {
            rb.gravityScale = -3;
        }
    }
    void rotation()
    {
        if (top == false)
        {
            transform.eulerAngles = new Vector3(0, 180f, 180f);
        }
        else
        {
            transform.eulerAngles = Vector3.zero;
        }
        top = !top;
    }
}
