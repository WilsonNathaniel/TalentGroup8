using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;
    //public playermovement variabl;
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
        bool actualJump;

        isWalk = (x < 0) || (x > 0);

        //Debug.Log(x);

        isJump = !controller.m_Grounded;

        anim.SetBool("RealJump", controller.jumpIsCallled);

        anim.SetBool("IsWalking", isWalk);

        anim.SetBool("IsJumping", isJump);

        bool isIdle;
        isIdle = x == 0;
        anim.SetBool("IsIdle", isIdle);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Hazard")
        {
            //play sound player mati
            //play animation player mati

            StartCoroutine(RestartScene());
        }
    }

    IEnumerator RestartScene()
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
