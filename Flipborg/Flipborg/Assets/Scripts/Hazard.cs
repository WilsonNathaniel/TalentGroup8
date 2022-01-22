using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")//pindah ke player
        {
            //play sound player mati
            //play animation player mati
            RestartScene();
        }

        if (collision.gameObject.tag == "crate")//pindah ke objek crate
        {
            //play sound 
            //play animation crate destroyed
            collision.gameObject.SetActive(false);
        }
    }



    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
