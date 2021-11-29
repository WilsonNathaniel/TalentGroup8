using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityflip : MonoBehaviour
{
    public CharacterController2D controller;
    public bool flipstate = false;
    private bool top = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && GetComponent<CharacterController2D>().m_Grounded)
        {
            if(flipstate == false)
            {
                flipstate = true;
                GetComponent<CharacterController2D>().m_JumpForce = -700f;
                rotation();
            }
            else
            {
                flipstate = false;
                GetComponent<CharacterController2D>().m_JumpForce = 700f;
                rotation();
            }
        }

    }

    void FixedUpdate()
    {
        if(flipstate == false)
        {
            GetComponent<Rigidbody2D>().gravityScale = 3;
        }
        if(flipstate == true)
        {
            GetComponent<Rigidbody2D>().gravityScale = -3;
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
