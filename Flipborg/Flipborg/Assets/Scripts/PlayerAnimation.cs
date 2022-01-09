using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;

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
        isWalk = (x < 0) || (x > 0);

        //Debug.Log(x);


        anim.SetBool("IsWalking", isWalk);

        bool isIdle;
        isIdle = x == 0;
        anim.SetBool("IsIdle", isIdle);
    }
}
