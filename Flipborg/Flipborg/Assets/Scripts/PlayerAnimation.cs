using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;
    //public playermovement variabl;
    public CharacterController2D controller;

    public AudioSource audios;
    public AudioClip walkClip;


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

        anim.SetBool("RealJump", controller.jumpIsCallled);
        


        anim.SetBool("IsWalking", isWalk);
        if(isWalk && !isJump)
        {
            if(!audios.isPlaying)
            {
                audios.PlayOneShot(walkClip);
            }
        }else
        {
            audios.Stop();
        }
            

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

            GetComponent<playermovement>().enabled = false;
            StartCoroutine(RestartScene());
        }
    }

    IEnumerator RestartScene()
    {
        anim.SetBool("IsDead", true);

        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
