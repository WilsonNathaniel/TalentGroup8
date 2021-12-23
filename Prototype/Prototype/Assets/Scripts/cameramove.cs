using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    private GameObject camera;
    private bool activated = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        camera = GameObject.Find("Main Camera");
        if (activated == false)
        {
            camera.transform.Translate(17, 0, 0);
            activated = true;
        }
        else
        {
            camera.transform.Translate(-17, 0, 0);
            activated = false;
        }
    }
}
