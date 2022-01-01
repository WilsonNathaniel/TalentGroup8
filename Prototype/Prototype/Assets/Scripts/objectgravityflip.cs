using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectgravityflip : MonoBehaviour
{
    public bool flipstate = false;
    private bool top;
    private CharacterController2D controller;
    private Rigidbody2D rb;


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
