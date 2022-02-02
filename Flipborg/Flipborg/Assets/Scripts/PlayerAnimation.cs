using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;
    public CharacterController2D controller;
    public ActualPauseMenu isPause;
    public AudioSource audios;
    public AudioClip walkClip;
    public GameObject deathPrefab;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        float x;
        x = Input.GetAxisRaw("Horizontal");

        bool isWalk;
        bool isJump;

        isWalk = (x < 0 || x > 0) && !isPause.isPaused;

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
            RestartScene();
        }
    }

    private void RestartScene()
    {
        anim.SetBool("IsDead", true);
        Instantiate(deathPrefab, transform.position, transform.rotation);
        
        //yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
    
}
