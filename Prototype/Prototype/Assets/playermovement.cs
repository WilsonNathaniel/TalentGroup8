using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public CharacterController2D controller;
    public gravityflip gravity;

    float MoveHorizontal = 0f;
    public float Movespeed = 30f;
    bool jump = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveHorizontal = Input.GetAxisRaw("Horizontal") * Movespeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        controller.Move(MoveHorizontal * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
