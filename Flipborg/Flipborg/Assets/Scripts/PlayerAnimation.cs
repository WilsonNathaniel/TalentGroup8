using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;
   // public playermovement variabl;
    public CharacterController2D controller;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x;
        x = Input.GetAxisRaw("Horizontal");

        bool isWalk;
        bool isJump;
        isWalk = (x < 0) || (x > 0);

        //Debug.Log(x);

        isJump = !controller.m_Grounded;
        

        anim.SetBool("IsWalking", isWalk);

        anim.SetBool("IsJumping", isJump);

        bool isIdle;
        isIdle = x == 0;
        anim.SetBool("IsIdle", isIdle);
    }
}
