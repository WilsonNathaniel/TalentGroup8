using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectgravityflip : MonoBehaviour
{
    public bool flipstate = false;
    private bool top;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && GameObject.Find("Player").GetComponent<CharacterController2D>().m_Grounded)
        {
            if (flipstate == false)
            {
                flipstate = true;
                rotation();
            }
            else
            {
                flipstate = false;
                rotation();
            }
        }
    }

    void FixedUpdate()
    {
        if (flipstate == false)
        {
            GetComponent<Rigidbody2D>().gravityScale = 3;
        }
        if (flipstate == true)
        {
            GetComponent<Rigidbody2D>().gravityScale = -3;
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
