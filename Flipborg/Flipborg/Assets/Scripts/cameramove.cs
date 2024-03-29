using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    private GameObject camera;
    public bool activated = false;
    [SerializeField] private float moveby = 25;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        camera = GameObject.Find("Main Camera");
        if(collision.gameObject.tag == "Player")
        {
            if (activated == false)
            {
                camera.transform.Translate(moveby, 0, 0);
                activated = true;
            }
            else
            {
                camera.transform.Translate(-moveby, 0, 0);
                activated = false;
            }
        }
    }
}
