using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappearplatform : MonoBehaviour
{
    [SerializeField] private float appeardelay = 1f;
    [SerializeField] private float disappeardelay = 1f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Invoke("disablegameobject", disappeardelay);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Invoke("enablegameobject", appeardelay);
        }
    }

    void disablegameobject()
    {
        gameObject.SetActive(false);
    }

    void enablegameobject()
    {
        gameObject.SetActive(true);
    }
}
